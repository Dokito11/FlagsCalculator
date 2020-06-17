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
        private int id;
        private bool active;
        private string flagString;

        public int Id { get => id; set => id = value; }
        public bool Active { get => active; set => active = value; }
        public string FlagString { get => flagString; set => flagString = value; }

        public Flag()
        {
            id = -1;
            active = false;
            flagString = "N/A";
        }

        public Flag(int Id, bool Active, string FlagString)
        {
            id = Id;
            active = Active;
            flagString = FlagString;
        }

        public void SetActive(CheckBox flagCheckbox, bool state)
        {
            if (state)
            {
                this.Active = true;
                flagCheckbox.Checked = true;
                return;
            }
            this.Active = false;

            flagCheckbox.Checked = false;
        }
    }
}
