using System;
using System.Activities.Statements;
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

                if (countObjects == 4) {
                    DistanceDataGridView[0, 0].Value = 0;
                    DistanceDataGridView[0, 1].Value = 3;
                    DistanceDataGridView[0, 2].Value = 2;
                    DistanceDataGridView[0, 3].Value = 1;

                    DistanceDataGridView[1, 0].Value = 3;
                    DistanceDataGridView[1, 1].Value = 0;
                    DistanceDataGridView[1, 2].Value = 5;
                    DistanceDataGridView[1, 3].Value = 2;

                    DistanceDataGridView[2, 0].Value = 2;
                    DistanceDataGridView[2, 1].Value = 5;
                    DistanceDataGridView[2, 2].Value = 0;
                    DistanceDataGridView[2, 3].Value = 3;

                    DistanceDataGridView[3, 0].Value = 1;
                    DistanceDataGridView[3, 1].Value = 2;
                    DistanceDataGridView[3, 2].Value = 3;
                    DistanceDataGridView[3, 3].Value = 0;
                    
                    return;
                }

                for (int i = 0; i < countObjects; i++) {
                    DistanceDataGridView.Columns[i].Width = columnWidth > 30 ? columnWidth : 30;
                }

                for (int i = 0; i < countObjects; i++) {
                    for (int j = 0; j < countObjects; j++) {
                        if (i == j)
                            DistanceDataGridView[i, j].Value = 0;
                        else {
                            int value = random.Next(MinDistance, MaxDistance);
                            DistanceDataGridView[i, j].Value = value;
                            DistanceDataGridView[j, i].Value = value;
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
            if (e.ColumnIndex == e.RowIndex)
                DistanceDataGridView[e.ColumnIndex, e.RowIndex].Value = 0;
            else
                DistanceDataGridView[e.RowIndex, e.ColumnIndex].Value =
                    DistanceDataGridView[e.ColumnIndex, e.RowIndex].Value;
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                double[][] distances = new double[DistanceDataGridView.ColumnCount][];
                for (int i = 0; i < DistanceDataGridView.ColumnCount; i++) {
                    distances[i] = new double[DistanceDataGridView.RowCount];
                    for (int j = 0; j < DistanceDataGridView.RowCount; j++)
                        distances[i][j] = double.Parse(DistanceDataGridView[i, j].Value.ToString());
                }

                HierarchicalTree hierarchicalTree = new HierarchicalTree();
                HierarchicalGrouper.HierarchicalGrouper grouper = new HierarchicalGrouper.HierarchicalGrouper();
                hierarchicalTree = grouper.GetHierarchucalTree(distances);
            }
            catch (FormatException) {
                MessageBox.Show(@"Incorret format data in distance table.");
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }

            

        }
    }
}
