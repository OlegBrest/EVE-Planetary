namespace EVE_Planetary
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.tabPrice = new System.Windows.Forms.TabPage();
            this.splitPrices = new System.Windows.Forms.SplitContainer();
            this.DGVPrices = new System.Windows.Forms.DataGridView();
            this.SaveBttn = new System.Windows.Forms.Button();
            this.ClearEmpty = new System.Windows.Forms.Button();
            this.UpdatePrices = new System.Windows.Forms.Button();
            this.tabWorks = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.TabControlFormulas = new System.Windows.Forms.TabControl();
            this.tabPageManuf = new System.Windows.Forms.TabPage();
            this.treeViewFormManuf = new System.Windows.Forms.TreeView();
            this.tabPagePlanet = new System.Windows.Forms.TabPage();
            this.treeViewFormPlanet = new System.Windows.Forms.TreeView();
            this.tabPageReact = new System.Windows.Forms.TabPage();
            this.treeViewFormReact = new System.Windows.Forms.TreeView();
            this.panelFormulas = new System.Windows.Forms.Panel();
            this.ButtonRemoveManuf = new System.Windows.Forms.Button();
            this.ButtonAddEditManuf = new System.Windows.Forms.Button();
            this.textBoxFormManufInputCount = new System.Windows.Forms.TextBox();
            this.textBoxFormManufOutCount = new System.Windows.Forms.TextBox();
            this.textBoxFormManufInputID = new System.Windows.Forms.TextBox();
            this.textBoxFormManufOutID = new System.Windows.Forms.TextBox();
            this.textBoxFormManufOutName = new System.Windows.Forms.TextBox();
            this.textBoxFormManufInputName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFormManufBPName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.tabCalc = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.TabCalcBuySell = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.DGVCalcBuySell = new System.Windows.Forms.DataGridView();
            this.BuyLabel = new System.Windows.Forms.Label();
            this.SellLabel = new System.Windows.Forms.Label();
            this.comboCalcBuy = new System.Windows.Forms.ComboBox();
            this.comboCalcSell = new System.Windows.Forms.ComboBox();
            this.CalcBuySellFinder = new System.Windows.Forms.Button();
            this.TabCalcManuf = new System.Windows.Forms.TabPage();
            this.TabCalcPlanet = new System.Windows.Forms.TabPage();
            this.TabCalcReact = new System.Windows.Forms.TabPage();
            this.ProgressBarPrice = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.TabControlMain.SuspendLayout();
            this.tabPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPrices)).BeginInit();
            this.splitPrices.Panel1.SuspendLayout();
            this.splitPrices.Panel2.SuspendLayout();
            this.splitPrices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPrices)).BeginInit();
            this.tabWorks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.TabControlFormulas.SuspendLayout();
            this.tabPageManuf.SuspendLayout();
            this.tabPagePlanet.SuspendLayout();
            this.tabPageReact.SuspendLayout();
            this.panelFormulas.SuspendLayout();
            this.tabCalc.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.TabCalcBuySell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCalcBuySell)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControlMain
            // 
            this.TabControlMain.Controls.Add(this.tabPrice);
            this.TabControlMain.Controls.Add(this.tabWorks);
            this.TabControlMain.Controls.Add(this.tabCalc);
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMain.Location = new System.Drawing.Point(0, 0);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(800, 450);
            this.TabControlMain.TabIndex = 0;
            // 
            // tabPrice
            // 
            this.tabPrice.Controls.Add(this.splitPrices);
            this.tabPrice.Location = new System.Drawing.Point(4, 22);
            this.tabPrice.Name = "tabPrice";
            this.tabPrice.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrice.Size = new System.Drawing.Size(792, 424);
            this.tabPrice.TabIndex = 0;
            this.tabPrice.Text = "Prices";
            this.tabPrice.UseVisualStyleBackColor = true;
            // 
            // splitPrices
            // 
            this.splitPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitPrices.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitPrices.Location = new System.Drawing.Point(3, 3);
            this.splitPrices.Name = "splitPrices";
            this.splitPrices.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitPrices.Panel1
            // 
            this.splitPrices.Panel1.Controls.Add(this.DGVPrices);
            // 
            // splitPrices.Panel2
            // 
            this.splitPrices.Panel2.Controls.Add(this.SaveBttn);
            this.splitPrices.Panel2.Controls.Add(this.ClearEmpty);
            this.splitPrices.Panel2.Controls.Add(this.button1);
            this.splitPrices.Panel2.Controls.Add(this.UpdatePrices);
            this.splitPrices.Size = new System.Drawing.Size(786, 418);
            this.splitPrices.SplitterDistance = 360;
            this.splitPrices.TabIndex = 1;
            // 
            // DGVPrices
            // 
            this.DGVPrices.AllowUserToAddRows = false;
            this.DGVPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPrices.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGVPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPrices.Location = new System.Drawing.Point(0, 0);
            this.DGVPrices.Name = "DGVPrices";
            this.DGVPrices.Size = new System.Drawing.Size(786, 360);
            this.DGVPrices.TabIndex = 0;
            // 
            // SaveBttn
            // 
            this.SaveBttn.BackColor = System.Drawing.Color.Transparent;
            this.SaveBttn.ForeColor = System.Drawing.Color.Black;
            this.SaveBttn.Location = new System.Drawing.Point(191, 7);
            this.SaveBttn.Name = "SaveBttn";
            this.SaveBttn.Size = new System.Drawing.Size(88, 31);
            this.SaveBttn.TabIndex = 0;
            this.SaveBttn.Text = "Save Prices";
            this.SaveBttn.UseVisualStyleBackColor = false;
            this.SaveBttn.Click += new System.EventHandler(this.SaveBttn_Click);
            // 
            // ClearEmpty
            // 
            this.ClearEmpty.BackColor = System.Drawing.Color.Transparent;
            this.ClearEmpty.ForeColor = System.Drawing.Color.Black;
            this.ClearEmpty.Location = new System.Drawing.Point(97, 7);
            this.ClearEmpty.Name = "ClearEmpty";
            this.ClearEmpty.Size = new System.Drawing.Size(88, 31);
            this.ClearEmpty.TabIndex = 0;
            this.ClearEmpty.Text = "Clear Empty";
            this.ClearEmpty.UseVisualStyleBackColor = false;
            this.ClearEmpty.Click += new System.EventHandler(this.ClearEmpty_Click);
            // 
            // UpdatePrices
            // 
            this.UpdatePrices.BackColor = System.Drawing.Color.Transparent;
            this.UpdatePrices.ForeColor = System.Drawing.Color.Black;
            this.UpdatePrices.Location = new System.Drawing.Point(3, 7);
            this.UpdatePrices.Name = "UpdatePrices";
            this.UpdatePrices.Size = new System.Drawing.Size(88, 31);
            this.UpdatePrices.TabIndex = 0;
            this.UpdatePrices.Text = "UpdatePrices";
            this.UpdatePrices.UseVisualStyleBackColor = false;
            this.UpdatePrices.Click += new System.EventHandler(this.UpdatePrices_Click);
            // 
            // tabWorks
            // 
            this.tabWorks.Controls.Add(this.splitContainer2);
            this.tabWorks.Location = new System.Drawing.Point(4, 22);
            this.tabWorks.Name = "tabWorks";
            this.tabWorks.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorks.Size = new System.Drawing.Size(792, 424);
            this.tabWorks.TabIndex = 2;
            this.tabWorks.Text = "Formulas";
            this.tabWorks.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer5);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Size = new System.Drawing.Size(786, 418);
            this.splitContainer2.SplitterDistance = 360;
            this.splitContainer2.TabIndex = 2;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.TabControlFormulas);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.panelFormulas);
            this.splitContainer5.Size = new System.Drawing.Size(786, 360);
            this.splitContainer5.SplitterDistance = 532;
            this.splitContainer5.TabIndex = 3;
            // 
            // TabControlFormulas
            // 
            this.TabControlFormulas.Controls.Add(this.tabPageManuf);
            this.TabControlFormulas.Controls.Add(this.tabPagePlanet);
            this.TabControlFormulas.Controls.Add(this.tabPageReact);
            this.TabControlFormulas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlFormulas.Location = new System.Drawing.Point(0, 0);
            this.TabControlFormulas.Name = "TabControlFormulas";
            this.TabControlFormulas.SelectedIndex = 0;
            this.TabControlFormulas.Size = new System.Drawing.Size(532, 360);
            this.TabControlFormulas.TabIndex = 0;
            // 
            // tabPageManuf
            // 
            this.tabPageManuf.Controls.Add(this.treeViewFormManuf);
            this.tabPageManuf.Location = new System.Drawing.Point(4, 22);
            this.tabPageManuf.Name = "tabPageManuf";
            this.tabPageManuf.Size = new System.Drawing.Size(524, 334);
            this.tabPageManuf.TabIndex = 0;
            this.tabPageManuf.Text = "Manufacturing";
            this.tabPageManuf.UseVisualStyleBackColor = true;
            // 
            // treeViewFormManuf
            // 
            this.treeViewFormManuf.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFormManuf.HotTracking = true;
            this.treeViewFormManuf.LabelEdit = true;
            this.treeViewFormManuf.Location = new System.Drawing.Point(0, 0);
            this.treeViewFormManuf.Name = "treeViewFormManuf";
            this.treeViewFormManuf.Size = new System.Drawing.Size(524, 334);
            this.treeViewFormManuf.TabIndex = 0;
            this.treeViewFormManuf.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeViewFormManuf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseClick);
            // 
            // tabPagePlanet
            // 
            this.tabPagePlanet.Controls.Add(this.treeViewFormPlanet);
            this.tabPagePlanet.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlanet.Name = "tabPagePlanet";
            this.tabPagePlanet.Size = new System.Drawing.Size(524, 334);
            this.tabPagePlanet.TabIndex = 1;
            this.tabPagePlanet.Text = "Planetology";
            this.tabPagePlanet.UseVisualStyleBackColor = true;
            // 
            // treeViewFormPlanet
            // 
            this.treeViewFormPlanet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFormPlanet.HotTracking = true;
            this.treeViewFormPlanet.LabelEdit = true;
            this.treeViewFormPlanet.Location = new System.Drawing.Point(0, 0);
            this.treeViewFormPlanet.Name = "treeViewFormPlanet";
            this.treeViewFormPlanet.Size = new System.Drawing.Size(524, 334);
            this.treeViewFormPlanet.TabIndex = 0;
            this.treeViewFormPlanet.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeViewFormPlanet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseClick);
            // 
            // tabPageReact
            // 
            this.tabPageReact.Controls.Add(this.treeViewFormReact);
            this.tabPageReact.Location = new System.Drawing.Point(4, 22);
            this.tabPageReact.Name = "tabPageReact";
            this.tabPageReact.Size = new System.Drawing.Size(524, 334);
            this.tabPageReact.TabIndex = 2;
            this.tabPageReact.Text = "Reaction";
            this.tabPageReact.UseVisualStyleBackColor = true;
            // 
            // treeViewFormReact
            // 
            this.treeViewFormReact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewFormReact.HotTracking = true;
            this.treeViewFormReact.LabelEdit = true;
            this.treeViewFormReact.Location = new System.Drawing.Point(0, 0);
            this.treeViewFormReact.Name = "treeViewFormReact";
            this.treeViewFormReact.Size = new System.Drawing.Size(524, 334);
            this.treeViewFormReact.TabIndex = 0;
            this.treeViewFormReact.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            this.treeViewFormReact.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseClick);
            // 
            // panelFormulas
            // 
            this.panelFormulas.Controls.Add(this.ButtonRemoveManuf);
            this.panelFormulas.Controls.Add(this.ButtonAddEditManuf);
            this.panelFormulas.Controls.Add(this.textBoxFormManufInputCount);
            this.panelFormulas.Controls.Add(this.textBoxFormManufOutCount);
            this.panelFormulas.Controls.Add(this.textBoxFormManufInputID);
            this.panelFormulas.Controls.Add(this.textBoxFormManufOutID);
            this.panelFormulas.Controls.Add(this.textBoxFormManufOutName);
            this.panelFormulas.Controls.Add(this.textBoxFormManufInputName);
            this.panelFormulas.Controls.Add(this.label7);
            this.panelFormulas.Controls.Add(this.textBoxFormManufBPName);
            this.panelFormulas.Controls.Add(this.label6);
            this.panelFormulas.Controls.Add(this.label5);
            this.panelFormulas.Controls.Add(this.label3);
            this.panelFormulas.Controls.Add(this.label4);
            this.panelFormulas.Controls.Add(this.label2);
            this.panelFormulas.Controls.Add(this.label1);
            this.panelFormulas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormulas.Location = new System.Drawing.Point(0, 0);
            this.panelFormulas.Name = "panelFormulas";
            this.panelFormulas.Size = new System.Drawing.Size(250, 360);
            this.panelFormulas.TabIndex = 0;
            // 
            // ButtonRemoveManuf
            // 
            this.ButtonRemoveManuf.BackColor = System.Drawing.Color.Transparent;
            this.ButtonRemoveManuf.ForeColor = System.Drawing.Color.Black;
            this.ButtonRemoveManuf.Location = new System.Drawing.Point(97, 242);
            this.ButtonRemoveManuf.Name = "ButtonRemoveManuf";
            this.ButtonRemoveManuf.Size = new System.Drawing.Size(88, 31);
            this.ButtonRemoveManuf.TabIndex = 0;
            this.ButtonRemoveManuf.Text = "Remove";
            this.ButtonRemoveManuf.UseVisualStyleBackColor = false;
            this.ButtonRemoveManuf.Click += new System.EventHandler(this.ButtonRemoveManuf_Click);
            // 
            // ButtonAddEditManuf
            // 
            this.ButtonAddEditManuf.BackColor = System.Drawing.Color.Transparent;
            this.ButtonAddEditManuf.ForeColor = System.Drawing.Color.Black;
            this.ButtonAddEditManuf.Location = new System.Drawing.Point(3, 242);
            this.ButtonAddEditManuf.Name = "ButtonAddEditManuf";
            this.ButtonAddEditManuf.Size = new System.Drawing.Size(88, 31);
            this.ButtonAddEditManuf.TabIndex = 0;
            this.ButtonAddEditManuf.Text = "Add/Edit";
            this.ButtonAddEditManuf.UseVisualStyleBackColor = false;
            this.ButtonAddEditManuf.Click += new System.EventHandler(this.ButtonAddEditManuf_Click);
            // 
            // textBoxFormManufInputCount
            // 
            this.textBoxFormManufInputCount.Location = new System.Drawing.Point(78, 205);
            this.textBoxFormManufInputCount.Name = "textBoxFormManufInputCount";
            this.textBoxFormManufInputCount.Size = new System.Drawing.Size(171, 20);
            this.textBoxFormManufInputCount.TabIndex = 1;
            // 
            // textBoxFormManufOutCount
            // 
            this.textBoxFormManufOutCount.Location = new System.Drawing.Point(78, 108);
            this.textBoxFormManufOutCount.Name = "textBoxFormManufOutCount";
            this.textBoxFormManufOutCount.Size = new System.Drawing.Size(171, 20);
            this.textBoxFormManufOutCount.TabIndex = 1;
            // 
            // textBoxFormManufInputID
            // 
            this.textBoxFormManufInputID.Location = new System.Drawing.Point(62, 179);
            this.textBoxFormManufInputID.Name = "textBoxFormManufInputID";
            this.textBoxFormManufInputID.Size = new System.Drawing.Size(187, 20);
            this.textBoxFormManufInputID.TabIndex = 1;
            this.textBoxFormManufInputID.Tag = "textBoxFormManufInputName";
            this.textBoxFormManufInputID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxID_KeyDown);
            // 
            // textBoxFormManufOutID
            // 
            this.textBoxFormManufOutID.Location = new System.Drawing.Point(64, 82);
            this.textBoxFormManufOutID.Name = "textBoxFormManufOutID";
            this.textBoxFormManufOutID.Size = new System.Drawing.Size(187, 20);
            this.textBoxFormManufOutID.TabIndex = 1;
            this.textBoxFormManufOutID.Tag = "textBoxFormManufOutName";
            this.textBoxFormManufOutID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxID_KeyDown);
            // 
            // textBoxFormManufOutName
            // 
            this.textBoxFormManufOutName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxFormManufOutName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFormManufOutName.Location = new System.Drawing.Point(2, 56);
            this.textBoxFormManufOutName.Name = "textBoxFormManufOutName";
            this.textBoxFormManufOutName.Size = new System.Drawing.Size(247, 20);
            this.textBoxFormManufOutName.TabIndex = 1;
            this.textBoxFormManufOutName.Tag = "textBoxFormManufOutID";
            this.textBoxFormManufOutName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseClick);
            this.textBoxFormManufOutName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // textBoxFormManufInputName
            // 
            this.textBoxFormManufInputName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxFormManufInputName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFormManufInputName.Location = new System.Drawing.Point(2, 153);
            this.textBoxFormManufInputName.Name = "textBoxFormManufInputName";
            this.textBoxFormManufInputName.Size = new System.Drawing.Size(247, 20);
            this.textBoxFormManufInputName.TabIndex = 1;
            this.textBoxFormManufInputName.Tag = "textBoxFormManufInputID";
            this.textBoxFormManufInputName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseClick);
            this.textBoxFormManufInputName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Input ID";
            // 
            // textBoxFormManufBPName
            // 
            this.textBoxFormManufBPName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxFormManufBPName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFormManufBPName.Location = new System.Drawing.Point(2, 17);
            this.textBoxFormManufBPName.Name = "textBoxFormManufBPName";
            this.textBoxFormManufBPName.Size = new System.Drawing.Size(247, 20);
            this.textBoxFormManufBPName.TabIndex = 1;
            this.textBoxFormManufBPName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Input count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Output ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Output count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Input Material";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BP Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(5, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 31);
            this.button2.TabIndex = 0;
            this.button2.Text = "Load Formulas";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabCalc
            // 
            this.tabCalc.Controls.Add(this.tabControl2);
            this.tabCalc.Location = new System.Drawing.Point(4, 22);
            this.tabCalc.Name = "tabCalc";
            this.tabCalc.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalc.Size = new System.Drawing.Size(792, 424);
            this.tabCalc.TabIndex = 1;
            this.tabCalc.Text = "Calculations";
            this.tabCalc.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.TabCalcBuySell);
            this.tabControl2.Controls.Add(this.TabCalcManuf);
            this.tabControl2.Controls.Add(this.TabCalcPlanet);
            this.tabControl2.Controls.Add(this.TabCalcReact);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(786, 418);
            this.tabControl2.TabIndex = 0;
            // 
            // TabCalcBuySell
            // 
            this.TabCalcBuySell.Controls.Add(this.splitContainer1);
            this.TabCalcBuySell.Location = new System.Drawing.Point(4, 22);
            this.TabCalcBuySell.Name = "TabCalcBuySell";
            this.TabCalcBuySell.Padding = new System.Windows.Forms.Padding(3);
            this.TabCalcBuySell.Size = new System.Drawing.Size(778, 392);
            this.TabCalcBuySell.TabIndex = 0;
            this.TabCalcBuySell.Text = "BuySell";
            this.TabCalcBuySell.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.DGVCalcBuySell);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.BuyLabel);
            this.splitContainer1.Panel2.Controls.Add(this.SellLabel);
            this.splitContainer1.Panel2.Controls.Add(this.comboCalcBuy);
            this.splitContainer1.Panel2.Controls.Add(this.comboCalcSell);
            this.splitContainer1.Panel2.Controls.Add(this.CalcBuySellFinder);
            this.splitContainer1.Size = new System.Drawing.Size(772, 386);
            this.splitContainer1.SplitterDistance = 339;
            this.splitContainer1.TabIndex = 2;
            // 
            // DGVCalcBuySell
            // 
            this.DGVCalcBuySell.AllowUserToAddRows = false;
            this.DGVCalcBuySell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCalcBuySell.DefaultCellStyle = dataGridViewCellStyle6;
            this.DGVCalcBuySell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCalcBuySell.Location = new System.Drawing.Point(0, 0);
            this.DGVCalcBuySell.Name = "DGVCalcBuySell";
            this.DGVCalcBuySell.Size = new System.Drawing.Size(772, 339);
            this.DGVCalcBuySell.TabIndex = 0;
            // 
            // BuyLabel
            // 
            this.BuyLabel.AutoSize = true;
            this.BuyLabel.Location = new System.Drawing.Point(272, -1);
            this.BuyLabel.Name = "BuyLabel";
            this.BuyLabel.Size = new System.Drawing.Size(25, 13);
            this.BuyLabel.TabIndex = 2;
            this.BuyLabel.Text = "Buy";
            // 
            // SellLabel
            // 
            this.SellLabel.AutoSize = true;
            this.SellLabel.Location = new System.Drawing.Point(144, 1);
            this.SellLabel.Name = "SellLabel";
            this.SellLabel.Size = new System.Drawing.Size(24, 13);
            this.SellLabel.TabIndex = 2;
            this.SellLabel.Text = "Sell";
            // 
            // comboCalcBuy
            // 
            this.comboCalcBuy.FormattingEnabled = true;
            this.comboCalcBuy.Items.AddRange(new object[] {
            "Buy(min)",
            "Buy(max)",
            "Buy(avg)",
            "Buy(median)",
            "Buy(self)"});
            this.comboCalcBuy.Location = new System.Drawing.Point(224, 17);
            this.comboCalcBuy.Name = "comboCalcBuy";
            this.comboCalcBuy.Size = new System.Drawing.Size(121, 21);
            this.comboCalcBuy.TabIndex = 1;
            // 
            // comboCalcSell
            // 
            this.comboCalcSell.FormattingEnabled = true;
            this.comboCalcSell.Items.AddRange(new object[] {
            "Sell(min)",
            "Sell(max)",
            "Sell(avg)",
            "Sell(median)",
            "Sell(self)"});
            this.comboCalcSell.Location = new System.Drawing.Point(97, 17);
            this.comboCalcSell.Name = "comboCalcSell";
            this.comboCalcSell.Size = new System.Drawing.Size(121, 21);
            this.comboCalcSell.TabIndex = 1;
            // 
            // CalcBuySellFinder
            // 
            this.CalcBuySellFinder.BackColor = System.Drawing.Color.Transparent;
            this.CalcBuySellFinder.ForeColor = System.Drawing.Color.Black;
            this.CalcBuySellFinder.Location = new System.Drawing.Point(3, 7);
            this.CalcBuySellFinder.Name = "CalcBuySellFinder";
            this.CalcBuySellFinder.Size = new System.Drawing.Size(88, 31);
            this.CalcBuySellFinder.TabIndex = 0;
            this.CalcBuySellFinder.Text = "Fork Finder";
            this.CalcBuySellFinder.UseVisualStyleBackColor = false;
            this.CalcBuySellFinder.Click += new System.EventHandler(this.CalcBuySellFinder_Click);
            // 
            // TabCalcManuf
            // 
            this.TabCalcManuf.Location = new System.Drawing.Point(4, 22);
            this.TabCalcManuf.Name = "TabCalcManuf";
            this.TabCalcManuf.Padding = new System.Windows.Forms.Padding(3);
            this.TabCalcManuf.Size = new System.Drawing.Size(778, 392);
            this.TabCalcManuf.TabIndex = 1;
            this.TabCalcManuf.Text = "Manufacturing";
            this.TabCalcManuf.UseVisualStyleBackColor = true;
            // 
            // TabCalcPlanet
            // 
            this.TabCalcPlanet.Location = new System.Drawing.Point(4, 22);
            this.TabCalcPlanet.Name = "TabCalcPlanet";
            this.TabCalcPlanet.Padding = new System.Windows.Forms.Padding(3);
            this.TabCalcPlanet.Size = new System.Drawing.Size(778, 392);
            this.TabCalcPlanet.TabIndex = 2;
            this.TabCalcPlanet.Text = "Planetology";
            this.TabCalcPlanet.UseVisualStyleBackColor = true;
            // 
            // TabCalcReact
            // 
            this.TabCalcReact.Location = new System.Drawing.Point(4, 22);
            this.TabCalcReact.Name = "TabCalcReact";
            this.TabCalcReact.Padding = new System.Windows.Forms.Padding(3);
            this.TabCalcReact.Size = new System.Drawing.Size(778, 392);
            this.TabCalcReact.TabIndex = 3;
            this.TabCalcReact.Text = "Reactions";
            this.TabCalcReact.UseVisualStyleBackColor = true;
            // 
            // ProgressBarPrice
            // 
            this.ProgressBarPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBarPrice.Location = new System.Drawing.Point(0, 440);
            this.ProgressBarPrice.Name = "ProgressBarPrice";
            this.ProgressBarPrice.Size = new System.Drawing.Size(800, 10);
            this.ProgressBarPrice.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(285, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load YAML";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProgressBarPrice);
            this.Controls.Add(this.TabControlMain);
            this.Name = "MainForm";
            this.Text = "EvE Planetary Calculator";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.TabControlMain.ResumeLayout(false);
            this.tabPrice.ResumeLayout(false);
            this.splitPrices.Panel1.ResumeLayout(false);
            this.splitPrices.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPrices)).EndInit();
            this.splitPrices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPrices)).EndInit();
            this.tabWorks.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.TabControlFormulas.ResumeLayout(false);
            this.tabPageManuf.ResumeLayout(false);
            this.tabPagePlanet.ResumeLayout(false);
            this.tabPageReact.ResumeLayout(false);
            this.panelFormulas.ResumeLayout(false);
            this.panelFormulas.PerformLayout();
            this.tabCalc.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.TabCalcBuySell.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCalcBuySell)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage tabPrice;
        private System.Windows.Forms.DataGridView DGVPrices;
        private System.Windows.Forms.TabPage tabCalc;
        private System.Windows.Forms.SplitContainer splitPrices;
        private System.Windows.Forms.TabPage tabWorks;
        private System.Windows.Forms.Button UpdatePrices;
        private System.Windows.Forms.ProgressBar ProgressBarPrice;
        private System.Windows.Forms.Button ClearEmpty;
        private System.Windows.Forms.Button SaveBttn;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage TabCalcBuySell;
        private System.Windows.Forms.TabPage TabCalcManuf;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView DGVCalcBuySell;
        private System.Windows.Forms.Button CalcBuySellFinder;
        private System.Windows.Forms.Label BuyLabel;
        private System.Windows.Forms.Label SellLabel;
        private System.Windows.Forms.ComboBox comboCalcBuy;
        private System.Windows.Forms.ComboBox comboCalcSell;
        private System.Windows.Forms.TabControl TabControlFormulas;
        private System.Windows.Forms.TabPage tabPageManuf;
        private System.Windows.Forms.TabPage tabPagePlanet;
        private System.Windows.Forms.TabPage tabPageReact;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button ButtonAddEditManuf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage TabCalcPlanet;
        private System.Windows.Forms.TabPage TabCalcReact;
        private System.Windows.Forms.TreeView treeViewFormPlanet;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.TreeView treeViewFormManuf;
        private System.Windows.Forms.TreeView treeViewFormReact;
        private System.Windows.Forms.Panel panelFormulas;
        private System.Windows.Forms.TextBox textBoxFormManufInputCount;
        private System.Windows.Forms.TextBox textBoxFormManufOutCount;
        private System.Windows.Forms.TextBox textBoxFormManufInputID;
        private System.Windows.Forms.TextBox textBoxFormManufOutID;
        private System.Windows.Forms.TextBox textBoxFormManufOutName;
        private System.Windows.Forms.TextBox textBoxFormManufInputName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFormManufBPName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonRemoveManuf;
        private System.Windows.Forms.Button button1;
    }
}

