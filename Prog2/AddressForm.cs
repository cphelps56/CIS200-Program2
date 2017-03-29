// Program 2
// AddressForm.cs
// Form is displayed as modal dialog box
// performs validation on controls
// and provides properties to create an object in the main form
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
    public partial class AddressForm : Form
    {
        
        // Precondition: None
        // Postcondition: The Address Form GUI is initialized and the combo box selected index is set to a default
        public AddressForm()
        {
            InitializeComponent();
            stateComboBox.SelectedIndex = 1; // default state set
        }



        public string AddressName
        {
            // Precondition: None
            // Postcondition: Text in the nameTextBox is returned
            get { return nameTextBox.Text; }
            // Precondition: None
            // Postcondition: Text in nameTextBox is set to a specified value
            set { nameTextBox.Text = value; }
        }

        public string AddressLine1
        {
            // Precondition: None
            // Postcondition: Text in the address1TextBox is returned
            get { return address1TextBox.Text; }
            // Precondition: None
            // Postcondition: Text in address1TextBox is set to a specified value
            set { address1TextBox.Text = value; }
        }

        public string AddressLine2
        {
            // Precondition: None
            // Postcondition: Text in the address2TextBox is returned
            get { return address2TextBox.Text; }
            // Precondition: None
            // Postcondition: Text in address2TextBox is set to a specified value
            set {address2TextBox.Text = value;}
        }

        public string AddressCity
        {
            // Precondition: None
            // Postcondition: Text in the cityTextBox is returned
            get { return cityTextBox.Text; }
            // Precondition: None
            // Postcondition: Text in cityTextBox is set to a specified value
            set { cityTextBox.Text = value; }
        }

        public string AddressState
        {
            // Precondition: None
            // Postcondition: Text of the selected item from the combo box is returned
            get { return stateComboBox.SelectedItem.ToString(); }
        }

        public string AddressZip
        {
            // Precondition: None
            // Postcondition: Text in the zipTextBox is returned
            get { return zipTextBox.Text; }
            // Precondition: None
            // Postcondition: Text in zipTextBox is set to a specified value
            set { zipTextBox.Text = value; }
        }


        // Precondition: nameTextBox_Validating succeeded
        // Postcondition: Error message is cleared, focus is allowed to change
        private void nameTextBox_Validated(object sender, EventArgs e)
        {
            addressErrorProvider.SetError(nameTextBox, ""); // clears error message
        }

        // Precondition: Attempting to change focus from text box
        // Postcondition: If entered value is valid, focus will change,
        //                else focus will remain and error provider message set
        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                e.Cancel = true; // stops focus from changing

                addressErrorProvider.SetError(nameTextBox, "Don't leave the text box empty"); // sets error message
            }
        }

        // Precondition: address1TextBox_Validating succeeded
        // Postcondition: Error message is cleared, focus is allowed to change
        private void address1TextBox_Validated(object sender, EventArgs e)
        {
            addressErrorProvider.SetError(address1TextBox, ""); // clears error message
        }

        // Precondition: Attempting to change focus from text box
        // Postcondition: If entered value is valid, focus will change,
        //                else focus will remain and error provider message set
        private void address1TextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(address1TextBox.Text))
            {
                e.Cancel = true; // stops focus from changing

                addressErrorProvider.SetError(address1TextBox, "Don't leave the text box empty"); // sets error message
            }
        }

        // Precondition: cityTextBox_Validating succeeded
        // Postcondition: Error message is cleared, focus is allowed to change
        private void cityTextBox_Validated(object sender, EventArgs e)
        {
            addressErrorProvider.SetError(cityTextBox, ""); // clears error message
        }

        // Precondition: Attempting to change focus from text box
        // Postcondition: If entered value is valid, focus will change,
        //                else focus will remain and error provider message set
        private void cityTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                e.Cancel = true; // stops focus from changing

                addressErrorProvider.SetError(cityTextBox, "Don't leave the text box empty"); // sets error message
            }
        }

        // Precondition: zipTextBox_Validating succeeded
        // Postcondition: Error message is cleared, focus is allowed to change
        private void zipTextBox_Validated(object sender, EventArgs e)
        {
            addressErrorProvider.SetError(zipTextBox, ""); // clears error message
        }

        // Precondition: Attempting to change focus from text box
        // Postcondition: If entered value is valid, focus will change,
        //                else focus will remain and error provider message set
        private void zipTextBox_Validating(object sender, CancelEventArgs e)
        {
            int zip;
            if((!int.TryParse(zipTextBox.Text, out zip))&&(zip >= 0)&&(zip <= 99999))
            {
                e.Cancel = true; // stops focus from changing

                addressErrorProvider.SetError(zipTextBox, "Please enter an interger"); // sets error message
            }
            else
            { 
                if((zip < 0)||(zip > 99999))
                {
                    e.Cancel = true; // stops focus from changing

                    addressErrorProvider.SetError(zipTextBox, "Please enter an interger between 0 and 99999");
                }
            }
        }

        // Precondition: Ok button was clicked
        // Postcondition: If all controls on form validate, address form is dismissed with an OK result 
        private void okBtn_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        
        // Precondition: Cancel button was clicked
        // Postcondition: Address form is dismissed with a Cancel result.
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
