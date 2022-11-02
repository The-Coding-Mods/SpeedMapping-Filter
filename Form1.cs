
using GBX.NET;
using GBX.NET.Engines.Game;
using TmEssentials;

using AuthorState = System.Tuple<GbxTest.EqMode, TmEssentials.TimeInt32>;
using CheckpointState = System.Tuple<GbxTest.EqMode, int>;
using StatusMessage = System.Tuple<bool, string>;
using BlockState = System.Tuple<GBX.NET.Int3, GBX.NET.Direction>;
using MultilapState = System.Tuple<GbxTest.EqMode, int>;

namespace GbxTest
{
    public partial class Form1 : Form
    {
        private static readonly StatusMessage MESSAGE_DEFAULT = new(true, "");
        private static readonly StatusMessage MESSAGE_GENERIC_ERROR = new(false, "An error occured");
        private static readonly StatusMessage MESSAGE_GENERIC_SUCCESS = new(true, "Success");
        public Form1()
        {
            InitializeComponent();
            cmbEqCheckpoint.DataSource = Enum.GetValues(typeof(EqMode));
            cmbEqAuthor.DataSource = Enum.GetValues(typeof(EqMode));
            cmbEqMultilap.DataSource = Enum.GetValues(typeof(EqMode));
            cmbStartDirection.DataSource = Enum.GetValues(typeof(Direction));
        }

        private void InitializeTemplate()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Please select a map.gbx file";
            openFileDialog.Filter = "Map Gbx files (*map.gbx)|*map.gbx";
            string path;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                path = openFileDialog.FileName;
            else
                return;

            CGameCtnChallenge rawMapInfo = GameBox.ParseNode<CGameCtnChallenge>(path);
            if (rawMapInfo == null) return;
            TMMapTemplate mapTemplate = new(rawMapInfo);
            if (mapTemplate == null) return;

            if (mapTemplate.Start != null && mapTemplate.Start.Count > 0)
            {
                bool canConvert = Misc.Int3ToText(mapTemplate.Start[0].Coord, out string cv);
                txtStartCoords.Text = canConvert ? cv : "";
                cmbStartDirection.SelectedItem = mapTemplate.Start[0].Direction;
            }

            if (mapTemplate.Finish != null && mapTemplate.Finish.Count > 0)
            {
                btnAddFinish.Tag = mapTemplate.Finish;
                lblFinishes.Text = string.Format("{0} finishes", mapTemplate.Finish.Count);
            }

            if (mapTemplate.Checkpoints != null && mapTemplate.Checkpoints.Count > 0)
            {
                btnAddCp.Tag = mapTemplate.Checkpoints;
                lblCheckpoints.Text = string.Format("{0} checkpoints", mapTemplate.Checkpoints.Count);
            }

            if (mapTemplate.AuthorTime != null)
                txtAuthorTime.Text = mapTemplate.AuthorTime.Value.TotalMilliseconds.ToString();

            if(mapTemplate.CheckpointNum != null)
                numCheckpoint.Value = mapTemplate.CheckpointNum.Value;

            if(mapTemplate.IsMultiLap != null && mapTemplate.LapCount != null)
            {
                numMultilap.Value = mapTemplate.LapCount.Value;
            }
        }

        private BlockState CGameBlockToBlockState(CGameCtnBlock item)
        {
            return new BlockState(item.Coord, item.Direction);
        }

