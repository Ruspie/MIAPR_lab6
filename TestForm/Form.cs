using System;
using System.Drawing;
using System.Windows.Forms;
using HierarchicalGrouper;
using TestForm.Properties;

namespace TestForm
{
    public partial class Form : System.Windows.Forms.Form
    {
        private const int MinDistance = 1;
        private const int MaxDistance = 10;
        private bool _isColored;

        public Form()
        {
            InitializeComponent();
            CountObjectsNumericUpDown_ValueChanged(this, EventArgs.Empty);
        }

        private void GenerateDistanceButton_Click(object sender, EventArgs e)
        {
            try {
                var countObjects = (int) CountObjectsNumericUpDown.Value;
                var random = new Random((int) DateTime.Now.Ticks);

                DistanceDataGridView.ColumnCount = countObjects;
                DistanceDataGridView.RowCount = countObjects;

                var columnWidth = (DistanceDataGridView.Width - DistanceDataGridView.RowHeadersWidth) / countObjects -
                                  1;

                for (var i = 0; i < countObjects; i++)
                    DistanceDataGridView.Columns[i].Width = columnWidth > 30 ? columnWidth : 30;

                for (var i = 0; i < countObjects; i++)
                for (var j = 0; j < countObjects; j++)
                    if (i == j) {
                        DistanceDataGridView[i, j].Value = 0;
                    }
                    else {
                        var value = random.Next(MinDistance, MaxDistance);
                        DistanceDataGridView[i, j].Value = value;
                        DistanceDataGridView[j, i].Value = value;
                    }
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void ClearDistanceDataGridView()
        {
            for (var i = 0; i < DistanceDataGridView.ColumnCount; i++)
            for (var j = 0; j < DistanceDataGridView.RowCount; j++) DistanceDataGridView[i, j].Value = null;
        }

        private void CountObjectsNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            try {
                ClearDistanceDataGridView();

                var countObjects = (int) CountObjectsNumericUpDown.Value;

                DistanceDataGridView.ColumnCount = countObjects;
                DistanceDataGridView.RowCount = countObjects;

                var columnWidth = (DistanceDataGridView.Width - DistanceDataGridView.RowHeadersWidth) / countObjects -
                                  1;

                for (var i = 0; i < countObjects; i++)
                    if (columnWidth > 30)
                        DistanceDataGridView.Columns[i].Width = columnWidth;
                    else
                        DistanceDataGridView.Columns[i].Width = 30;
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
                var distances = new int[DistanceDataGridView.ColumnCount][];
                for (var i = 0; i < DistanceDataGridView.ColumnCount; i++) {
                    distances[i] = new int[DistanceDataGridView.RowCount];
                    for (var j = 0; j < DistanceDataGridView.RowCount; j++)
                        distances[i][j] = int.Parse(DistanceDataGridView[i, j].Value.ToString());
                }

                var hierarchicalTree = new HierarchicalTree();
                var grouper = new HierarchicalGrouper.HierarchicalGrouper();
                hierarchicalTree = grouper.GetHierarchucalTree(distances);

                var bitmap = new Bitmap(GraphPictureBox.Width, GraphPictureBox.Height);
                var graphics = Graphics.FromImage(bitmap);
                Drawer.DrawGraph(graphics, hierarchicalTree, GraphPictureBox.Width, GraphPictureBox.Height, _isColored);
                GraphPictureBox.Image = bitmap;
            }
            catch (FormatException) {
                MessageBox.Show(@"Incorret format data in distance table.", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (NullReferenceException) {
                MessageBox.Show(@"Fill out the distance table.", @"Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearDistanceDataGridView();
            GraphPictureBox.Image = new Bitmap(GraphPictureBox.Width, GraphPictureBox.Height);
        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.Form_aboutProgramToolStripMenuItem_Click_About);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isColored = true;
            yesToolStripMenuItem.Checked = true;
            noToolStripMenuItem.Checked = false;
        }

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _isColored = false;
            yesToolStripMenuItem.Checked = false;
            noToolStripMenuItem.Checked = true;
        }
    }
}