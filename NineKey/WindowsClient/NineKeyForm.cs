using System.Text;
using System.Windows.Forms;
using NineKey.Facade;

namespace NineKey
{
    public partial class NineKeyForm : Form, IGenerationObserver
    {
        private Config _config = new Config();
        private int _prevOrdinal = -1;

        public NineKeyForm() 
        {
            InitializeComponent();
            SetWidgetDefaults();
        }

        private void SetWidgetDefaults()
        {

            ckBxLetterLayerStatic.Checked = _config.LettersOnLayersByFreq;
            ddlNumGens.Value = Config.DEFAULT_NUM_OF_GENERATIONS;
            ddlPopulationSize.Value = Config.DEFAULT_POPULATION_SIZE;
            ddlNumOfMutations.Value = Config.DEFAULT_NUM_OF_MUTATIONS;
            ddlPercentToReplace.Value = Config.DEFAULT_PERCENT_TO_REPLACE;
            ddlColSameLayer.Value = Config.DEFAULT_POINTS_COL_1_LAYER;
            ddlCol2Layers.Value = Config.DEFAULT_POINTS_COL_2_LAYERS;
            ddlCol3Layers.Value = Config.DEFAULT_POINTS_COL_3_LAYERS;
            rbRow1LayerAdd.Checked = _config.SameRowSameLayerAdd;
            rbRow2LayersAdd.Checked = _config.SameRow2LayersAdd;
            rbRow3LayersAdd.Checked = _config.SameRow3LayersAdd;

            rbCol1LayerAdd.Checked = _config.SameColSameLayerAdd;
            rbCol2LayersAdd.Checked = _config.SameCol2LayersAdd;
            rbCol3LayersAdd.Checked = _config.SameCol3LayersAdd;

            rbCol1LayerSubtract.Checked = !(_config.SameColSameLayerAdd);
            rbCol2LayersSubtract.Checked = !(_config.SameCol2LayersAdd);
            rbCol3LayersSubtract.Checked = !(_config.SameCol3LayersAdd);
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            treeView1.Nodes.Clear();
            richTextBox1.Clear();
            SetConfigValues();
            IGenerationObservable producer = Factory.Producer;
            producer.AcceptConfig(_config);
            producer.AddGenerationObserver(this);
            producer.FindTheBestLayout();
            Cursor.Current = Cursors.Default;

        } // end of btnBegin_Click

        private void SetConfigValues()
        {
            this._config.NumOfGenerations = (int)this.ddlNumGens.Value;
            this._config.PopulationSize = (int) this.ddlPopulationSize.Value;
            this._config.NumOfMutations = (int)this.ddlNumGens.Value;
            this._config.PercentToReplace = this.ddlPercentToReplace.Value / 100;

            this._config.SameRowSameLayerAdd = this.rbRow1LayerAdd.Checked;
            this._config.SameRow2LayersAdd = this.rbRow2LayersAdd.Checked;
            this._config.SameRow3LayersAdd = this.rbRow3LayersAdd.Checked;

            this._config.SameColSameLayerAdd = this.rbCol1LayerAdd.Checked;
            this._config.SameCol2LayersAdd = this.rbCol2LayersAdd.Checked;
            this._config.SameCol3LayersAdd = this.rbCol3LayersAdd.Checked;

            this._config.SameRowSameLayerPoints = (int)this.ddlRowSameLayer.Value;
            this._config.SameRow2LayersPoints = (int)this.ddlRow2Layers.Value;
            this._config.SameRow3LayersPoints = (int)this.ddlRow3Layers.Value;

            this._config.SameColSameLayerPoints = (int)this.ddlColSameLayer.Value;
            this._config.SameCol2LayersPoints = (int)this.ddlCol2Layers.Value;
            this._config.SameCol3LayersPoints = (int)this.ddlCol3Layers.Value;

            this._config.LettersOnLayersByFreq = this.ckBxLetterLayerStatic.Checked;
        } // end of SetConfigValues

        void IGenerationObserver.Observe(IGeneration g)
        {
            if (g.Ordinal == _prevOrdinal) { return; }
            else
            {
                _prevOrdinal = g.Ordinal;
                //TreeNode tn = treeView1.Nodes.Add
                //("Generation: " + (g.Ordinal + 1) + " Top Score: " + g.TopScore + "\t");

                List<int> scores = g.LayoutsByScore.Keys.ToList<int>();
                scores.Sort();
                foreach (int score in scores)
                {
                    TreeNode treeNode = treeView1.Nodes.Add
                        ("Generation: " + (g.Ordinal + 1) + " Score: " + score + "\t");
                    foreach (INineKeyLayout layout in g.LayoutsByScore[score])
                    {
                        treeNode.Nodes.Add(layout.ToString() + "\n");
                    }
                    treeNode.ExpandAll();
                }
            }
        } // end of IGenerationObserver.Observe

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
