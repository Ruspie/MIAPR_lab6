using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void GenerateDistanceButton_Click(object sender, EventArgs e)
        {
            try {
                int countObjects = (int) CountObjectsNumericUpDown.Value;
                DistanceDataGridView.ColumnCount = countObjects;
                DistanceDataGridView.RowCount = countObjects;

                int columnWidth = (DistanceDataGridView.Width - DistanceDataGridView.RowHeadersWidth) / countObjects - 1;

                for (int i = 0; i < countObjects; i++)
                {
                    if (columnWidth > 30)
                        DistanceDataGridView.Columns[i].Width = columnWidth;
                    else
                        DistanceDataGridView.Columns[i].Width = 30;
                }
            }
            catch (Exception) {
                
            }
        }
    }
}
