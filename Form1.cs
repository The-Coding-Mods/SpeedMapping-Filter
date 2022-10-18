
using GBX.NET.Engines.Game;
using GBX.NET;
using TmEssentials;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Globalization;

namespace GbxTest
{
    public partial class Form1 : Form
    {
        TMMapRules globalRule;
        public Form1()
        {
            InitializeComponent();
            globalRule = new(null, null, null, null, null);
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

            TMMapRules rules = new(null, null, null, null, new Tuple<EqMode, TimeInt32>(EqMode.LESS_THAN, TimeInt32.MaxValue));

            bool val = template2.Obeys(rules);
            return map.Blocks.First(e => e.Name.ToLower().Contains("start")).Coord;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var map = GameBox.ParseNode<CGameCtnChallenge>("C:\\Users\\valbj\\OneDrive\\Documents\\Trackmania\\Maps\\Downloaded\\idk-tbh.Map.Gbx");
            var startBlock = map.Blocks.First(e => e.Name.ToLower().Contains("start"));
            Console.WriteLine("Test");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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

        private void cmbEqCheckpoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (globalRule.ForceCheckpointCount != null)
            {
                var (eq, count) = globalRule.ForceCheckpointCount;
                EqMode eqMode = (EqMode)cmbEqCheckpoint.SelectedItem;
                if (eq != eqMode) globalRule.ForceCheckpointCount = new Tuple<EqMode, int>(eqMode, count);
            }
        }

        private void chkCheckpoint_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCheckpoint.Checked)
            {
                EqMode eqMode = (EqMode)cmbEqCheckpoint.SelectedItem;
                int cpCount = (int)numCheckpoint.Value;
                globalRule.ForceCheckpointCount = new Tuple<EqMode, int>(eqMode, cpCount);
            }
            else
                globalRule.ForceCheckpointCount = null;
        }

        private void chkAuthorTime_CheckedChanged(object sender, EventArgs e)
        {
            if(chkAuthorTime.Checked)
            {
                EqMode eqMode = (EqMode)cmbEqAuthor.SelectedItem;
                TimeInt32 time = new TimeInt32(TotalMilliseconds:1000);
                try
                {
                    time = new TimeInt32(Convert.ToInt32(txtAuthorTime.Text));
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Invalid time! Please enter time in milliseconds.", "Formatting error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAuthorTime.Text = "0";
                    return;
                }
                globalRule.ForceAuthorTime = new Tuple<EqMode, TimeInt32>(eqMode, time);
            }
        }

        private void txtAuthorTime_TextChanged(object sender, EventArgs e)
        {
            if(txtAuthorTime.TextLength > 0 && globalRule.ForceAuthorTime != null)
            {
                var (eq, time) = globalRule.ForceAuthorTime;
                TimeInt32 calculated;
                try
                {
                    calculated = new TimeInt32(Convert.ToInt32(txtAuthorTime.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid time! Please enter time in milliseconds.", "Formatting error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAuthorTime.Text = "0";
                    return;
                }

                if (calculated != time) globalRule.ForceAuthorTime = new Tuple<EqMode, TimeInt32>(eq, calculated);
            }
        }
    }
}