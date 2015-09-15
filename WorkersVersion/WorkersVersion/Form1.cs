using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkersVersion
{
    public partial class Form1 : Form ,ILogic
    {
        Regex r = new Regex("^[a-zA-Z0-9]*$");

        public Form1()
        {
            InitializeComponent();
        }

        public void deleteFromDatabase()
        {
            throw new NotImplementedException();
        }

        public void updateDatabasedata()
        {
            throw new NotImplementedException();
        }

        public bool valdateText(TextBox item)
        {  
            if (String.IsNullOrEmpty(item.Text)){

                errorProvider1.SetError(item, "Mandatory filed");
                return false;
            }
            foreach(char c in item.Text)
            {
                if (char.IsDigit(c))
                {

                    errorProvider1.SetError(item, "You must allow alphabet data");
                    return false;
                }

            }
            return true;
        }

        public bool validateNumric(TextBox item) 
        {
            

            return true;
        }
    }
}
