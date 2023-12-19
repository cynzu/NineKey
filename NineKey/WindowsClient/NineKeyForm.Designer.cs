namespace NineKey
{
    partial class NineKeyForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param _name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Click Begin to Generate Layouts");
            this.btnBegin = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblLayers = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlNumGens = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ddlPopulationSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ddlNumOfMutations = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.ddlPercentToReplace = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbRow3LayersSubtract = new System.Windows.Forms.RadioButton();
            this.rbRow3LayersAdd = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbRow2LayersSubtract = new System.Windows.Forms.RadioButton();
            this.rbRow2LayersAdd = new System.Windows.Forms.RadioButton();
            this.rbGroupRow1Layer = new System.Windows.Forms.Panel();
            this.rbRow1LayerSubtract = new System.Windows.Forms.RadioButton();
            this.rbRow1LayerAdd = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.ddlRow3Layers = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.ddlRow2Layers = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.ddlRowSameLayer = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbCol3LayersSubtract = new System.Windows.Forms.RadioButton();
            this.rbCol3LayersAdd = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbCol2LayersSubtract = new System.Windows.Forms.RadioButton();
            this.rbCol2LayersAdd = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbCol1LayerSubtract = new System.Windows.Forms.RadioButton();
            this.rbCol1LayerAdd = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ddlCol3Layers = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.ddlCol2Layers = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.ddlColSameLayer = new System.Windows.Forms.NumericUpDown();
            this.ckBxLetterLayerStatic = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ddlNumGens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPopulationSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlNumOfMutations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPercentToReplace)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.rbGroupRow1Layer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRow3Layers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRow2Layers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRowSameLayer)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCol3Layers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCol2Layers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlColSameLayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBegin
            // 
            this.btnBegin.AutoSize = true;
            this.btnBegin.Location = new System.Drawing.Point(262, 1062);
            this.btnBegin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(176, 51);
            this.btnBegin.TabIndex = 0;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(72, 718);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node0";
            treeNode1.Text = "Click Begin to Generate Layouts";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.treeView1.Size = new System.Drawing.Size(539, 332);
            this.treeView1.TabIndex = 2;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(684, 718);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(23, 20, 23, 20);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(733, 332);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // lblLayers
            // 
            this.lblLayers.AutoSize = true;
            this.lblLayers.Location = new System.Drawing.Point(684, 678);
            this.lblLayers.Name = "lblLayers";
            this.lblLayers.Size = new System.Drawing.Size(338, 32);
            this.lblLayers.TabIndex = 4;
            this.lblLayers.Text = "Layer 1 | Layer 2 | Layer 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 678);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Possible Layouts";
            // 
            // ddlNumGens
            // 
            this.ddlNumGens.Location = new System.Drawing.Point(346, 46);
            this.ddlNumGens.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlNumGens.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ddlNumGens.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ddlNumGens.Name = "ddlNumGens";
            this.ddlNumGens.Size = new System.Drawing.Size(117, 39);
            this.ddlNumGens.TabIndex = 6;
            this.ddlNumGens.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(315, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number of Generations ";
            // 
            // ddlPopulationSize
            // 
            this.ddlPopulationSize.Location = new System.Drawing.Point(346, 91);
            this.ddlPopulationSize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlPopulationSize.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ddlPopulationSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ddlPopulationSize.Name = "ddlPopulationSize";
            this.ddlPopulationSize.Size = new System.Drawing.Size(117, 39);
            this.ddlPopulationSize.TabIndex = 8;
            this.ddlPopulationSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Size of Population";
            // 
            // ddlNumOfMutations
            // 
            this.ddlNumOfMutations.Location = new System.Drawing.Point(346, 136);
            this.ddlNumOfMutations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlNumOfMutations.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ddlNumOfMutations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ddlNumOfMutations.Name = "ddlNumOfMutations";
            this.ddlNumOfMutations.Size = new System.Drawing.Size(117, 39);
            this.ddlNumOfMutations.TabIndex = 10;
            this.ddlNumOfMutations.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(276, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Number of Mutations";
            // 
            // ddlPercentToReplace
            // 
            this.ddlPercentToReplace.Location = new System.Drawing.Point(346, 183);
            this.ddlPercentToReplace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlPercentToReplace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ddlPercentToReplace.Name = "ddlPercentToReplace";
            this.ddlPercentToReplace.Size = new System.Drawing.Size(117, 39);
            this.ddlPercentToReplace.TabIndex = 12;
            this.ddlPercentToReplace.Value = new decimal(new int[] {
            33,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "Percent to Replace";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ddlPercentToReplace);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ddlNumOfMutations);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ddlPopulationSize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ddlNumGens);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(719, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(497, 258);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set Algorithm Parameters";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.rbGroupRow1Layer);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ddlRow3Layers);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ddlRow2Layers);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ddlRowSameLayer);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(11, 293);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(702, 355);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add or Subtract Points for NGrams on the Same Row";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbRow3LayersSubtract);
            this.panel2.Controls.Add(this.rbRow3LayersAdd);
            this.panel2.Location = new System.Drawing.Point(42, 271);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(468, 44);
            this.panel2.TabIndex = 16;
            // 
            // rbRow3LayersSubtract
            // 
            this.rbRow3LayersSubtract.AutoSize = true;
            this.rbRow3LayersSubtract.Location = new System.Drawing.Point(213, 5);
            this.rbRow3LayersSubtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRow3LayersSubtract.Name = "rbRow3LayersSubtract";
            this.rbRow3LayersSubtract.Size = new System.Drawing.Size(244, 36);
            this.rbRow3LayersSubtract.TabIndex = 13;
            this.rbRow3LayersSubtract.Text = "Subtract Points";
            this.rbRow3LayersSubtract.UseVisualStyleBackColor = true;
            // 
            // rbRow3LayersAdd
            // 
            this.rbRow3LayersAdd.AutoSize = true;
            this.rbRow3LayersAdd.Checked = true;
            this.rbRow3LayersAdd.Location = new System.Drawing.Point(9, 5);
            this.rbRow3LayersAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRow3LayersAdd.Name = "rbRow3LayersAdd";
            this.rbRow3LayersAdd.Size = new System.Drawing.Size(189, 36);
            this.rbRow3LayersAdd.TabIndex = 12;
            this.rbRow3LayersAdd.TabStop = true;
            this.rbRow3LayersAdd.Text = "Add Points";
            this.rbRow3LayersAdd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbRow2LayersSubtract);
            this.panel1.Controls.Add(this.rbRow2LayersAdd);
            this.panel1.Location = new System.Drawing.Point(42, 175);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(468, 44);
            this.panel1.TabIndex = 15;
            // 
            // rbRow2LayersSubtract
            // 
            this.rbRow2LayersSubtract.AutoSize = true;
            this.rbRow2LayersSubtract.Location = new System.Drawing.Point(213, 5);
            this.rbRow2LayersSubtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRow2LayersSubtract.Name = "rbRow2LayersSubtract";
            this.rbRow2LayersSubtract.Size = new System.Drawing.Size(244, 36);
            this.rbRow2LayersSubtract.TabIndex = 13;
            this.rbRow2LayersSubtract.Text = "Subtract Points";
            this.rbRow2LayersSubtract.UseVisualStyleBackColor = true;
            // 
            // rbRow2LayersAdd
            // 
            this.rbRow2LayersAdd.AutoSize = true;
            this.rbRow2LayersAdd.Checked = true;
            this.rbRow2LayersAdd.Location = new System.Drawing.Point(9, 5);
            this.rbRow2LayersAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRow2LayersAdd.Name = "rbRow2LayersAdd";
            this.rbRow2LayersAdd.Size = new System.Drawing.Size(189, 36);
            this.rbRow2LayersAdd.TabIndex = 12;
            this.rbRow2LayersAdd.TabStop = true;
            this.rbRow2LayersAdd.Text = "Add Points";
            this.rbRow2LayersAdd.UseVisualStyleBackColor = true;
            // 
            // rbGroupRow1Layer
            // 
            this.rbGroupRow1Layer.Controls.Add(this.rbRow1LayerSubtract);
            this.rbGroupRow1Layer.Controls.Add(this.rbRow1LayerAdd);
            this.rbGroupRow1Layer.Location = new System.Drawing.Point(39, 85);
            this.rbGroupRow1Layer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbGroupRow1Layer.Name = "rbGroupRow1Layer";
            this.rbGroupRow1Layer.Size = new System.Drawing.Size(468, 44);
            this.rbGroupRow1Layer.TabIndex = 14;
            // 
            // rbRow1LayerSubtract
            // 
            this.rbRow1LayerSubtract.AutoSize = true;
            this.rbRow1LayerSubtract.Location = new System.Drawing.Point(213, 5);
            this.rbRow1LayerSubtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRow1LayerSubtract.Name = "rbRow1LayerSubtract";
            this.rbRow1LayerSubtract.Size = new System.Drawing.Size(244, 36);
            this.rbRow1LayerSubtract.TabIndex = 13;
            this.rbRow1LayerSubtract.Text = "Subtract Points";
            this.rbRow1LayerSubtract.UseVisualStyleBackColor = true;
            // 
            // rbRow1LayerAdd
            // 
            this.rbRow1LayerAdd.AutoSize = true;
            this.rbRow1LayerAdd.Checked = true;
            this.rbRow1LayerAdd.Location = new System.Drawing.Point(9, 5);
            this.rbRow1LayerAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRow1LayerAdd.Name = "rbRow1LayerAdd";
            this.rbRow1LayerAdd.Size = new System.Drawing.Size(189, 36);
            this.rbRow1LayerAdd.TabIndex = 12;
            this.rbRow1LayerAdd.TabStop = true;
            this.rbRow1LayerAdd.Text = "Add Points";
            this.rbRow1LayerAdd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Same Row Across 3 Layers";
            // 
            // ddlRow3Layers
            // 
            this.ddlRow3Layers.Location = new System.Drawing.Point(512, 277);
            this.ddlRow3Layers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlRow3Layers.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ddlRow3Layers.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ddlRow3Layers.Name = "ddlRow3Layers";
            this.ddlRow3Layers.Size = new System.Drawing.Size(117, 39);
            this.ddlRow3Layers.TabIndex = 10;
            this.ddlRow3Layers.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(359, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "Same Row Across 2 Layers";
            // 
            // ddlRow2Layers
            // 
            this.ddlRow2Layers.Location = new System.Drawing.Point(512, 180);
            this.ddlRow2Layers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlRow2Layers.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ddlRow2Layers.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ddlRow2Layers.Name = "ddlRow2Layers";
            this.ddlRow2Layers.Size = new System.Drawing.Size(117, 39);
            this.ddlRow2Layers.TabIndex = 8;
            this.ddlRow2Layers.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(372, 32);
            this.label9.TabIndex = 7;
            this.label9.Text = "Same Row and Same Layer ";
            // 
            // ddlRowSameLayer
            // 
            this.ddlRowSameLayer.Location = new System.Drawing.Point(512, 90);
            this.ddlRowSameLayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlRowSameLayer.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ddlRowSameLayer.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ddlRowSameLayer.Name = "ddlRowSameLayer";
            this.ddlRowSameLayer.Size = new System.Drawing.Size(117, 39);
            this.ddlRowSameLayer.TabIndex = 6;
            this.ddlRowSameLayer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.ddlCol3Layers);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.ddlCol2Layers);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.ddlColSameLayer);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(719, 293);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(755, 355);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add or Subtract Points for NGrams in the Same Column";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbCol3LayersSubtract);
            this.panel3.Controls.Add(this.rbCol3LayersAdd);
            this.panel3.Location = new System.Drawing.Point(42, 271);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(468, 44);
            this.panel3.TabIndex = 16;
            // 
            // rbCol3LayersSubtract
            // 
            this.rbCol3LayersSubtract.AutoSize = true;
            this.rbCol3LayersSubtract.Location = new System.Drawing.Point(213, 5);
            this.rbCol3LayersSubtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCol3LayersSubtract.Name = "rbCol3LayersSubtract";
            this.rbCol3LayersSubtract.Size = new System.Drawing.Size(244, 36);
            this.rbCol3LayersSubtract.TabIndex = 13;
            this.rbCol3LayersSubtract.Text = "Subtract Points";
            this.rbCol3LayersSubtract.UseVisualStyleBackColor = true;
            // 
            // rbCol3LayersAdd
            // 
            this.rbCol3LayersAdd.AutoSize = true;
            this.rbCol3LayersAdd.Checked = true;
            this.rbCol3LayersAdd.Location = new System.Drawing.Point(9, 5);
            this.rbCol3LayersAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCol3LayersAdd.Name = "rbCol3LayersAdd";
            this.rbCol3LayersAdd.Size = new System.Drawing.Size(189, 36);
            this.rbCol3LayersAdd.TabIndex = 12;
            this.rbCol3LayersAdd.TabStop = true;
            this.rbCol3LayersAdd.Text = "Add Points";
            this.rbCol3LayersAdd.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbCol2LayersSubtract);
            this.panel4.Controls.Add(this.rbCol2LayersAdd);
            this.panel4.Location = new System.Drawing.Point(42, 175);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(468, 44);
            this.panel4.TabIndex = 15;
            // 
            // rbCol2LayersSubtract
            // 
            this.rbCol2LayersSubtract.AutoSize = true;
            this.rbCol2LayersSubtract.Location = new System.Drawing.Point(213, 5);
            this.rbCol2LayersSubtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCol2LayersSubtract.Name = "rbCol2LayersSubtract";
            this.rbCol2LayersSubtract.Size = new System.Drawing.Size(244, 36);
            this.rbCol2LayersSubtract.TabIndex = 13;
            this.rbCol2LayersSubtract.Text = "Subtract Points";
            this.rbCol2LayersSubtract.UseVisualStyleBackColor = true;
            // 
            // rbCol2LayersAdd
            // 
            this.rbCol2LayersAdd.AutoSize = true;
            this.rbCol2LayersAdd.Checked = true;
            this.rbCol2LayersAdd.Location = new System.Drawing.Point(9, 5);
            this.rbCol2LayersAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCol2LayersAdd.Name = "rbCol2LayersAdd";
            this.rbCol2LayersAdd.Size = new System.Drawing.Size(189, 36);
            this.rbCol2LayersAdd.TabIndex = 12;
            this.rbCol2LayersAdd.TabStop = true;
            this.rbCol2LayersAdd.Text = "Add Points";
            this.rbCol2LayersAdd.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rbCol1LayerSubtract);
            this.panel5.Controls.Add(this.rbCol1LayerAdd);
            this.panel5.Location = new System.Drawing.Point(39, 85);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(468, 44);
            this.panel5.TabIndex = 14;
            // 
            // rbCol1LayerSubtract
            // 
            this.rbCol1LayerSubtract.AutoSize = true;
            this.rbCol1LayerSubtract.Location = new System.Drawing.Point(213, 5);
            this.rbCol1LayerSubtract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCol1LayerSubtract.Name = "rbCol1LayerSubtract";
            this.rbCol1LayerSubtract.Size = new System.Drawing.Size(244, 36);
            this.rbCol1LayerSubtract.TabIndex = 13;
            this.rbCol1LayerSubtract.Text = "Subtract Points";
            this.rbCol1LayerSubtract.UseVisualStyleBackColor = true;
            // 
            // rbCol1LayerAdd
            // 
            this.rbCol1LayerAdd.AutoSize = true;
            this.rbCol1LayerAdd.Checked = true;
            this.rbCol1LayerAdd.Location = new System.Drawing.Point(9, 5);
            this.rbCol1LayerAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbCol1LayerAdd.Name = "rbCol1LayerAdd";
            this.rbCol1LayerAdd.Size = new System.Drawing.Size(189, 36);
            this.rbCol1LayerAdd.TabIndex = 12;
            this.rbCol1LayerAdd.TabStop = true;
            this.rbCol1LayerAdd.Text = "Add Points";
            this.rbCol1LayerAdd.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(401, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Same Column Across 3 Layers";
            // 
            // ddlCol3Layers
            // 
            this.ddlCol3Layers.Location = new System.Drawing.Point(512, 277);
            this.ddlCol3Layers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlCol3Layers.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.ddlCol3Layers.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ddlCol3Layers.Name = "ddlCol3Layers";
            this.ddlCol3Layers.Size = new System.Drawing.Size(117, 39);
            this.ddlCol3Layers.TabIndex = 10;
            this.ddlCol3Layers.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(401, 32);
            this.label10.TabIndex = 9;
            this.label10.Text = "Same Column Across 2 Layers";
            // 
            // ddlCol2Layers
            // 
            this.ddlCol2Layers.Location = new System.Drawing.Point(512, 180);
            this.ddlCol2Layers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlCol2Layers.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ddlCol2Layers.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ddlCol2Layers.Name = "ddlCol2Layers";
            this.ddlCol2Layers.Size = new System.Drawing.Size(117, 39);
            this.ddlCol2Layers.TabIndex = 8;
            this.ddlCol2Layers.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(414, 32);
            this.label11.TabIndex = 7;
            this.label11.Text = "Same Column and Same Layer ";
            // 
            // ddlColSameLayer
            // 
            this.ddlColSameLayer.Location = new System.Drawing.Point(512, 90);
            this.ddlColSameLayer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ddlColSameLayer.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.ddlColSameLayer.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ddlColSameLayer.Name = "ddlColSameLayer";
            this.ddlColSameLayer.Size = new System.Drawing.Size(117, 39);
            this.ddlColSameLayer.TabIndex = 6;
            this.ddlColSameLayer.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // ckBxLetterLayerStatic
            // 
            this.ckBxLetterLayerStatic.AutoSize = true;
            this.ckBxLetterLayerStatic.Location = new System.Drawing.Point(34, 242);
            this.ckBxLetterLayerStatic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ckBxLetterLayerStatic.Name = "ckBxLetterLayerStatic";
            this.ckBxLetterLayerStatic.Size = new System.Drawing.Size(525, 36);
            this.ckBxLetterLayerStatic.TabIndex = 17;
            this.ckBxLetterLayerStatic.Text = "Keep Letters on Layers By Frequency";
            this.ckBxLetterLayerStatic.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(43, 147);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(587, 50);
            this.linkLabel1.TabIndex = 18;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/cynzu/NineKey";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(43, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(660, 54);
            this.label12.TabIndex = 19;
            this.label12.Text = "for detailed information please visit:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(40, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(478, 54);
            this.label13.TabIndex = 20;
            this.label13.Text = "This is a work in progress,";
            // 
            // NineKeyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 1133);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.ckBxLetterLayerStatic);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLayers);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnBegin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NineKeyForm";
            this.Text = "NineKey";
            ((System.ComponentModel.ISupportInitialize)(this.ddlNumGens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPopulationSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlNumOfMutations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlPercentToReplace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.rbGroupRow1Layer.ResumeLayout(false);
            this.rbGroupRow1Layer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRow3Layers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRow2Layers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlRowSameLayer)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCol3Layers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlCol2Layers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ddlColSameLayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBegin;
        private TreeView treeView1;
        private RichTextBox richTextBox1;
        private Label lblLayers;
        private Label label1;
        private NumericUpDown ddlNumGens;
        private Label label2;
        private NumericUpDown ddlPopulationSize;
        private Label label3;
        private NumericUpDown ddlNumOfMutations;
        private Label label4;
        private NumericUpDown ddlPercentToReplace;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label7;
        private NumericUpDown ddlRow3Layers;
        private Label label8;
        private NumericUpDown ddlRow2Layers;
        private Label label9;
        private NumericUpDown ddlRowSameLayer;
        private RadioButton rbRow1LayerSubtract;
        private RadioButton rbRow1LayerAdd;
        private Panel rbGroupRow1Layer;
        private Panel panel1;
        private RadioButton rbRow2LayersSubtract;
        private RadioButton rbRow2LayersAdd;
        private Panel panel2;
        private RadioButton rbRow3LayersSubtract;
        private RadioButton rbRow3LayersAdd;
        private GroupBox groupBox3;
        private Panel panel3;
        private RadioButton rbCol3LayersSubtract;
        private RadioButton rbCol3LayersAdd;
        private Panel panel4;
        private RadioButton rbCol2LayersSubtract;
        private RadioButton rbCol2LayersAdd;
        private Panel panel5;
        private RadioButton rbCol1LayerSubtract;
        private RadioButton rbCol1LayerAdd;
        private Label label6;
        private NumericUpDown ddlCol3Layers;
        private Label label10;
        private NumericUpDown ddlCol2Layers;
        private Label label11;
        private NumericUpDown ddlColSameLayer;
        private CheckBox ckBxLetterLayerStatic;
        private LinkLabel linkLabel1;
        private Label label12;
        private Label label13;
    }
}