        private TMMapRules? CreateRules()
        {
            var cpCount = GetCheckpointCountState();
            (CheckpointState? cpCountState, StatusMessage cpStatus) = cpCount;
            if (cpCountState != null)
            {
                var (cpCountStatusSuccess, cpCountStatusMessage) = cpStatus;
                if (!cpCountStatusSuccess) { MessageBox.Show("Error", cpCountStatusMessage, MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
            }

            var author = GetAuthorTimeState();
            (AuthorState? authorState, StatusMessage authorMessage) = author;
            if (authorState != null)
            {
                var (authorStatusSuccess, authorStatusMessage) = authorMessage;
                if (!authorStatusSuccess) { MessageBox.Show("Error", authorStatusMessage, MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
            }

            var start = GetStartState();
            (BlockState? startState, StatusMessage startMessage) = start;
            if (startState != null)
            {
                var (startStatusSuccess, startStatusMessage) = startMessage;  
                if (!startStatusSuccess) { MessageBox.Show("Error", startStatusMessage, MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
            }

            var finish = GetFinishState();
            List<BlockState>? finishState = null;
            (List<CGameCtnBlock>? finishList, StatusMessage finishMessage) = finish;
            if(finishList != null)
            {              
                var (finishStatusSuccess, finishStatusMessage) = finishMessage;
                if (!finishStatusSuccess) { MessageBox.Show("Error", finishStatusMessage, MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
                finishState = finishList.ConvertAll(x => CGameBlockToBlockState(x));
            }

            var checkpoint = GetCheckpointState();
            List<BlockState>? cpState = null;
            (List<CGameCtnBlock>? cpList, StatusMessage cpMessage) = checkpoint;
            if (cpList != null)
            {
                var (cpStatusSuccess, cpStatusMessage) = cpMessage;
                if (!cpStatusSuccess) { MessageBox.Show("Error", cpStatusMessage, MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
                cpState = cpList.ConvertAll(x => CGameBlockToBlockState(x));
            }

            var multilap = GetMultilapState();
            (MultilapState? multiState, StatusMessage multiMessage) = multilap;
            if (multiState != null)
            {
                var (multiStatusSuccess, multiStatusMessage) = multiMessage;
                if (!multiStatusSuccess) { MessageBox.Show("Error", multiStatusMessage, MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
            }

            TMMapRules? rules = new(startState, finishState, cpState, cpCountState, multiState, authorState);
            return rules;
        }

        private Tuple<MultilapState?, StatusMessage> GetMultilapState()
        {
            Tuple<MultilapState?, StatusMessage> state = new(null, MESSAGE_DEFAULT);
            if (chkMultilap.Checked)
            {
                EqMode eqMode = (EqMode)cmbEqMultilap.SelectedItem;
                int lapCount = (int)numMultilap.Value;
                state = new Tuple<MultilapState?, StatusMessage>(new MultilapState(eqMode, lapCount), MESSAGE_GENERIC_SUCCESS);
            }
            return state;
        }

        private Tuple<BlockState?, StatusMessage> GetStartState()
        {
            Tuple<BlockState?, StatusMessage> state = new(null, MESSAGE_DEFAULT);
            if (chkStart.Checked)
            {
                bool canConvert = Misc.TextToInt3(txtStartCoords.Text, out Int3 converted);
                if (canConvert)
                    state = new Tuple<BlockState?, StatusMessage>(new BlockState(converted, Direction.North), MESSAGE_GENERIC_SUCCESS);
                else
                    return new Tuple<BlockState?, StatusMessage>(null, new StatusMessage(false, "Couldn't convert coords"));
            }
            return state;
        }

        private Tuple<List<CGameCtnBlock>?, StatusMessage> GetFinishState()
        {
            Tuple<List<CGameCtnBlock>?, StatusMessage> state = new(null, MESSAGE_DEFAULT);
            if (chkFinish.Checked)
            {
                List<CGameCtnBlock> tag = (List<CGameCtnBlock>)btnAddFinish.Tag;
                if (tag != null)
                    return new Tuple<List<CGameCtnBlock>?, StatusMessage>(tag, MESSAGE_GENERIC_SUCCESS);
            }
            return state;
        }

        private Tuple<List<CGameCtnBlock>?, StatusMessage> GetCheckpointState()
        {
            Tuple<List<CGameCtnBlock>?, StatusMessage> state = new(null, MESSAGE_DEFAULT);
            if (chkCheckpoint.Checked)
            {
                List<CGameCtnBlock> tag = (List<CGameCtnBlock>)btnAddCp.Tag;
                if (tag != null)
                    return new Tuple<List<CGameCtnBlock>?, StatusMessage>(tag, MESSAGE_GENERIC_SUCCESS);
            }
            return state;
        }

        private Tuple<CheckpointState?, StatusMessage> GetCheckpointCountState()
        {
            Tuple<CheckpointState?, StatusMessage> cp = new(null, MESSAGE_DEFAULT);
            if (chkCheckpointCount.Checked)
            {
                EqMode eqMode = (EqMode)cmbEqCheckpoint.SelectedItem;
                int cpCount = (int)numCheckpoint.Value;
                cp = new Tuple<CheckpointState?, StatusMessage>(new CheckpointState(eqMode, cpCount), MESSAGE_GENERIC_SUCCESS);
            }
            return cp;
        }

        private Tuple<AuthorState?, StatusMessage> GetAuthorTimeState()
        {
            Tuple<AuthorState?, StatusMessage> authorTime = new(null, MESSAGE_DEFAULT);
            if (chkAuthorTime.Checked)
            {
                EqMode eqMode = (EqMode)cmbEqAuthor.SelectedItem;
                bool canConvert = int.TryParse(txtAuthorTime.Text, out int num);
                if (canConvert)
                {
                    TimeInt32 time = new (num);
                    authorTime = new Tuple<AuthorState?, StatusMessage>(new AuthorState(eqMode, time), MESSAGE_GENERIC_SUCCESS);
                }
                else
                    return new Tuple<AuthorState?, StatusMessage>(null, new StatusMessage(false, "Invalid time"));
             
            }
            return authorTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TMMapRules? rule = CreateRules();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Please select a .gbx file";
            openFileDialog.Filter = "Gbx files (*.gbx)|*.gbx";
            string path = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                path = openFileDialog.FileName;

            var map = GameBox.ParseNode<CGameCtnChallenge>(path);

            TMMapTemplate template = new(map);

            template.Obeys(rule);
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            InitializeTemplate();
        }

        private void chkIgnoreTemplate_CheckedChanged(object sender, EventArgs e)
        {
            grpGeneral.Enabled = chkIgnoreTemplate.Checked;
            grpBlock.Enabled = chkIgnoreTemplate.Checked;
            grpFilter.Enabled = chkIgnoreTemplate.Checked;
        }

        private void btnAddFinish_Click(object sender, EventArgs e)
        {
            List<CGameCtnBlock> tag = (List<CGameCtnBlock>)btnAddFinish.Tag;
            Manage frm = new(tag, BlockMode.FINISH)
            {
                ShowInTaskbar = false
            };
            DialogResult result = frm.ShowDialog();
            List<Tuple<CGameCtnBlock?, BlockState>> finishList = frm.BlockList;
            if(result == DialogResult.OK)
            {
                List<BlockState> updated = finishList.Select(x => x.Item2).ToList();
                btnAddFinish.Tag = updated;
            }
        }

        private void btnAddCp_Click(object sender, EventArgs e)
        {
            List<CGameCtnBlock> tag = (List<CGameCtnBlock>)btnAddCp.Tag;
            Manage frm = new(tag, BlockMode.CHECKPOINT)
            {
                ShowInTaskbar = false
            };
            DialogResult result = frm.ShowDialog();
            List<Tuple<CGameCtnBlock?, BlockState>> cpList = frm.BlockList;
            if (result == DialogResult.OK)
            {
                List<BlockState> updated = cpList.Select(x => x.Item2).ToList();
                btnAddFinish.Tag = updated;
            }
        }

        private void numMultilap_ValueChanged(object sender, EventArgs e)
        {
            lblMultilap.Text = numMultilap.Value == 1 ? "lap" : "laps";
        }

        private void numCheckpoint_ValueChanged(object sender, EventArgs e)
        {
            lblCheckpoint.Text = numCheckpoint.Value == 1 ? "checkpoint" : "checkpoints";
        }
    }
}