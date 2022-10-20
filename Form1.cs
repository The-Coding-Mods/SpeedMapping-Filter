
using GBX.NET;
using GBX.NET.Engines.Game;
using TmEssentials;

using AuthorState = System.Tuple<GbxTest.EqMode, TmEssentials.TimeInt32>;
using CheckpointState = System.Tuple<GbxTest.EqMode, int>;
using StatusMessage = System.Tuple<bool, string>;
using BlockState = System.Tuple<GbxTest.EqMode, GBX.NET.Int3>;
using MultilapState = System.Int32;

namespace GbxTest
{
    public partial class Form1 : Form
    {
        private static readonly StatusMessage MESSAGE_DEFAULT = new StatusMessage(true, "");
        private static readonly StatusMessage MESSAGE_GENERIC_ERROR = new StatusMessage(false, "An error occured");
        private static readonly StatusMessage MESSAGE_GENERIC_SUCCESS = new StatusMessage(true, "Success");
        public Form1()
        {
            InitializeComponent();
            cmbEqCheckpoint.DataSource = Enum.GetValues(typeof(EqMode));
            cmbEqAuthor.DataSource = Enum.GetValues(typeof(EqMode));
        }

        private Int3 GetStartCoords()
        {
            //Test cases
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Please select a .gbx file";
            openFileDialog.Filter = "Gbx files (*.gbx)|*.gbx";
            string path = "";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                path = openFileDialog.FileName;

            var map = GameBox.ParseNode<CGameCtnChallenge>(path);

            var map2 = GameBox.ParseNode<CGameCtnChallenge>("C:\\Users\\valbj\\Downloads\\gigachad.Map.Gbx");

            TMMapTemplate template = new(map);

            TMMapTemplate template2 = new(map2);

            TMMapRules rules = new(null, null, null, null, new AuthorState(EqMode.LESS_THAN, TimeInt32.MaxValue));

            bool val = template2.Obeys(rules);
            return map.Blocks.First(e => e.Name.ToLower().Contains("start")).Coord;
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

            TMMapRules? rules = new(null, null, cpState, null, authorState);
            return rules;
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
                TimeInt32 time = new (TotalMilliseconds: 1000);
                try
                {
                    time = new TimeInt32(Convert.ToInt32(txtAuthorTime.Text));
                }
                catch (Exception ex)
                {
                    return new Tuple<AuthorState?, StatusMessage>(null, new StatusMessage(false, "Invalid time"));
                }
                authorTime = new Tuple<AuthorState?, StatusMessage>(new AuthorState(eqMode, time), MESSAGE_GENERIC_SUCCESS);
            }
            return authorTime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TMMapRules? rule = CreateRules();
        }

        private void btnTemplate_Click(object sender, EventArgs e)
        {
            Int3 val = GetStartCoords();
            txtStartCoords.Text = val.ToString();
        }

        private void chkIgnoreTemplate_CheckedChanged(object sender, EventArgs e)
        {
            grpGeneral.Enabled = chkIgnoreTemplate.Checked;
            grpBlock.Enabled = chkIgnoreTemplate.Checked;
            grpFilter.Enabled = chkIgnoreTemplate.Checked;
        }
    }
}