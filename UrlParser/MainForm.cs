using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrlParser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void parseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void nowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEnumerable<string> raw_urls = Program.SplitToLines(txtInput.Text.ToString());
            List<ParsedUrl> url_list = Program.ParseUrls(raw_urls);
            UpdateOutput(url_list);
        }

        private HashSet<String> retrieveUniqueColumns(List<ParsedUrl> url_list) {
            HashSet<String> columns = new HashSet<string>();

            columns.Add("protocol");
            columns.Add("host");
            columns.Add("path");

            foreach (ParsedUrl url in url_list) {
                if(url.Params != null)
                foreach (string col in url.Params.AllKeys) {
                    columns.Add(col);
                }       
            }
            return columns;
        }


        private void UpdateOutput(List<ParsedUrl> url_list) {

            // Create a new DataTable.    
            DataTable urlsTable = new DataTable("Urls");
            DataColumn dtColumn;
            DataRow myDataRow;

            HashSet<string> columns = retrieveUniqueColumns(url_list);


            foreach (string column in columns) {
                dtColumn = new DataColumn();
                dtColumn.DataType = typeof(String);
                dtColumn.ColumnName = column;
                dtColumn.Caption = column;
                dtColumn.ReadOnly = false;
                urlsTable.Columns.Add(dtColumn);
            }

            // Create a new DataSet  
            DataSet dtSet = new DataSet();

            // Add custTable to the DataSet.    
            dtSet.Tables.Add(urlsTable);


            foreach(var item in url_list) {
                myDataRow = urlsTable.NewRow();
                myDataRow["protocol"] = item.Protocol;
                myDataRow["host"] = item.Host;
                myDataRow["path"] = item.Path;
                urlsTable.Rows.Add(myDataRow);
            }

            dataGridView1.DataSource = dtSet;
            dataGridView1.DataMember = "Urls";
        } // update output

    }
}
