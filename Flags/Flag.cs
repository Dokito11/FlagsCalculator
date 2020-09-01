using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flags
{
    public class Flag
    {
        private bool active;
        private string flagString;
        CheckBox flagCheckbox;

        public bool Active { get => active; set => active = value; }
        public string FlagString { get => flagString; set => flagString = value; }
        public CheckBox FlagCheckbox { get => flagCheckbox; set => flagCheckbox = value; }

        public Flag()
        {
            active = false;
            flagString = "N/A";
            flagCheckbox = null;
        }

        public Flag(bool Active, string FlagString, CheckBox FlagCheckbox)
        {
            active = Active;
            flagString = FlagString;
            flagCheckbox = FlagCheckbox;
        }

        public void SetActive(bool state)
        {
            this.Active = state;
            this.FlagCheckbox.Checked = state;
        }
    }
}
