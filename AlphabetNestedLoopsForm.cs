using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tolulope Adebayo
 * Created on: 09-04-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Numbers Nested Loops
 * This program...
*/
namespace AlphabetNestedLoopsToluA
{
    public partial class frmAlphabetNestedLoops : Form
    {
        public frmAlphabetNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // identify the Counters
            int FirstCounter;
            int SecondCounter;
            String NestedCodeSecondCharacter;
            String NestedCodeFirstCharacter;
            // Clear Objects From the list box
            this.lstAlphabetNestedLoops.Items.Clear();
            // Loop through numbers from 97 to 123
            for (FirstCounter = 65; FirstCounter <= 90; FirstCounter++)
            {
                NestedCodeFirstCharacter = char.ConvertFromUtf32(FirstCounter);
                // For each of the numbers above, loop through again writing beside it the second numbers from 97 to 123
                for ( SecondCounter = 97; SecondCounter <= 122; SecondCounter++)
                {
                    NestedCodeSecondCharacter = char.ConvertFromUtf32(SecondCounter);
                    this.lstAlphabetNestedLoops.Items.Add(NestedCodeFirstCharacter + "-> " + NestedCodeSecondCharacter);
                }
            }


        }
    }
}
