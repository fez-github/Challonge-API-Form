using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APIFormTake2
{
    public partial class GenericForm : Form
    {
        public GenericForm()
        {
            InitializeComponent();
            addDefaultParameters();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void addDefaultParameters()
        {
            /* ***GET***
            dgv_Parameters.Rows.Add(new string[] { "state", "all" });
            dgv_Parameters.Rows.Add(new string[] { "type", "double_elimination" });
            dgv_Parameters.Rows.Add(new string[] { "created_after", "2018-08-01" });
            dgv_Parameters.Rows.Add(new string[] { "created_before", "2018-10-01" });
            dgv_Parameters.Rows.Add(new string[] { "subdomain", "" });
            */

            dgv_Parameters.Rows.Add(new string[] { "tournament[name]", "TestTournament" });
            dgv_Parameters.Rows.Add(new string[] { "tournament[tournament_type]", "double elimination" });
            dgv_Parameters.Rows.Add(new string[] { "tournament[url]", "FEZTestTourney" });
            dgv_Parameters.Rows.Add(new string[] { "tournament[description]", "This was generated from an API Call." });
        }
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

                /*
                string dictKey;
                if (String.IsNullOrEmpty(row.Cells[0].Value as String))
                {
                    dictKey = "invalid";
                }
                else
                {
                    dictKey = row.Cells[0].Value.ToString();
                }

                string dictValue;
                if (String.IsNullOrEmpty(row.Cells[1].Value?.ToString()))
                {
                    dictValue = "invalid";
                }
                else
                {
                    dictValue = row.Cells[1].Value.ToString();
                }
                dict.Add(dictKey, dictValue);
                */
            }
            return dict;
        }

        private void btn_CallAPI_Click(object sender, EventArgs e)
        {
            APICall call = new APICall();
            Dictionary<string, string> dict = converttoDictionary(dgv_Parameters);
            call.NewGetCall(txt_Name.Text, txt_APIKey.Text, cmb_Method.SelectedItem.ToString(), txt_Resource.Text, dict,txt_Body.Text);
        }
    }
}
