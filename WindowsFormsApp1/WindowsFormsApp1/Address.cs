using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Address
    {
        private readonly FrmCalculator frmCalculator;
        private readonly String dataBaseFileName = "addresses.txt";
        private readonly char[] sep = {';'};
        // this is a object built into C# that hold txtbox dropdown suggestions
        private AutoCompleteStringCollection autoCompleteOrigin;
        private AutoCompleteStringCollection autoCompleteDest;

        public Address()
        {
            // assigning AutoCompleteStringCollection objects
            autoCompleteOrigin = new AutoCompleteStringCollection();
            autoCompleteDest = new AutoCompleteStringCollection();
            
        }

        public Address(FrmCalculator frmCalculator) : this()
        {
            // gettig fort object instance
            this.frmCalculator = frmCalculator;
            // getaddress for text file
            GetAddresses();
        }

        /*// setter and getter
        public AutoCompleteStringCollection AutoCompleteOrigin
        {
            get => autoCompleteOrigin;
            set => autoCompleteOrigin = value;
        }

        public AutoCompleteStringCollection AutoCompleteDest
        {
            get => autoCompleteDest;
            set => autoCompleteDest = value;
        }*/

        // get addresses from text file and assing then to the corresponding textboxs
        private void GetAddresses()
        {
            try
            {
                autoCompleteOrigin.Clear();
                autoCompleteDest.Clear();

                FileStream infile = new FileStream(dataBaseFileName, FileMode.Open);
                StreamReader myReader = new StreamReader(infile);
                string[] fields = new string[2];

                string line;
                while ((line = myReader.ReadLine()) != null)
                {
                    fields = line.Split(sep);
                    autoCompleteOrigin.Add(fields[0]);
                    autoCompleteDest.Add(fields[1]);
                    Console.WriteLine("Origin:" + fields[0]);
                    Console.WriteLine("Dest:" + fields[1]);
                }
                myReader.Close();
                infile.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found!\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            frmCalculator.TxtOriging.AutoCompleteCustomSource = autoCompleteOrigin;
            frmCalculator.TxtDest.AutoCompleteCustomSource = autoCompleteDest;
        }

        // add new addresses the text file and calls the GetAddresses() methods this refresh the textboxes auto completion suggestions
        public void AddNewAddressesSuggestions()
        {
            // open the file
            FileStream outfile = new FileStream(dataBaseFileName, FileMode.Append);
            StreamWriter writer = new StreamWriter(outfile);
            // write new addresses to the textfile
            writer.WriteLine(frmCalculator.TxtOriging.Text + sep[0] + frmCalculator.TxtDest.Text);
            // close the file
            writer.Close();
            outfile.Close();
            // call GetAddresses methods which refresh txtboxes auto completion suggestions, which will include the new addresses added above
            GetAddresses();
        }
    }
}
