// Program 2
// LetterForm.cs
// Form displayed as modal dialog box,
// performs validation on controls,
// and provides properties to create a letter object in the main form.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class LetterForm : Form
    {
        List<Address> adrList; // field to hold list of addresses

        // Precondition: None
        // Postcondition: The LetterForm GUI is initialized and both combo boxes are populated with the address list
        public LetterForm(List<Address> adList)
        {
            InitializeComponent();

            adrList = adList;
            foreach (Address ad in adrList) // loop that steps through address list and adds them to both combo boxes item list
            {
                originAddressComboBox.Items.Add(ad.Name);
                destinationAddressComboBox.Items.Add(ad.Name);
            }
        }

        
        public int OrAddressIndex
        {
            // Precondition: None
            // Postcondition: The selected index of the origin address combo box is returned
            get { return originAddressComboBox.SelectedIndex; }

        }

        public int DestAddressIndex
        {
            // Precondition: None
            // Postcondition: The selected index of the destination address combo box is returned
            get { return destinationAddressComboBox.SelectedIndex; }
            
        }

        public string FixedCost
        {
            // Precondition: None
            // Postcondition: Text in costTextBox is returned
            get { return costTextBox.Text; }
            // Precondition: None
            // Postcondition: Text in costTextBox is set to a specified value
            set { costTextBox.Text = value; }
        }

        // Precondition: The OK button on the form is clicked
        // Postcondition: If all the controls validate, the form is dismissed with the OK dialog result
        private void okBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        // Precondition: costTextBox_Validating succeeded
        // Postcondition: Error message is cleared, focus is allowed to change
        private void costTextBox_Validated(object sender, EventArgs e)
        {
            letterErrorProvider.SetError(costTextBox, ""); // gets rid of error message
        }

        // Precondition: Attempting to change focus from costTextBox
        // Postcondition: If entered value is a valid decimal, focus will change
        //                else focus will remain and error message will be set
        private void costTextBox_Validating(object sender, CancelEventArgs e)
        {
            decimal cost; // variable to hold cost

            if (!decimal.TryParse(costTextBox.Text, out cost))
            {
                e.Cancel = true;// stops focus from changing

                letterErrorProvider.SetError(costTextBox, "Enter a number!"); // sets error message

                costTextBox.SelectAll(); // selects all the text for easy deletion
            }
            else
            {
                if (cost <= 0)
                {
                    e.Cancel = true;// stops focus from changing

                    letterErrorProvider.SetError(costTextBox, "Enter a non-negative number!"); // sets error message

                    costTextBox.SelectAll(); // selects all the text for easy deletion
                }
            }
        }

        // Precondition: originAddressComboBox_Validating succeeded
        // Postcondition: Error message is cleared, focus is allowed to change
        private void originAddressComboBox_Validated(object sender, EventArgs e)
        {
            letterErrorProvider.SetError(originAddressComboBox, ""); // gets rid of error message
        }

        // Precondition: Attempting to change focus from originAddressComboBox
        // Postcondition: If entered value is a valid choice, focus will change
        //                else focus will remain and error message will be set
        private void originAddressComboBox_Validating(object sender, CancelEventArgs e)
        {
            if(originAddressComboBox.SelectedIndex == -1)
            {
                e.Cancel = true; // stops focus from changing

                letterErrorProvider.SetError(originAddressComboBox, "Select an address!");// sets error message
            }
            else
            {
                if (originAddressComboBox.SelectedIndex == destinationAddressComboBox.SelectedIndex)
                {
                    e.Cancel = true;// stops focus from changing

                    letterErrorProvider.SetError(originAddressComboBox,"Select an address that's different then the selected destination address");//sets error message
                }
            }
        }

        // Precondition: destinationAddressComboBox_Validating succeeded
        // Postcondition: Error message is cleared, focus is allowed to change
        private void destinationAddressComboBox_Validated(object sender, EventArgs e)
        {
            letterErrorProvider.SetError(destinationAddressComboBox,""); // gets rid of error message
        }

        // Precondition: Attempting to change focus from destinationAddressComboBox
        // Postcondition: If entered value is a valid choice, focus will change
        //                else focus will remain and error message will be set
        private void destinationAddressComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (destinationAddressComboBox.SelectedIndex == -1)
            {
                e.Cancel = true; // stops focus from changing

                letterErrorProvider.SetError(destinationAddressComboBox,"Select an address!");// set error message
            }
            else
            {
                if (destinationAddressComboBox.SelectedIndex == originAddressComboBox.SelectedIndex)
                {
                    e.Cancel = true; // stops focus from changing

                    letterErrorProvider.SetError(destinationAddressComboBox,"Select an address that's different then the selected origin address");// sets error message
                }
            }

        }
        
        // Precondition: user has clicked the cancel button
        // Postcondition: The form is dismissed with a cancel dialog result
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
