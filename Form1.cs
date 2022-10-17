
using GBX.NET.Engines.Game;
using GBX.NET;

namespace GbxTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            TMMapRules rules = new(new Tuple<Int3, Direction>(template.Start.Coord, template.Start.Direction),
                null, 
                new Tuple<EqMode, int>(EqMode.LESSTHAN, 2), 
                null, 
                null);

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
    }
}