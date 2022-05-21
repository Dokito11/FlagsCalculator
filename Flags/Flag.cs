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
        private int position;
        private UInt32 value;
        private static int flagPosition = 0;
        private static UInt32 flagNumValue = 1;

        public bool Active { get => active; set => active = value; }
        public string FlagString { get => flagString; set => flagString = value; }
        public CheckBox FlagCheckbox { get => flagCheckbox; set => flagCheckbox = value; }
        public static int FlagPosition { get => flagPosition++; }
        public int Position { get => position; set => position = value; }
        public uint Value { get => value; set => this.value = value; }

        public static UInt32 FlagNumValue()
        {
            UInt32 oldval = flagNumValue;
            flagNumValue *= 2;
            return oldval;
        }

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
            position = FlagPosition;
            value = FlagNumValue();
        }

        public void SetActive(bool state)
        {
            this.Active = state;
            this.FlagCheckbox.Checked = state;
        }
    }
}
