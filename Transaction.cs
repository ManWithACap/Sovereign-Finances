using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SovereignFinances
{
    internal class Transaction
    {
        private string name;
        private string description;
        private string type;
        private int value;
        private DateTime time;

        public Transaction()
        {
            
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public Label Label
        {
            get
            {
                Label lbl = new Label();
                lbl.Text = $"{name}, {description}, {type}, {value}, {time}";

                return lbl;
            }
        }
    }
}
