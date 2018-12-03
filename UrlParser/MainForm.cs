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
            Program.ParseUrls(raw_urls);
        }

        private void UpdateOutput() {

            // Create a new DataTable.    
            DataTable urlsTable = new DataTable("Urls");
            DataColumn dtColumn;
            DataRow myDataRow;

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "protocol";
            dtColumn.Caption = "Protocol";
            dtColumn.ReadOnly = false;
            urlsTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "host";
            dtColumn.Caption = "Host";
            dtColumn.ReadOnly = false;
            urlsTable.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(String);
            dtColumn.ColumnName = "path";
            dtColumn.Caption = "Query";
            dtColumn.ReadOnly = false;
            urlsTable.Columns.Add(dtColumn);


            // Create a new DataSet  
            DataSet dtSet = new DataSet();

            // Add custTable to the DataSet.    
            dtSet.Tables.Add(urlsTable);

            // Add data rows to the custTable using NewRow method    
            // I add three customers with their addresses, names and ids   
            /*myDataRow = custTable.NewRow();
            myDataRow["id"] = 1001;
            myDataRow["Address"] = "43 Lanewood Road, cito, CA";
            myDataRow["Name"] = "George Bishop";
            custTable.Rows.Add(myDataRow);
            myDataRow = custTable.NewRow();
            myDataRow["id"] = 1002;
            myDataRow["name"] = "Rock joe";
            myDataRow["Address"] = " kind of Prussia, PA";
            custTable.Rows.Add(myDataRow);
            myDataRow = custTable.NewRow();
            myDataRow["id"] = 1003;
            myDataRow["Name"] = "Miranda";
            myDataRow["Address"] = "279 P. Avenue, Bridgetown, PA";
            custTable.Rows.Add(myDataRow);
            */
        }
    }
}
