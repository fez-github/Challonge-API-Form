using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Collections.Specialized;

namespace APIFormTake2
{
    public partial class URLForm : Form
    {
        HttpUtility http = new HttpUtility();
        static string result;
        public URLForm()
        {
            InitializeComponent();
        }

        private void lbl_URL_Click(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_APICall_Click(object sender, EventArgs e)
        {
            if(txt_APIKey.TextLength == 0)
            {
                MessageBox.Show("No API Key was entered.  Please enter an API Key.");
            }
            else if (txt_URL.TextLength == 0)
            {
                MessageBox.Show("No URL was entered.  Please enter a URL.");
            }
            else if (txt_URL.TextLength == 0 && txt_APIKey.TextLength == 0)
            {
                MessageBox.Show("No values were entered.  Please fill out the form.");
            }
            else
            {
                RunCall(txt_URL.Text, txt_APIKey.Text);
            }
        }
        static async void RunCall(string URL, string Key)
        {
            UriBuilder builder = new UriBuilder(URL);
            Dictionary<string, string> queryParams = new Dictionary<string, string>();
            queryParams.Add("include_participants", "1");
            queryParams.Add("include_matches", "1");
            queryParams.Add("api_key", Key);
            builder = URIParamsAdd(builder, queryParams);
            result = await GetWebAPIAsync(builder);
            System.IO.File.WriteAllText("C:\\Users\\Mark\\Downloads\\jsonTest.json", result);
            System.IO.File.WriteAllText("C:\\Users\\Mark\\Downloads\\AbsoluteURI.txt", builder.Uri.AbsoluteUri);
        }
        /// <summary>
        /// Adds query parameters to a URI.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="dict"></param>
        /// <returns></returns>
        public static UriBuilder URIParamsAdd(UriBuilder builder, Dictionary<string, string> dict)
        {
            NameValueCollection query = HttpUtility.ParseQueryString(builder.Query);
            
            foreach (KeyValuePair<string, string> entry in dict)
            {
                query[entry.Key] = query[entry.Key] + entry.Value;
            }

            builder.Query = query.ToString();
            return builder;
        }
        public static async Task<string> GetWebAPIAsync(UriBuilder builder)
        {
            HttpClient client = new HttpClient();
            
                client.BaseAddress = new Uri(builder.Uri.AbsoluteUri);
                
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));

                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                    if (response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("Success");
                        return response.Content.ReadAsStringAsync().Result;
                    }
                    else
                    {
                        Console.WriteLine(response.StatusCode);
                        return response.StatusCode.ToString();
                    }
        }

    }
}
