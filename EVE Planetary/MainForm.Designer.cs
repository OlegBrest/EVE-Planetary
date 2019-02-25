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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy_min_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy_median_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy_avg_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy_max_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy_self_clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitPrices = new System.Windows.Forms.SplitContainer();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitPrices)).BeginInit();
            this.splitPrices.Panel1.SuspendLayout();
            this.splitPrices.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitPrices);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Prices";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_clmn,
            this.Name_clmn,
            this.Buy_min_clmn,
            this.Buy_median_clmn,
            this.Buy_avg_clmn,
            this.Buy_max_clmn,
            this.Buy_self_clmn});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 377);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_clmn
            // 
            this.ID_clmn.HeaderText = "ID";
            this.ID_clmn.Name = "ID_clmn";
            // 
            // Name_clmn
            // 
            this.Name_clmn.HeaderText = "Name";
            this.Name_clmn.Name = "Name_clmn";
            // 
            // Buy_min_clmn
            // 
            this.Buy_min_clmn.HeaderText = "Buy(min)";
            this.Buy_min_clmn.Name = "Buy_min_clmn";
            // 
            // Buy_median_clmn
            // 
            this.Buy_median_clmn.HeaderText = "Buy(median)";
            this.Buy_median_clmn.Name = "Buy_median_clmn";
            // 
            // Buy_avg_clmn
            // 
            this.Buy_avg_clmn.HeaderText = "Buy(avg)";
            this.Buy_avg_clmn.Name = "Buy_avg_clmn";
            // 
            // Buy_max_clmn
            // 
            this.Buy_max_clmn.HeaderText = "Buy(max)";
            this.Buy_max_clmn.Name = "Buy_max_clmn";
            // 
            // Buy_self_clmn
            // 
            this.Buy_self_clmn.HeaderText = "Buy(self)";
            this.Buy_self_clmn.Name = "Buy_self_clmn";
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
            this.splitPrices.Panel1.Controls.Add(this.dataGridView1);
            this.splitPrices.Size = new System.Drawing.Size(786, 418);
            this.splitPrices.SplitterDistance = 377;
            this.splitPrices.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "EvE Planetary";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitPrices.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPrices)).EndInit();
            this.splitPrices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.SplitContainer splitPrices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy_min_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy_median_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy_avg_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy_max_clmn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy_self_clmn;
    }
}

