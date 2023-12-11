using System.Text;
using NineKey.Facade;

namespace NineKey
{
    public partial class NineKeyForm : Form, IGenerationObserver
    {
        public NineKeyForm() 
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            richTextBox1.Clear();
            IGenerationObservable producer = Factory.Producer;
            producer.AddGenerationObserver(this);
            producer.FindTheBestLayout();

        } // end of btnBegin_Click

        void IGenerationObserver.Observe(IGeneration g)
        {
            TreeNode tn = treeView1.Nodes.Add
                ("Generation: " + (g.Ordinal+1) + " Top Score: " + g.TopScore + "\t");

            foreach (INineKeyLayout nkl in g.TopScoringLayouts)
            {
                tn.Nodes.Add(nkl.ToString() + "\n");
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                if (!treeView1.SelectedNode.Text.StartsWith("Gen"))
                {
                    StringBuilder sb = new StringBuilder();
                    String tab = " ";
                    String separator = " | ";

                    sb.Append("\n");
                    sb.Append(tab);
                    sb.Append(treeView1.SelectedNode.Text[0]);
                    sb.Append(treeView1.SelectedNode.Text[1]);
                    sb.Append(treeView1.SelectedNode.Text[2]);
                    sb.Append(separator);

                    sb.Append(treeView1.SelectedNode.Text[9]);
                    sb.Append(treeView1.SelectedNode.Text[10]);
                    sb.Append(treeView1.SelectedNode.Text[11]);
                    sb.Append(separator);

                    sb.Append(treeView1.SelectedNode.Text[18]);
                    sb.Append(treeView1.SelectedNode.Text[19]);
                    sb.Append(treeView1.SelectedNode.Text[20]);
                    sb.Append(separator);

                    // -----
                    sb.Append("\n");
                    sb.Append(tab);
                    sb.Append(treeView1.SelectedNode.Text[3]);
                    sb.Append(treeView1.SelectedNode.Text[4]);
                    sb.Append(treeView1.SelectedNode.Text[5]);
                    sb.Append(separator);

                    sb.Append(treeView1.SelectedNode.Text[12]);
                    sb.Append(treeView1.SelectedNode.Text[13]);
                    sb.Append(treeView1.SelectedNode.Text[14]);
                    sb.Append(separator);

                    sb.Append(treeView1.SelectedNode.Text[21]);
                    sb.Append(treeView1.SelectedNode.Text[22]);
                    sb.Append(treeView1.SelectedNode.Text[23]);
                    sb.Append(separator);

                    // -----
                    sb.Append("\n");
                    sb.Append(tab);

                    sb.Append(treeView1.SelectedNode.Text[6]);
                    sb.Append(treeView1.SelectedNode.Text[7]);
                    sb.Append(treeView1.SelectedNode.Text[8]);
                    sb.Append(separator);
                    
                    sb.Append(treeView1.SelectedNode.Text[15]);
                    sb.Append(treeView1.SelectedNode.Text[16]);
                    sb.Append(treeView1.SelectedNode.Text[17]);
                    sb.Append(separator);

                    sb.Append(treeView1.SelectedNode.Text[24]);
                    sb.Append(treeView1.SelectedNode.Text[25]);
                    sb.Append(treeView1.SelectedNode.Text[26]);
                    sb.Append(separator);

                    richTextBox1.Text = sb.ToString();

                }
            }
        } // end of treeView1_AfterSelect

    } // end of class NineKeyForm
} // end of namespace