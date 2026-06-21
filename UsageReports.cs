using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace Library_management_system
{
    public partial class UsageReports : Form
    {
        string connStr = "Server=localhost;Database=library_db;uid=root;pwd=;";
        string memberId = "M001";

        public UsageReports()
        {
            InitializeComponent();
        }

        private List<BooksReadData> GetBooksReadData()
        {
            var list = new List<BooksReadData>();

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();

                string query = @"SELECT DATE_FORMAT(issue_date, '%M') AS Month, COUNT(*) AS BooksRead
                                 FROM issued_books
                                 WHERE member_id = @memberId
                                 GROUP BY YEAR(issue_date), MONTH(issue_date), DATE_FORMAT(issue_date, '%M')
                                 ORDER BY YEAR(issue_date), MONTH(issue_date)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@memberId", memberId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            list.Add(new BooksReadData
                            {
                                Month = reader.GetString(0),
                                BooksRead = reader.GetInt32(1)
                            });
                        }
                    }
                }
            }

            return list;
        }

        private void UsageReports_Load(object sender, EventArgs e)
        {
            var reportViewer = new ReportViewer
            {
                Dock = DockStyle.Fill,
                ProcessingMode = ProcessingMode.Local
            };

            this.Controls.Add(reportViewer);

            reportViewer.LocalReport.ReportPath =
                Path.Combine(Application.StartupPath, "BooksReport.rdlc");

            reportViewer.LocalReport.DataSources.Clear();

            reportViewer.LocalReport.DataSources.Add(
                new ReportDataSource("BooksData", GetBooksReadData()));

            reportViewer.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class BooksReadData
    {
        public string Month { get; set; }
        public int BooksRead { get; set; }
    }
}
