using GBX.NET;
using GBX.NET.Engines.Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GbxTest
{
    public partial class Manage : Form
    {
        public Manage(List<CGameCtnBlock> _finishes, BlockMode mode)
        {
            InitializeComponent();
            switch(mode)
            {
                case BlockMode.CHECKPOINT:
                    Text = "Manage checkpoints";
                    break;
                case BlockMode.FINISH:
                    Text = "Manage finishes";
                    break;
                default:
                    Text = "HUH?";
                    break;            }
            cmbDirection.DataSource = Enum.GetValues(typeof(Direction));
            if (_finishes != null)
            {
                listItems.Tag = _finishes;
                for (int i = 0; i < _finishes.Count; i++)
                {
                    listItems.Items.Add(_finishes[i].Name + " | " + _finishes[i].Coord.ToString() + " | " + _finishes[i].Direction.ToString());
                }
            }
        }

        private void Manage_Load(object sender, EventArgs e)
        {

        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listItems.SelectedIndex != -1)
            {
                btnAdvanced.Enabled = true;
                btnRemove.Enabled = true;
            }
            else
            {
                btnAdvanced.Enabled = false;
                btnRemove.Enabled = false;
            }
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            int selected = listItems.SelectedIndex;
            List<CGameCtnBlock> tagList = (List<CGameCtnBlock>)listItems.Tag;
            CGameCtnBlock bl = tagList[selected];
            this.Height = 610;
            propertyGrid1.SelectedObject = bl;
        }
    }
}
