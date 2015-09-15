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
        private bool Validation_Parameter = true;

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
                Validation_Parameter = false;
                return false;
            }
            foreach(char c in item.Text)
            {
                if (char.IsDigit(c))
                {

                    errorProvider1.SetError(item, "You must allow alphabet data");
                    Validation_Parameter = false;
                    return false;
                }

            }
            return true;
        }

        public bool validateNumric(TextBox item) 
        {
           
            if (String.IsNullOrEmpty(item.Text))
            {

                errorProvider1.SetError(item, "Mandatory filed");
                Validation_Parameter = false;
                return false;
            }
            foreach (char c in item.Text)
            {
                if (char.IsLetter(c))
                {

                    errorProvider1.SetError(item, "You must allow Numric data");
                    Validation_Parameter = false;
                    return false;
                }

            }


            return true;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            valdateText(firstName_text);
            valdateText(LastName_text);
            validateNumric(salary_txt);
            
            if (Validation_Parameter)
            {

                MessageBox.Show("the current date ", "Information");
               

            }
            Validation_Parameter = true;
            
        }
    }
}
