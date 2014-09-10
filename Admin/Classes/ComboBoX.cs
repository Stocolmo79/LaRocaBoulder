using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Classes
{
    class ComboBoX
    {
        private readonly string text;
        private readonly int value;

        public string Text
        {
            get { return text; }
        }
        public int Value
        {
            get
            {
                return value;
            }
        }

        public ComboBoX(string text, int value)
        {
            this.text = text;
            this.value = value;
        }
    }
}
