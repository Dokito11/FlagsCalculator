using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public partial class FlagCalculator : Form
    {
        public FlagCalculator()
        {
            InitializeComponent();
            InitFlags();
        }

        private UInt32 FlagFinder = 0;
        private UInt32 FlagNum = 0;
        private bool TextUsed = false;
        private bool CheckUsed = false;
        private bool init = true;
        private Flag[] ListFlags = new Flag[32];
        private int flagCount = 0;

        private void InitFlags()
        {
            FlagSetup(Checkbox1, 1, false, "0x1");
            FlagSetup(Checkbox2, 2, false, "0x2");
            FlagSetup(Checkbox4, 4, false, "0x4");
            FlagSetup(Checkbox8, 8, false, "0x8");
            FlagSetup(Checkbox10, 10, false, "0x10");
            FlagSetup(Checkbox20, 20, false, "0x20");
            FlagSetup(Checkbox40, 40, false, "0x40");
            FlagSetup(Checkbox80, 80, false, "0x80");
            FlagSetup(Checkbox100, 100, false, "0x100");
            FlagSetup(Checkbox200, 200, false, "0x200");
            FlagSetup(Checkbox400, 400, false, "0x400");
            FlagSetup(Checkbox800, 800, false, "0x800");
            FlagSetup(Checkbox1000, 1000, false, "0x1000");
            FlagSetup(Checkbox2000, 2000, false, "0x2000");
            FlagSetup(Checkbox4000, 4000, false, "0x4000");
            FlagSetup(Checkbox8000, 8000, false, "0x8000");
            FlagSetup(Checkbox10000, 10000, false, "0x10000");
            FlagSetup(Checkbox20000, 20000, false, "0x20000");
            FlagSetup(Checkbox40000, 40000, false, "0x40000");
            FlagSetup(Checkbox80000, 80000, false, "0x80000");
            FlagSetup(Checkbox100000, 100000, false, "0x100000");
            FlagSetup(Checkbox200000, 200000, false, "0x200000");
            FlagSetup(Checkbox400000, 400000, false, "0x400000");
            FlagSetup(Checkbox800000, 800000, false, "0x800000");
            FlagSetup(Checkbox1000000, 1000000, false, "0x1000000");
            FlagSetup(Checkbox2000000, 2000000, false, "0x2000000");
            FlagSetup(Checkbox4000000, 4000000, false, "0x4000000");
            FlagSetup(Checkbox8000000, 8000000, false, "0x8000000");
            FlagSetup(Checkbox10000000, 10000000, false, "0x10000000");
            FlagSetup(Checkbox20000000, 20000000, false, "0x20000000");
            FlagSetup(Checkbox40000000, 40000000, false, "0x40000000");
            FlagSetup(Checkbox80000000, 80000000, false, "0x80000000");
            for (int i = 0; i < ListFlags.Count(); i++)
            {
                ListFlags[i].Active = false;
            }
            if (init)
            {
                init = false;
            }
        }

        public void FlagSetup(CheckBox flagCheckbox, int id, bool active, string flagString)
        {
            flagCheckbox.Checked = false;

            if (init)
            {
                Flag newFlag = new Flag(id, active, flagString);
                ListFlags[flagCount] = newFlag;
                flagCount++;
            }

        }

        public void CheckboxManager(CheckBox checkbox, int pos, UInt32 num, bool TextUsed)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (checkbox.Checked)
            {
                ListFlags[pos].Active = true;
                FlagNum += num;
            }
            else
            {
                ListFlags[pos].Active = false;
                FlagNum -= num;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            DisplayFlags();
            CheckUsed = false;
        }

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToUInt64(TextboxFlag.Text) > 4294967295)
            {
                TextboxFlag.Text = "4294967295";
                MessageBox.Show("Input cannot be higher than 4,294,967,295");
            }
        }

        private void Checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox1, 0, 1, TextUsed);
        }

        private void Checkbox2_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox2, 1, 2, TextUsed);
        }

        private void Checkbox4_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox4, 2, 4, TextUsed);
        }

        private void Checkbox8_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox8, 3, 8, TextUsed);
        }

        private void Checkbox10_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox10, 4, 16, TextUsed);
        }

        private void Checkbox20_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox20, 5, 32, TextUsed);
        }

        private void Checkbox40_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox40, 6, 64, TextUsed);
        }

        private void Checkbox80_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox80, 7, 128, TextUsed);
        }

        private void Checkbox100_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox100, 8, 256, TextUsed);
        }

        private void Checkbox200_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox200, 9, 512, TextUsed);
        }

        private void Checkbox400_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox400, 10, 1024, TextUsed);
        }

        private void Checkbox800_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox800, 11, 2048, TextUsed);
        }

        private void Checkbox1000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox1000, 12, 4096, TextUsed);
        }

        private void Checkbox2000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox2000, 13, 8192, TextUsed);
        }

        private void Checkbox4000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox4000, 14, 16384, TextUsed);
        }

        private void Checkbox8000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox8000, 15, 32768, TextUsed);
        }

        private void Checkbox10000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox10000, 16, 65536, TextUsed);
        }

        private void Checkbox20000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox20000, 17, 131072, TextUsed);
        }

        private void Checkbox40000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox40000, 18, 262144, TextUsed);
        }

        private void Checkbox80000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox80000, 19, 524288, TextUsed);
        }

        private void Checkbox100000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox100000, 20, 1048576, TextUsed);
        }

        private void Checkbox200000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox200000, 21, 2097152, TextUsed);
        }

        private void Checkbox400000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox400000, 22, 4194304, TextUsed);
        }

        private void Checkbox800000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox800000, 23, 8388608, TextUsed);
        }

        private void Checkbox1000000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox1000000, 24, 16777216, TextUsed);
        }

        private void Checkbox2000000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox2000000, 25, 33554432, TextUsed);
        }

        private void Checkbox4000000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox4000000, 26, 67108864, TextUsed);
        }

        private void Checkbox8000000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox8000000, 27, 134217728, TextUsed);
        }

        private void Checkbox10000000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox10000000, 28, 268435456, TextUsed);
        }

        private void Checkbox20000000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox20000000, 29, 536870912, TextUsed);
        }

        private void Checkbox40000000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox40000000, 30, 1073741824, TextUsed);
        }

        private void Checkbox80000000_CheckedChanged(object sender, EventArgs e)
        {
            CheckboxManager(Checkbox80000000, 31, 2147483648, TextUsed);
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (CheckUsed)
            {
                return;
            }

            TextUsed = true;

            InitFlags();

            // prevents crash when textbox is empty and clears all checkboxes (temp fix)
            if (TextboxFlag.Text == "")
            {
                return;
            }

            FlagFinder = FlagNum = Convert.ToUInt32(TextboxFlag.Text);
            InitFlags();

            if (FlagFinder > 4294967295)
            {
                MessageBox.Show("Number is too high");
            }
            else
            {
                if (FlagFinder >= 2147483648)
                {
                    ListFlags[31].SetActive(Checkbox80000000, true);
                    FlagFinder -= 2147483648;
                }
                if (FlagFinder >= 1073741824)
                {
                    ListFlags[30].SetActive(Checkbox40000000, true);
                    FlagFinder -= 1073741824;
                }
                if (FlagFinder >= 536870912)
                {
                    ListFlags[29].SetActive(Checkbox20000000, true);
                    FlagFinder -= 536870912;
                }
                if (FlagFinder >= 268435456)
                {
                    ListFlags[28].SetActive(Checkbox10000000, true);
                    FlagFinder -= 268435456;
                }
                if (FlagFinder >= 134217728)
                {
                    ListFlags[27].SetActive(Checkbox8000000, true);
                    FlagFinder -= 134217728;
                }
                if (FlagFinder >= 67108864)
                {
                    ListFlags[26].SetActive(Checkbox4000000, true);
                    FlagFinder -= 67108864;
                }
                if (FlagFinder >= 33554432)
                {
                    ListFlags[25].SetActive(Checkbox2000000, true);
                    FlagFinder -= 33554432;
                }
                if (FlagFinder >= 16777216)
                {
                    ListFlags[24].SetActive(Checkbox1000000, true);
                    FlagFinder -= 16777216;
                }
                if (FlagFinder >= 8388608)
                {
                    ListFlags[23].SetActive(Checkbox800000, true);
                    FlagFinder -= 8388608;
                }
                if (FlagFinder >= 4194304)
                {
                    ListFlags[22].SetActive(Checkbox400000, true);
                    FlagFinder -= 4194304;
                }
                if (FlagFinder >= 2097152)
                {
                    ListFlags[21].SetActive(Checkbox200000, true);
                    FlagFinder -= 2097152;
                }
                if (FlagFinder >= 1048576)
                {
                    ListFlags[20].SetActive(Checkbox100000, true);
                    FlagFinder -= 1048576;
                }
                if (FlagFinder >= 524288)
                {
                    ListFlags[19].SetActive(Checkbox80000, true);
                    FlagFinder -= 524288;
                }
                if (FlagFinder >= 262144)
                {
                    ListFlags[18].SetActive(Checkbox40000, true);
                    FlagFinder -= 262144;
                }
                if (FlagFinder >= 131072)
                {
                    ListFlags[17].SetActive(Checkbox20000, true);
                    FlagFinder -= 131072;
                }
                if (FlagFinder >= 65536)
                {
                    ListFlags[16].SetActive(Checkbox10000, true);
                    FlagFinder -= 65536;
                }
                if (FlagFinder >= 32768)
                {
                    ListFlags[15].SetActive(Checkbox8000, true);
                    FlagFinder -= 32768;
                }
                if (FlagFinder >= 16384)
                {
                    ListFlags[14].SetActive(Checkbox4000, true);
                    FlagFinder -= 16384;
                }
                if (FlagFinder >= 8192)
                {
                    ListFlags[13].SetActive(Checkbox2000, true);
                    FlagFinder -= 8192;
                }
                if (FlagFinder >= 4096)
                {
                    ListFlags[12].SetActive(Checkbox1000, true);
                    FlagFinder -= 4096;
                }
                if (FlagFinder >= 2048)
                {
                    ListFlags[11].SetActive(Checkbox800, true);
                    FlagFinder -= 2048;
                }
                if (FlagFinder >= 1024)
                {
                    ListFlags[10].SetActive(Checkbox400, true);
                    FlagFinder -= 1024;
                }
                if (FlagFinder >= 512)
                {
                    ListFlags[9].SetActive(Checkbox200, true);
                    FlagFinder -= 512;
                }
                if (FlagFinder >= 256)
                {
                    ListFlags[8].SetActive(Checkbox100, true);
                    FlagFinder -= 256;
                }
                if (FlagFinder >= 128)
                {
                    ListFlags[7].SetActive(Checkbox80, true);
                    FlagFinder -= 128;
                }
                if (FlagFinder >= 64)
                {
                    ListFlags[6].SetActive(Checkbox40, true);
                    FlagFinder -= 64;
                }
                if (FlagFinder >= 32)
                {
                    ListFlags[5].SetActive(Checkbox20, true);
                    FlagFinder -= 32;
                }
                if (FlagFinder >= 16)
                {
                    ListFlags[4].SetActive(Checkbox10, true);
                    FlagFinder -= 16;
                }
                if (FlagFinder >= 8)
                {
                    ListFlags[3].SetActive(Checkbox8, true);
                    FlagFinder -= 8;
                }
                if (FlagFinder >= 4)
                {
                    ListFlags[2].SetActive(Checkbox4, true);
                    FlagFinder -= 4;
                }
                if (FlagFinder >= 2)
                {
                    ListFlags[1].SetActive(Checkbox2, true);
                    FlagFinder -= 2;
                }
                if (FlagFinder >= 1)
                {
                    ListFlags[0].SetActive(Checkbox1, true);
                    FlagFinder -= 1;
                }

                DisplayFlags();

                TextUsed = false;
            }
        }
    }
}
