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
        }

        int FlagFinder = 0;
        int FlagNum = 0;
        bool TextUsed = false;
        bool CheckUsed = false;

        private void DisableAll()
        {
            Checkbox1.Checked = false;
            Checkbox2.Checked = false;
            Checkbox4.Checked = false;
            Checkbox8.Checked = false;
            Checkbox10.Checked = false;
            Checkbox20.Checked = false;
            Checkbox40.Checked = false;
            Checkbox80.Checked = false;
            Checkbox100.Checked = false;
            Checkbox200.Checked = false;
            Checkbox400.Checked = false;
            Checkbox800.Checked = false;
            Checkbox1000.Checked = false;
            Checkbox2000.Checked = false;
            Checkbox4000.Checked = false;
            Checkbox8000.Checked = false;
            Checkbox10000.Checked = false;
            Checkbox20000.Checked = false;
            Checkbox40000.Checked = false;
            Checkbox80000.Checked = false;
            Checkbox100000.Checked = false;
            Checkbox200000.Checked = false;
            Checkbox400000.Checked = false;
            Checkbox800000.Checked = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (CheckUsed)
            {
                return;
            }
            TextUsed = true;
            if (TextboxFlag.Text == "")
            {
                DisableAll();
                return;
            }
            FlagFinder = FlagNum = Convert.ToInt32(TextboxFlag.Text);
            DisableAll();

            if (FlagFinder > 16777215)
            {
                MessageBox.Show("Number is too high");
            }
            else
            {
                if (FlagFinder >= 8388608)
                {
                    Checkbox800000.Checked = true;
                    FlagFinder -= 8388608;
                }
                if (FlagFinder >= 4194304)
                    {
                    Checkbox400000.Checked = true;
                    FlagFinder -= 4194304;
                }
                if (FlagFinder >= 2097152)
                {
                    Checkbox200000.Checked = true;
                    FlagFinder -= 2097152;
                }
                if (FlagFinder >= 1048576)
                {
                    Checkbox100000.Checked = true;
                    FlagFinder -= 1048576;
                }
                if (FlagFinder >= 524288)
                {
                    Checkbox80000.Checked = true;
                    FlagFinder -= 524288;
                }
                if (FlagFinder >= 262144)
                {
                    Checkbox40000.Checked = true;
                    FlagFinder -= 262144;
                }
                if (FlagFinder >= 131072)
                {
                    Checkbox20000.Checked = true;
                    FlagFinder -= 131072;
                }
                if (FlagFinder >= 65536)
                {
                    Checkbox10000.Checked = true;
                    FlagFinder -= 65536;
                }
                if (FlagFinder >= 32768)
                {
                    Checkbox8000.Checked = true;
                    FlagFinder -= 32768;
                }
                if (FlagFinder >= 16384)
                {
                    Checkbox4000.Checked = true;
                    FlagFinder -= 16384;
                }
                if (FlagFinder >= 8192)
                {
                    Checkbox2000.Checked = true;
                    FlagFinder -= 8192;
                }
                if (FlagFinder >= 4096)
                {
                    Checkbox1000.Checked = true;
                    FlagFinder -= 4096;
                }
                if (FlagFinder >= 2048)
                {
                    Checkbox800.Checked = true;
                    FlagFinder -= 2048;
                }
                if (FlagFinder >= 1024)
                {
                    Checkbox400.Checked = true;
                    FlagFinder -= 1024;
                }
                if (FlagFinder >= 512)
                {
                    Checkbox200.Checked = true;
                    FlagFinder -= 512;
                }
                if (FlagFinder >= 256)
                {
                    Checkbox100.Checked = true;
                    FlagFinder -= 256;
                }
                if (FlagFinder >= 128)
                {
                    Checkbox80.Checked = true;
                    FlagFinder -= 128;
                }
                if (FlagFinder >= 64)
                {
                    Checkbox40.Checked = true;
                    FlagFinder -= 64;
                }
                if (FlagFinder >= 32)
                {
                    Checkbox20.Checked = true;
                    FlagFinder -= 32;
                }
                if (FlagFinder >= 16)
                {
                    Checkbox10.Checked = true;
                    FlagFinder -= 16;
                }
                if (FlagFinder >= 8)
                {
                    Checkbox8.Checked = true;
                    FlagFinder -= 8;
                }
                if (FlagFinder >= 4)
                {
                    Checkbox4.Checked = true;
                    FlagFinder -= 4;
                }
                if (FlagFinder >= 2)
                {
                    Checkbox2.Checked = true;
                    FlagFinder -= 2;
                }
                if (FlagFinder >= 1)
                {
                    Checkbox1.Checked = true;
                    FlagFinder -= 1;
                }
                TextUsed = false;
            }
        }

        private void Checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox1.Checked)
            {
                FlagNum += 1;
            }
            else
            {
                FlagNum -= 1;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox2_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox2.Checked)
            {
                FlagNum += 2;
            }
            else
            {
                FlagNum -= 2;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox4_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox4.Checked)
            {
                FlagNum += 4;
            }
            else
            {
                FlagNum -= 4;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox8_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox8.Checked)
            {
                FlagNum += 8;
            }
            else
            {
                FlagNum -= 8;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox10_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox10.Checked)
            {
                FlagNum += 16;
            }
            else
            {
                FlagNum -= 16;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox20_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox20.Checked)
            {
                FlagNum += 32;
            }
            else
            {
                FlagNum -= 32;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox40_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox40.Checked)
            {
                FlagNum += 64;
            }
            else
            {
                FlagNum -= 64;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox80_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox80.Checked)
            {
                FlagNum += 128;
            }
            else
            {
                FlagNum -= 128;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox100_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox100.Checked)
            {
                FlagNum += 256;
            }
            else
            {
                FlagNum -= 256;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox200_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox200.Checked)
            {
                FlagNum += 512;
            }
            else
            {
                FlagNum -= 512;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox400_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox400.Checked)
            {
                FlagNum += 1024;
            }
            else
            {
                FlagNum -= 1024;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox800_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox800.Checked)
            {
                FlagNum += 2048;
            }
            else
            {
                FlagNum -= 2048;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox1000_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox1000.Checked)
            {
                FlagNum += 4096;
            }
            else
            {
                FlagNum -= 4096;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox2000_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox2000.Checked)
            {
                FlagNum += 8192;
            }
            else
            {
                FlagNum -= 8192;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox4000_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox4000.Checked)
            {
                FlagNum += 16384;
            }
            else
            {
                FlagNum -= 16384;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox8000_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox8000.Checked)
            {
                FlagNum += 32768;
            }
            else
            {
                FlagNum -= 32768;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox10000_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox10000.Checked)
            {
                FlagNum += 65536;
            }
            else
            {
                FlagNum -= 65536;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox20000_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox20000.Checked)
            {
                FlagNum += 131072;
            }
            else
            {
                FlagNum -= 131072;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox40000_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox40000.Checked)
            {
                FlagNum += 262144;
            }
            else
            {
                FlagNum -= 262144;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox80000_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox80000.Checked)
            {
                FlagNum += 524288;
            }
            else
            {
                FlagNum -= 524288;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox100000_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox100000.Checked)
            {
                FlagNum += 1048576;
            }
            else
            {
                FlagNum -= 1048576;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox200000_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox200000.Checked)
            {
                FlagNum += 2097152;
            }
            else
            {
                FlagNum -= 2097152;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox400000_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox400000.Checked)
            {
                FlagNum += 4194304;
            }
            else
            {
                FlagNum -= 4194304;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }

        private void Checkbox800000_CheckedChanged(object sender, EventArgs e)
        {
            if (TextUsed)
            {
                return;
            }
            CheckUsed = true;
            if (Checkbox800000.Checked)
            {
                FlagNum += 8388608;
            }
            else
            {
                FlagNum -= 8388608;
            }
            TextboxFlag.Text = Convert.ToString(FlagNum);
            CheckUsed = false;
        }
    }
}
