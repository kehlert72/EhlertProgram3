using System;
using System.Windows.Forms;

/*  ID
 *      Gardening Guide, Kaleb Ehlert, 1/28/18
 *  Purpose
 *      The purpose of the program is to take the choice of which trees and flower the user likes and output it to the according preference bar.
 *  Form Controls
 *      Submission: lblDirection: States the directions for the program, lblFlowersComboBox: Label for the flower combo box, lblTreeListBox: Label for the tree listbox,
 *      cboFlowerChoice: The combobox for flowers where only one choice is allowed, lstTreeChoices: The listbox for trees where multiple choices are allowed,
 *      lblFlowerOutput: Label for flower preference output,    lblTreeOutput: Label for tree preferences output,   txtFlowerOuput: The flower output textfield,
 *      txtTreeOutput: The tree output textfield where multiple preferences are accepted.
 *  Code & Logic
 *      The tree preferences and flower preference is needed for input from the user.
 *      The processing is taking the tree preferences options and the flower preference options.
 *      The output is the preferences for the different tree and the preference for the different flowers.
 */

namespace EhlertProgram3
{
    public partial class Gardening_Guide : Form
    {
        // The constructor for the form
        public Gardening_Guide()
        {
            InitializeComponent();
        }

        // Processes the options selected for the tree listbox
        private void lstTreeChoices_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result = "";

            foreach (string activity in lstTreeChoices.SelectedItems)
            {
                result += activity + " ";
            }

            this.txtTreeOutput.Text = result;
        }

        // Processes the option selected for the flower combobox
        private void cboFlowerChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtFlowerOuput.Text = cboFlowerChoice.Text;        
        }
    }
}
