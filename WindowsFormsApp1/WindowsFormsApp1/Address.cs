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
        private AutoCompleteStringCollection autoCompleteOrigin;
        private AutoCompleteStringCollection autoCompleteDest;

        public Address()
        {
            autoCompleteOrigin = new AutoCompleteStringCollection();
            autoCompleteDest = new AutoCompleteStringCollection();
            
        }

        public Address(FrmCalculator frmCalculator) : this()
        {
            this.frmCalculator = frmCalculator;
            GetAddresses();
        }

        public AutoCompleteStringCollection AutoCompleteOrigin
        {
            get => autoCompleteOrigin;
            set => autoCompleteOrigin = value;
        }

        public AutoCompleteStringCollection AutoCompleteDest
        {
            get => autoCompleteDest;
            set => autoCompleteDest = value;
        }

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
    }
}
