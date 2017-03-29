// Colin Phelps
// Program 2
// Due: 6/11/ 2015
// CIS 200-10

// Program 2
// MainForm.cs
// Shows form that allows users to add addresses and letters 
// and creates a report of all the objects created
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
    public partial class MainForm : Form
    {
        // Precondition: None
        // Postcondition: The Main Form in initialized
        public MainForm()
        {
            InitializeComponent();

            Address a1 = new Address("John Smith", "123 Any St.", "Apt. 45",
              "Louisville", "KY", 40202); // Test Address 1
            Address a2 = new Address("Jane Doe", "987 Main St.", "",
                "Beverly Hills", "CA", 90210); // Test Address 2
            Address a3 = new Address("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901); // Test Address 3
            Address a4 = new Address("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101); // Test Address 4
            Address a5 = new Address("John Doe", "111 Market St.", "",
                "Jeffersonville", "IN", 47130); // Test Address 5
            Address a6 = new Address("Jane Smith", "55 Hollywood Blvd.", "Apt. 9",
                "Los Angeles", "CA", 90212); // Test Address 6
            Address a7 = new Address("Captain Robert Crunch", "21 Cereal Rd.", "Room 987",
                "Bethesda", "MD", 20810); // Test Address 7
            Address a8 = new Address("Vlad Dracula", "6543 Vampire Way", "Apt. 1",
                "Bloodsucker City", "TN", 37210); // Test Address 8

            addressList.Add(a1);// Populate list
            addressList.Add(a2);
            addressList.Add(a3);
            addressList.Add(a4);
            addressList.Add(a5);
            addressList.Add(a6);
            addressList.Add(a7);
            addressList.Add(a8);

            Letter letter1 = new Letter(a1, a2, 3.95M); // Letter test object
            Letter letter2 = new Letter(a3, a4, 4.25M); // Letter test object

            parcels.Add(letter1);// Populate list
            parcels.Add(letter2);
        }


        List<Parcel> parcels = new List<Parcel>(); // field to hold list of parcels
        List<Address> addressList = new List<Address>(); // field to hold list of addresses
        
        // Precondition: The Insert-Address menu button was clicked.
        // Postcondition: A dialog box is displayed propmting the user
        //                to fill in all the neccessary data to create
        //                an address object. If the user submits, a new
        //                address is added to the address list.
        private void addressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm(); // the dialog box form
            DialogResult result; // result from dialog
            string name; // variable to hold name
            string address1; // variable to hold address line 1
            string address2; // variable to hold address line 2
            string city; // variable to hold city
            string state; // variable to hold state
            int zip; // variable to hold zip

            result = addressForm.ShowDialog(); // show modal dialog box, waits for OK/Cancel

            if(result == DialogResult.OK) // Only add new address when user chose OK
            {
                // gives variables values from dialog box
                name = addressForm.AddressName;
                address1 = addressForm.AddressLine1;
                address2 = addressForm.AddressLine2;
                city = addressForm.AddressCity;
                state = addressForm.AddressState.ToString();
                zip = int.Parse(addressForm.AddressZip);

                Address myAddress = new Address(name, address1, address2, city, state, zip); // new address created from data from dialog box
                addressList.Add(myAddress); // adds new address to address list
            }
        }
        
        // Precondition: The Insert-Letter menu item was clicked.
        // Postcondition: A dialog box is displayed, prompting the user
        //                to select an origin address, a destination address,
        //                and a cost. If the user submits a new letter object
        //                is created and added to the parcels list.
        private void letterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LetterForm letterForm = new LetterForm(addressList); // The dialog box form
            DialogResult result; // result from dialog box
            Address orAdr; // variable to hold origin address
            Address destAdr; // variable to hold destination address
            decimal cost; // variable to hold the cost

            result = letterForm.ShowDialog(); // shows modal dialog box, waits for OK/Cancel

            if (result == DialogResult.OK) // Only add if user chose OK
            {
                // gives variables values from dialog box
                orAdr = addressList[letterForm.OrAddressIndex];
                destAdr = addressList[letterForm.DestAddressIndex];
                cost = decimal.Parse(letterForm.FixedCost);

                Letter myLetter = new Letter(orAdr, destAdr, cost); // creates new letter object
                parcels.Add(myLetter); // adds new letter to the parcel list
            }

        }

        // Precondition: The File-Exit button was clicked
        // Postcondition: The application closes
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Precondition: The File-About button was clicked
        // Postcondition: Information about the application is displayed
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportTextBox.Clear(); // text box cleared

            reportTextBox.AppendText(string.Format("By: Colin Phelps{0}CIS 200-10{0}Program 2{0}Due: 6/11/15",System.Environment.NewLine));
        }

        // Precondition: The Report-List Addresses button was clicked
        // Postcondition: All of the created addresses are displayed in
        //                a text box.
        private void listAddressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportTextBox.Clear(); // clears the text box

            reportTextBox.AppendText(string.Format("{0}{1}{1}","Addresses",System.Environment.NewLine)); // header

            // array that steps through the address list and displays them
            foreach (Address a in addressList)
            {
                reportTextBox.AppendText(string.Format("{0}{1}{1}",a,System.Environment.NewLine));
            }
        }

        // Precondition: The Report-List Parcels button was clicked
        // Postcondition: All of the created parcels and the total cost is displayed in the text box.
        private void listParcelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reportTextBox.Clear(); // clears the text box

            reportTextBox.AppendText(string.Format("{0}{1}{1}", "Parcels", System.Environment.NewLine)); // header

            decimal totalCost = 0; // variable to hold the total cost

            foreach (Parcel p in parcels) // loop to step through the parcel list and diplay each item
            {
                reportTextBox.AppendText(string.Format("{0}{1}{1}{1}", p, System.Environment.NewLine));

                totalCost += p.CalcCost(); // adds each parcel's cost 
            }

            reportTextBox.AppendText(string.Format("Total Cost: {0}", totalCost.ToString("c"))); // displays the total cost at the end of the report

        }
    }
}
