using NPI_interface.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPI_interface
{
    public partial class FormNewHost : Form
    {

        private string InputIPaddress;
        private Host NewHost;
        private Boolean isValidated = false;
        public Host host
        {
            get
            {
                return this.NewHost;
            }
        }

        public FormNewHost()
        {
            InitializeComponent();
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (isValidated)
            {
                InputIPaddress = textBox.Text;
                NewHost = new Host(InputIPaddress);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBox_Validating(object sender, CancelEventArgs e)
        {
            string InputIP = textBox.Text;

            int NoWithoutDots = InputIP.Replace(".", "").Length;
            string StrWithoutDots = InputIP.Replace(".", "");
            int NrDots = InputIP.Length - InputIP.Replace(".", "").Length;
            string[] numbers = InputIP.Split('.');

            bool ValidNumbers = true;

            foreach (var number in numbers)
            {
                if (number == "")
                {
                    ValidNumbers = false;
                    break;
                }
                else if (number.Count() > 3)
                {
                    ValidNumbers = false;
                    break;
                }
            }

            var isNumeric = int.TryParse(StrWithoutDots, out _);

            if (textBox.Text == "")
            {
                textBox.Focus();
                errorProvider.SetError(textBox, "This field cannot be empty!");
            }
            else if (!(NrDots == 3 && (NoWithoutDots >= 4 && NoWithoutDots <= 12) && isNumeric 
                && ValidNumbers))
            {
                
                textBox.Focus();
                errorProvider.SetError(textBox, "Invalid IP Address!");
            }
            else
            {
                errorProvider.SetError(textBox, null);
                isValidated = true;
            }
        }

    }
}
