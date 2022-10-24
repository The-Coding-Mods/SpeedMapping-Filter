
using GBX.NET;
using GBX.NET.Engines.Game;
using TmEssentials;

using AuthorState = System.Tuple<GbxTest.EqMode, TmEssentials.TimeInt32>;
using CheckpointState = System.Tuple<GbxTest.EqMode, int>;
using StatusMessage = System.Tuple<bool, string>;
using BlockState = System.Tuple<GBX.NET.Int3, GBX.NET.Direction>;

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
            cmbStartDirection.DataSource = Enum.GetValues(typeof(Direction));
        }

        private void InitializeTemplate()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Please select a map.gbx file";
            openFileDialog.Filter = "Map Gbx files (*map.gbx)|*map.gbx";
            string path = "";
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
                bool canConvert = Int3ToText(mapTemplate.Start[0].Coord, out string cv);
                txtStartCoords.Text = canConvert ? cv : "";
                cmbStartDirection.SelectedItem = mapTemplate.Start[0].Direction;
            }

            if (mapTemplate.Finish != null && mapTemplate.Finish.Count > 0)
            {
                btnAddFinish.Tag = mapTemplate.Finish;
            }

            if (mapTemplate.Checkpoints != null && mapTemplate.Checkpoints.Count > 0)
            {
                btnAddCp.Tag = mapTemplate.Checkpoints;
            }

            if (mapTemplate.AuthorTime != null)
                txtAuthorTime.Text = mapTemplate.AuthorTime.Value.TotalMilliseconds.ToString();

            if(mapTemplate.CheckpointNum != null)
                numCheckpoint.Value = mapTemplate.CheckpointNum.Value;
        }

        private TMMapRules? CreateRules()
        {
            var cp = GetCheckpointState();
            (CheckpointState? cpState, StatusMessage cpStatus) = cp;
            if (cpState != null)
            {
                var (cpStatusSuccess, cpStatusMessage) = cpStatus;
                if (!cpStatusSuccess) { MessageBox.Show("Error", cpStatusMessage, MessageBoxButtons.OK, MessageBoxIcon.Error); return null; }
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

            TMMapRules? rules = new(startState, null, null, cpState, null, authorState);
            return rules;
        }

        private Tuple<BlockState?, StatusMessage> GetStartState()
        {
            Tuple<BlockState?, StatusMessage> state = new(null, MESSAGE_DEFAULT);
            if (chkStart.Checked)
            {
                bool canConvert = TextToInt3(txtStartCoords.Text, out Int3 converted);
                if (canConvert)
                    state = new Tuple<BlockState?, StatusMessage>(new BlockState(converted, Direction.North), MESSAGE_GENERIC_SUCCESS);
                else
                    return new Tuple<BlockState?, StatusMessage>(null, new StatusMessage(false, "Couldn't convert coords"));
            }
            return state;
        }

        private Tuple<List<BlockState>?, StatusMessage> GetFinishState()
        {
            Tuple<List<BlockState>?, StatusMessage> state = new(null, MESSAGE_DEFAULT);
            if(chkFinish.Checked)
            {

            }
            return null;
        }

        private Tuple<CheckpointState?, StatusMessage> GetCheckpointState()
        {
            Tuple<CheckpointState?, StatusMessage> cp = new(null, MESSAGE_DEFAULT);
            if (chkCheckpoint.Checked)
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


        private static bool TextToInt3(string text, out Int3 conversion)
        {
            conversion = default;
            text = text.Replace(" ", string.Empty);
            string[] split = text.Split(',');
            if (split.Length != 3) return false;
            int[] xyz = new int[split.Length];
            for(int i = 0; i < split.Length; i++)
            {
                bool canConvert = int.TryParse(split[i], out int num);
                if(canConvert)
                    xyz[i] = num;
                else
                    return false;
            }
            conversion = new Int3(xyz[0], xyz[1], xyz[2]);
            return true;
        }

        private static bool Int3ToText(Int3 coord, out string conversion)
        {
            conversion = string.Format("{0},{1},{2}", coord.X, coord.Y, coord.Z);
            return true;
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
            frm.ShowDialog();
        }

        private void btnAddCp_Click(object sender, EventArgs e)
        {
            List<CGameCtnBlock> tag = (List<CGameCtnBlock>)btnAddCp.Tag;
            Manage frm = new(tag, BlockMode.CHECKPOINT)
            {
                ShowInTaskbar = false
            };
            frm.ShowDialog();
        }
    }
}