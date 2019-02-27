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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Count");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Material", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Name", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.tabPrice = new System.Windows.Forms.TabPage();
            this.splitPrices = new System.Windows.Forms.SplitContainer();
            this.DGVPrices = new System.Windows.Forms.DataGridView();
            this.SaveBttn = new System.Windows.Forms.Button();
            this.ClearEmpty = new System.Windows.Forms.Button();
            this.UpdatePrices = new System.Windows.Forms.Button();
            this.tabWorks = new System.Windows.Forms.TabPage();
            this.TabControlFormulas = new System.Windows.Forms.TabControl();
            this.tabPageManuf = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPagePlanet = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.tabPageReact = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.TabControlMain.SuspendLayout();
            this.tabPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPrices)).BeginInit();
            this.splitPrices.Panel1.SuspendLayout();
            this.splitPrices.Panel2.SuspendLayout();
            this.splitPrices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPrices)).BeginInit();
            this.tabWorks.SuspendLayout();
            this.TabControlFormulas.SuspendLayout();
            this.tabPageManuf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPagePlanet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabPageReact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
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
            this.splitPrices.Panel2.Controls.Add(this.UpdatePrices);
            this.splitPrices.Size = new System.Drawing.Size(786, 418);
            this.splitPrices.SplitterDistance = 360;
            this.splitPrices.TabIndex = 1;
            // 
            // DGVPrices
            // 
            this.DGVPrices.AllowUserToAddRows = false;
            this.DGVPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPrices.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.tabWorks.Controls.Add(this.TabControlFormulas);
            this.tabWorks.Location = new System.Drawing.Point(4, 22);
            this.tabWorks.Name = "tabWorks";
            this.tabWorks.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorks.Size = new System.Drawing.Size(792, 424);
            this.tabWorks.TabIndex = 2;
            this.tabWorks.Text = "Formulas";
            this.tabWorks.UseVisualStyleBackColor = true;
            // 
            // TabControlFormulas
            // 
            this.TabControlFormulas.Controls.Add(this.tabPageManuf);
            this.TabControlFormulas.Controls.Add(this.tabPagePlanet);
            this.TabControlFormulas.Controls.Add(this.tabPageReact);
            this.TabControlFormulas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlFormulas.Location = new System.Drawing.Point(3, 3);
            this.TabControlFormulas.Name = "TabControlFormulas";
            this.TabControlFormulas.SelectedIndex = 0;
            this.TabControlFormulas.Size = new System.Drawing.Size(786, 418);
            this.TabControlFormulas.TabIndex = 0;
            // 
            // tabPageManuf
            // 
            this.tabPageManuf.Controls.Add(this.splitContainer2);
            this.tabPageManuf.Location = new System.Drawing.Point(4, 22);
            this.tabPageManuf.Name = "tabPageManuf";
            this.tabPageManuf.Size = new System.Drawing.Size(778, 392);
            this.tabPageManuf.TabIndex = 0;
            this.tabPageManuf.Text = "Manufacturing";
            this.tabPageManuf.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.button1);
            this.splitContainer2.Panel2.Controls.Add(this.button2);
            this.splitContainer2.Panel2.Controls.Add(this.button3);
            this.splitContainer2.Size = new System.Drawing.Size(778, 392);
            this.splitContainer2.SplitterDistance = 334;
            this.splitContainer2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(778, 334);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(191, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save Prices";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(97, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 31);
            this.button2.TabIndex = 0;
            this.button2.Text = "Clear Empty";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(3, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 31);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tabPagePlanet
            // 
            this.tabPagePlanet.Controls.Add(this.splitContainer3);
            this.tabPagePlanet.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlanet.Name = "tabPagePlanet";
            this.tabPagePlanet.Size = new System.Drawing.Size(778, 392);
            this.tabPagePlanet.TabIndex = 1;
            this.tabPagePlanet.Text = "Planetology";
            this.tabPagePlanet.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.button4);
            this.splitContainer3.Panel2.Controls.Add(this.button5);
            this.splitContainer3.Panel2.Controls.Add(this.button6);
            this.splitContainer3.Size = new System.Drawing.Size(778, 392);
            this.splitContainer3.SplitterDistance = 334;
            this.splitContainer3.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(191, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 31);
            this.button4.TabIndex = 0;
            this.button4.Text = "Save Prices";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(97, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 31);
            this.button5.TabIndex = 0;
            this.button5.Text = "Clear Empty";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(3, 7);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 31);
            this.button6.TabIndex = 0;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // tabPageReact
            // 
            this.tabPageReact.Controls.Add(this.splitContainer4);
            this.tabPageReact.Location = new System.Drawing.Point(4, 22);
            this.tabPageReact.Name = "tabPageReact";
            this.tabPageReact.Size = new System.Drawing.Size(778, 392);
            this.tabPageReact.TabIndex = 2;
            this.tabPageReact.Text = "Reaction";
            this.tabPageReact.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.dataGridView3);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.button7);
            this.splitContainer4.Panel2.Controls.Add(this.button8);
            this.splitContainer4.Panel2.Controls.Add(this.button9);
            this.splitContainer4.Size = new System.Drawing.Size(778, 392);
            this.splitContainer4.SplitterDistance = 334;
            this.splitContainer4.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView3.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(778, 334);
            this.dataGridView3.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(191, 7);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(88, 31);
            this.button7.TabIndex = 0;
            this.button7.Text = "Save Prices";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Location = new System.Drawing.Point(97, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(88, 31);
            this.button8.TabIndex = 0;
            this.button8.Text = "Clear Empty";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.ForeColor = System.Drawing.Color.Black;
            this.button9.Location = new System.Drawing.Point(3, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(88, 31);
            this.button9.TabIndex = 0;
            this.button9.Text = "button9";
            this.button9.UseVisualStyleBackColor = false;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVCalcBuySell.DefaultCellStyle = dataGridViewCellStyle4;
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
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HotTracking = true;
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "CounNode";
            treeNode1.Text = "Count";
            treeNode2.Name = "MaterialNode";
            treeNode2.Text = "Material";
            treeNode3.Name = "NameNode";
            treeNode3.Text = "Name";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(778, 334);
            this.treeView1.TabIndex = 0;
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
            this.TabControlFormulas.ResumeLayout(false);
            this.tabPageManuf.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPagePlanet.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabPageReact.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.TabPage TabCalcPlanet;
        private System.Windows.Forms.TabPage TabCalcReact;
        private System.Windows.Forms.TreeView treeView1;
    }
}

