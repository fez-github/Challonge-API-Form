using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace APIFormTake2
{
    public partial class GenericForm : Form
    {
        public GenericForm()
        {
            InitializeComponent();
            //AddDefaultValues();
            cmb_Method.SelectedIndex = 0;
            AddCallNames();
        }
        /// <summary>
        /// Load any initial values.  This method was used often during testing to automatically fill out fields.
        /// </summary>
        private void AddDefaultValues()
        {
            //Add text to request body
            //txt_Body.Text = "{\"tournament\" : {\r\n \"name\" : \"APITesting\",\r\n \"url\" : \"FEZAPIBodyTesting\"\r\n}";
            //txt_Body.Text = "{\"participants\" : [\r\n{\"name\" : \"Player 1\", \"seed\" : \"1\"}," +
            //                                     "\r\n{\"name\" : \"Player 2\", \"seed\" : \"2\"}\r\n    ]\r\n}";

            /*
            //Base URL
            txt_BaseURL.Text = "https://api.challonge.com/v1";
            // Values are the defaults from Challonge's GET Tournament Index call.  https://api.challonge.com/v1/documents/tournaments/index
            dgv_Parameters.Rows.Add(new string[] { "state", "all" });
            dgv_Parameters.Rows.Add(new string[] { "type", "double elimination" });
            dgv_Parameters.Rows.Add(new string[] { "created_after", "2018-08-01" });
            dgv_Parameters.Rows.Add(new string[] { "created_before", "2018-10-01" });
            dgv_Parameters.Rows.Add(new string[] { "subdomain", "" });
            */
        }
        /// <summary>
        /// Gets all of the call names stored in the ChallongeCalls folder.  
        /// These names will be used for the user to select calls and make the process easier.
        /// </summary>
        void AddCallNames()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ChallongeCalls");
            string[] files = Directory.GetFiles(path);
            Array.Sort(files);
            foreach(string file in files)
            {
                cmb_CallFile.Items.Add(Path.GetFileName(file).Replace(".csv",""));
            }
        }
        /// <summary>
        /// Looks at the first 2 columns of all rows in a DataGridView and adds them into a string Dictionary.
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        private Dictionary<string, string> converttoDictionary(DataGridView dgv)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            string dictKey;
            string dictValue;

            foreach(DataGridViewRow row in dgv.Rows)
            {
                if (!String.IsNullOrEmpty(row.Cells[1].Value as String))
                {
                    dictKey = row.Cells[0].Value.ToString();
                    dictValue = row.Cells[1].Value.ToString();
                    dict.Add(dictKey, dictValue);
                }
            }
            return dict;
        }
        /// <summary>
        /// Once this button is clicked, the API Call procedure will start.
        /// Checks are performed to make sure necessary values have been inputted.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_CallAPI_Click(object sender, EventArgs e)
        {
            //Check for empty text boxes.
            if (txt_APIKey.TextLength == 0)
            {
                MessageBox.Show("No API Key was entered.  Please enter an API Key.");
                return;
            }
            else if(txt_Name.TextLength == 0)
            {
                MessageBox.Show("No name was entered.  Please enter your Challonge username.");
                return;
            }
            else if(String.IsNullOrEmpty(cmb_Method.SelectedItem as string))
            {
                MessageBox.Show("Please insert a value into the ComboBox.");
                return;
            }
            else if(txt_Resource.TextLength == 0)
            {
                MessageBox.Show("No resource was entered.  Please enter a URL resource.");
                return;
            }
            //Check if there are brackets in the resource box.  This means a value was not properly entered.
            if (txt_Resource.Text.Contains("{"))
            {
                MessageBox.Show("You must enter valid criteria in the Resource text box.  Please check for any words in brackets({}) and replace them with the correct value.");
                return;
            }

            APICall call = new APICall(txt_BaseURL.Text);
            Dictionary<string, string> dict = converttoDictionary(dgv_Parameters);
            txt_Status.Text =  call.NewCall(txt_Name.Text, txt_APIKey.Text, cmb_Method.SelectedItem.ToString(), txt_Resource.Text, dict,txt_Body.Text, txt_GETSave.Text);
        }


        private void btn_FolderCall_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            DialogResult result = folderDialog.ShowDialog();
            if(result == DialogResult.OK)
            {
                txt_GETSave.Text = folderDialog.SelectedPath;
            }
        }

        private void cmb_CallFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateAPIFields(cmb_CallFile.SelectedItem.ToString());
        }
        /// <summary>
        /// Adds call data to relevant fields, such as the base URL, resource name, and parameters.
        /// </summary>
        /// <param name="callName"></param>
        void UpdateAPIFields(string callName)
        {
            //NOTE: CSV file will contain sentences that hold commas in the individual cells.  I used Excel's Find & Replace to change all commas with semicolons.
            //This is cumbersome, but I have VBA to automate it.  Still feel like I'm slapping duct tape onto the problem, but it works.


            dgv_Parameters.Rows.Clear();
            txt_Body.Clear();

            string filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"ChallongeCalls",callName + ".csv");

            StreamReader fileData = GetCSVFile(filepath);

            //Read header line to skip it.
            fileData.ReadLine();

            while (!fileData.EndOfStream)
            {
                //Split row into fragments.
                string[] row = fileData.ReadLine().Split(',');
                if(row[2] != "")
                {
                    txt_BaseURL.Text = row[2];
                }
                if(row[3] != "")
                {
                    txt_Resource.Text = row[3];
                }
                if(row[4] != "")
                {
                    switch (row[4])
                    {
                        case "GET":
                            cmb_Method.SelectedItem = "GET";
                            break;
                        case "POST":
                            cmb_Method.SelectedItem = "POST";
                            break;
                        case "PUT":
                            cmb_Method.SelectedItem = "PUT";
                            break;
                        case "DELETE":
                            cmb_Method.SelectedItem = "DELETE";
                            break;

                    }
                }
                int index = dgv_Parameters.Rows.Add(new string[] { row[5] });
                dgv_Parameters.Rows[index].Cells[0].ToolTipText = row[6];

            }
            dgv_Parameters.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
        StreamReader GetCSVFile(string fileName)
        {
            StreamReader input = null;
            try
            {
                input = File.OpenText(fileName);

                return input;

            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {

            }
        }
    }
}
