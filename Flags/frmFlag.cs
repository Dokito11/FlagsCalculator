using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Flags
{
    public partial class FlagCalculator : Form
    {
        private UInt32 FlagFinder = 0;
        private UInt32 OldNumber = 0;
        private UInt32 FlagNum = 0;
        private Flag[] ListFlags = new Flag[32];
        private int flagCount = 0;

        public FlagCalculator()
        {
            InitializeComponent();
            InitFlags();
        }

        private void InitFlags()
        {
            FlagSetup(Checkbox1, false, "0x1");
            FlagSetup(Checkbox2, false, "0x2");
            FlagSetup(Checkbox4, false, "0x4");
            FlagSetup(Checkbox8, false, "0x8");
            FlagSetup(Checkbox10, false, "0x10");
            FlagSetup(Checkbox20, false, "0x20");
            FlagSetup(Checkbox40, false, "0x40");
            FlagSetup(Checkbox80, false, "0x80");
            FlagSetup(Checkbox100, false, "0x100");
            FlagSetup(Checkbox200, false, "0x200");
            FlagSetup(Checkbox400, false, "0x400");
            FlagSetup(Checkbox800, false, "0x800");
            FlagSetup(Checkbox1000, false, "0x1000");
            FlagSetup(Checkbox2000, false, "0x2000");
            FlagSetup(Checkbox4000, false, "0x4000");
            FlagSetup(Checkbox8000, false, "0x8000");
            FlagSetup(Checkbox10000, false, "0x10000");
            FlagSetup(Checkbox20000, false, "0x20000");
            FlagSetup(Checkbox40000, false, "0x40000");
            FlagSetup(Checkbox80000, false, "0x80000");
            FlagSetup(Checkbox100000, false, "0x100000");
            FlagSetup(Checkbox200000, false, "0x200000");
            FlagSetup(Checkbox400000, false, "0x400000");
            FlagSetup(Checkbox800000, false, "0x800000");
            FlagSetup(Checkbox1000000, false, "0x1000000");
            FlagSetup(Checkbox2000000, false, "0x2000000");
            FlagSetup(Checkbox4000000, false, "0x4000000");
            FlagSetup(Checkbox8000000, false, "0x8000000");
            FlagSetup(Checkbox10000000, false, "0x10000000");
            FlagSetup(Checkbox20000000, false, "0x20000000");
            FlagSetup(Checkbox40000000, false, "0x40000000");
            FlagSetup(Checkbox80000000, false, "0x80000000");
            ClearFlags();
        }

        public void ClearFlags()
        {
            for (int i = 0; i < ListFlags.Count(); i++)
            {
                ListFlags[i].Active = false;
                ListFlags[i].FlagCheckbox.Checked = false;
            }
        }

        public void FlagSetup(CheckBox flagCheckbox, bool active, string flagString)
        {
            Flag newFlag = new Flag(active, flagString, flagCheckbox);
            ListFlags[flagCount] = newFlag;
            flagCount++;
        }

        public void CheckboxManager(CheckBox checkbox, int pos, UInt32 num)
        {
            if (checkbox.Checked)
            {
                FlagNum += num;
            }
            else
            {
                FlagNum -= num;
            }
            ListFlags[pos].Active = checkbox.Checked;

            TextboxFlag.Text = Convert.ToString(FlagNum);
            OldNumber = FlagNum;
            DisplayFlags();
        }

        /// <summary>
        /// Checks the correct boxes according to the number given in the textbox.
        /// </summary>
        private void setAllFlags()
        {

            foreach(Flag flag in ListFlags.Reverse())
            {
                if (FlagFinder >= flag.Value)
                {
                    flag.SetActive(true);
                    FlagFinder -= flag.Value;
                    continue;
                }
                flag.SetActive(false);
            }

        }

        /// <summary>
        /// Displays active flags in the listbox
        /// </summary>
        private void DisplayFlags()
        {
            ListboxFlags.Items.Clear();
            for (int i = 0; i < ListFlags.Count(); i++)
            {
                if (ListFlags[i].Active)
                {
                    ListboxFlags.Items.Add(ListFlags[i].FlagString);
                }
            }
        }

        private Flag getFlag(CheckBox checkbox)
        {
            for (int i = 0; i < ListFlags.Length; i++)
            {
                if (ListFlags[i].FlagCheckbox == checkbox)
                    return ListFlags[i];
            }
            return null;
        }

        private void Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkbox = (CheckBox)sender;
            Flag flag = getFlag(checkbox);

            CheckboxManager(checkbox, flag.Position, flag.Value);
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {

            if (TextboxFlag.Text == "")
            {
                TextboxFlag.Text = "0";
            }
            
            if (Convert.ToUInt64(TextboxFlag.Text) > 4294967295)
            {
                TextboxFlag.Text = "4294967295";
            }

            FlagFinder = Convert.ToUInt32(TextboxFlag.Text);
            FlagNum = OldNumber;

            setAllFlags();

            DisplayFlags();

        }

        private void TextboxFlag_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
