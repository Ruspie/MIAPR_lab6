using System;
using System.Drawing;
using System.Drawing.Text;
using HierarchicalGrouper;

namespace TestForm
{
    public static class Drawer
    {
        private const int IdLinePosX1 = 12;
        private const int IdLinePosX2 = 16;

        private static int _heightInterval;
        private static bool _isColored;
        private static readonly Random Random = new Random((int) DateTime.Now.Ticks);

        public static void DrawGraph(Graphics graphics, HierarchicalTree hierarchicalTree, int width, int height,
            bool isColored)
        {
            _isColored = isColored;
            DrawTree(graphics, hierarchicalTree, width, height);
        }

        private static void DrawTree(Graphics graphics, HierarchicalTree hierarchicalTree, int width, int height)
        {
            _heightInterval = (height - 25) / hierarchicalTree.GetTreeNode(hierarchicalTree.GetCountNodes() - 1).Value;

            DrawNode(graphics, hierarchicalTree.GetTreeNode(hierarchicalTree.GetCountNodes() - 1), width / 2, height);
        }

        private static void DrawNode(Graphics graphics, TreeNode treeNode, int width, int height)
        {
            if (treeNode != null) {
                var b = SystemBrushes.InfoText;
                SolidBrush brush;
                Pen pen;
                if (_isColored) {
                    var color = Color.FromArgb((Random.Next(255) + width) % 255, (Random.Next(255) + width) % 255,
                        (Random.Next(255) + width) % 255);
                    Console.WriteLine(color.ToString());
                    brush = new SolidBrush(color);
                    pen = new Pen(color);
                }
                else {
                    brush = new SolidBrush(Color.Black);
                    pen = new Pen(Color.Black);
                }

                if (treeNode.FirstNode != null && treeNode.SecondNode != null) {
                    graphics.FillEllipse(brush,
                        new Rectangle(width - 5, height - treeNode.Value * _heightInterval, 10, 10));
                    graphics.DrawString(treeNode.Name, new Font(new FontFamily(GenericFontFamilies.Serif), 10), b,
                        width - 5, height - treeNode.Value * _heightInterval + 10);
                    graphics.DrawString(treeNode.Value.ToString(),
                        new Font(new FontFamily(GenericFontFamilies.Serif), 8), b, 0,
                        height - treeNode.Value * _heightInterval);
                    graphics.DrawLine(pen, IdLinePosX1, height - treeNode.Value * _heightInterval + 6, IdLinePosX2,
                        height - treeNode.Value * _heightInterval + 6);

                    var widthInterval = 20;
                    if (treeNode.FirstNode.FirstNode != null || treeNode.SecondNode.FirstNode != null)
                        widthInterval = 50;

                    graphics.DrawLine(pen, width - widthInterval, height - treeNode.Value * _heightInterval + 5,
                        width + widthInterval, height - treeNode.Value * _heightInterval + 5);
                    graphics.DrawLine(pen, width + widthInterval, height - treeNode.Value * _heightInterval + 5,
                        width + widthInterval, height - treeNode.SecondNode.Value * _heightInterval + 5);
                    graphics.DrawLine(pen, width - widthInterval, height - treeNode.Value * _heightInterval + 5,
                        width - widthInterval, height - treeNode.FirstNode.Value * _heightInterval + 5);

                    brush.Dispose();
                    pen.Dispose();

                    DrawNode(graphics, treeNode.FirstNode, width - widthInterval, height);
                    DrawNode(graphics, treeNode.SecondNode, width + widthInterval, height);
                }
                else {
                    graphics.FillEllipse(brush, new Rectangle(width - 5, height - treeNode.Value - 5, 10, 10));
                    graphics.DrawString(treeNode.Name, new Font(new FontFamily(GenericFontFamilies.Serif), 8), b,
                        width - 15, height - treeNode.Value * 20 - 20);
                    brush.Dispose();
                    pen.Dispose();
                }
                // print node
            }
        }
    }
}