using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HierarchicalGrouper;

namespace TestForm
{
    public partial class Form : System.Windows.Forms.Form
    {
        private const int MinDistance = 1;
        private const int MaxDistance = 100;

        public Form()
        {
            InitializeComponent();
            CountObjectsNumericUpDown_ValueChanged(this, EventArgs.Empty);
        }

        private void GenerateDistanceButton_Click(object sender, EventArgs e)
        {
            try {
                int countObjects = (int) CountObjectsNumericUpDown.Value;
                Random random = new Random((int) DateTime.Now.Ticks);

                DistanceDataGridView.ColumnCount = countObjects;
                DistanceDataGridView.RowCount = countObjects;

                int columnWidth = (DistanceDataGridView.Width - DistanceDataGridView.RowHeadersWidth) / countObjects -
                                  1;

                for (int i = 0; i < countObjects; i++) {
                    if (columnWidth > 30)
                        DistanceDataGridView.Columns[i].Width = columnWidth;
                    else
                        DistanceDataGridView.Columns[i].Width = 30;
                }

                for (int i = 0; i < countObjects; i++) {
                    for (int j = 0; j < countObjects; j++) {
                        if (i == j) {
                            DistanceDataGridView[i, j].Value = 0;
                        }
                        else {
                            int value = random.Next(MinDistance, MaxDistance);
                            DistanceDataGridView[i, j].Value = value;
                            DistanceDataGridView[countObjects - i - 1, countObjects - j - 1].Value = value;
                        }
                    }
                }

            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void ClearDistanceDataGridView()
        {
            for (int i = 0; i < DistanceDataGridView.ColumnCount; i++) {
                for (int j = 0; j < DistanceDataGridView.RowCount; j++) {
                    DistanceDataGridView[i, j].Value = null;
                }
            }
        }

        private void CountObjectsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try {
                ClearDistanceDataGridView();

                int countObjects = (int) CountObjectsNumericUpDown.Value;

                DistanceDataGridView.ColumnCount = countObjects;
                DistanceDataGridView.RowCount = countObjects;

                int columnWidth = (DistanceDataGridView.Width - DistanceDataGridView.RowHeadersWidth) / countObjects -
                                  1;

                for (int i = 0; i < countObjects; i++) {
                    if (columnWidth > 30)
                        DistanceDataGridView.Columns[i].Width = columnWidth;
                    else
                        DistanceDataGridView.Columns[i].Width = 30;
                }

            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void DistanceDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (DistanceDataGridView[e.ColumnIndex, e.RowIndex].Value == null) return;
            if (e.ColumnIndex == e.RowIndex) {
                DistanceDataGridView[e.ColumnIndex, e.RowIndex].Value = 0;
            }
            else {
                int countObjects = DistanceDataGridView.ColumnCount;
                DistanceDataGridView[countObjects - e.ColumnIndex - 1, countObjects - e.RowIndex - 1].Value =
                    DistanceDataGridView[e.ColumnIndex, e.RowIndex].Value;
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[][] distances = new int[DistanceDataGridView.ColumnCount][];
            for (int i = 0; i < DistanceDataGridView.ColumnCount; i++) {
                distances[i] = new int[DistanceDataGridView.RowCount];
                for (int j = 0; j < DistanceDataGridView.RowCount; j++) {
                    distances[i][j] = int.Parse(DistanceDataGridView[i, j].Value.ToString());
                }
            }

            HierarchicalTree hierarchicalTree = new HierarchicalTree();
            hierarchicalTree.getHierarchucalTree(distances);
        }
    }
}
