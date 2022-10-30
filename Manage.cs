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

using BlockState = System.Tuple<GBX.NET.Int3, GBX.NET.Direction>;

namespace GbxTest
{
    public partial class Manage : Form
    {
        private bool advanced;
        public List<Tuple<CGameCtnBlock?, BlockState>> BlockList;
        public Manage(List<CGameCtnBlock> _blocks, BlockMode mode)
        {
            InitializeComponent();
            advanced = false;
            BlockList = new List<Tuple<CGameCtnBlock?, BlockState>>();
            listItems.Tag = _blocks;
            cmbDirection.DataSource = Enum.GetValues(typeof(Direction));
            switch (mode)
            {
                case BlockMode.CHECKPOINT:
                    Text = "Manage checkpoints";
                    break;
                case BlockMode.FINISH:
                    Text = "Manage finishes";
                    break;
                default:
                    Text = "HUH?";
                    break;
            }

            InitBlockList(_blocks);
            WriteBlockList();
        }

        private void InitBlockList(List<CGameCtnBlock> blocks)
        {
            if (blocks != null)
            {
                foreach (CGameCtnBlock block in blocks)
                    BlockList.Add(new Tuple<CGameCtnBlock?, BlockState>(block, new(block.Coord, block.Direction)));
            }
        }

        private void WriteBlockList()
        {
            listItems.Items.Clear();
            for(int i = 0; i < BlockList.Count; i++)
            {
                var (_, state) = BlockList[i];
                var (coord, direction) = state;
                string formatter = string.Format("{0}\t{1}", coord, direction);
                listItems.Items.Add(formatter);
            }
        }

        private void InsertBlock(BlockState blockState)
        {
            var (coord, direction) = blockState;
            BlockList.Add(new Tuple<CGameCtnBlock?, BlockState>(null, new(coord, direction)));
            WriteBlockList();
        }

        private void Manage_Load(object sender, EventArgs e)
        {

        }

        private void listItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listItems.SelectedIndex != -1)
            {
                btnAdvanced.Enabled = BlockList[listItems.SelectedIndex].Item1 != null;//***
                btnRemove.Enabled = true;
                if(advanced)
                {
                    int selected = listItems.SelectedIndex;
                    List<CGameCtnBlock> tagList = (List<CGameCtnBlock>)listItems.Tag;
                    CGameCtnBlock bl = tagList[selected];
                    propertyGrid1.SelectedObject = bl;
                }
            }
            else
            {
                btnAdvanced.Enabled = false;
                btnRemove.Enabled = false;
            }
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            if(advanced)
            {
                advanced = false;
                Height = 360;
                return;
            }
            int selected = listItems.SelectedIndex;
            var (custom, state) = BlockList[selected];
            advanced = true;
            if (custom != null)
            {
                Height = 610;
                propertyGrid1.SelectedObject = custom;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Misc.TextToInt3(txtCoords.Text, out Int3 converted);
            Direction dir = (Direction)cmbDirection.SelectedItem;
            InsertBlock(new(converted, dir));
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }
    }
}
