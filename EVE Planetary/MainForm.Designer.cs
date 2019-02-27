﻿namespace EVE_Planetary
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPrice = new System.Windows.Forms.TabPage();
            this.splitPrices = new System.Windows.Forms.SplitContainer();
            this.DGVPrices = new System.Windows.Forms.DataGridView();
            this.UpdatePrices = new System.Windows.Forms.Button();
            this.ProgressBarPrice = new System.Windows.Forms.ProgressBar();
            this.tabWorks = new System.Windows.Forms.TabPage();
            this.tabCalc = new System.Windows.Forms.TabPage();
            this.ClearEmpty = new System.Windows.Forms.Button();
            this.SaveBttn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPrice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPrices)).BeginInit();
            this.splitPrices.Panel1.SuspendLayout();
            this.splitPrices.Panel2.SuspendLayout();
            this.splitPrices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVPrices)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPrice);
            this.tabControl1.Controls.Add(this.tabWorks);
            this.tabControl1.Controls.Add(this.tabCalc);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
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
            this.splitPrices.Panel2.Controls.Add(this.ProgressBarPrice);
            this.splitPrices.Size = new System.Drawing.Size(786, 418);
            this.splitPrices.SplitterDistance = 360;
            this.splitPrices.TabIndex = 1;
            // 
            // DGVPrices
            // 
            this.DGVPrices.AllowUserToAddRows = false;
            this.DGVPrices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVPrices.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVPrices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVPrices.Location = new System.Drawing.Point(0, 0);
            this.DGVPrices.Name = "DGVPrices";
            this.DGVPrices.Size = new System.Drawing.Size(786, 360);
            this.DGVPrices.TabIndex = 0;
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
            // ProgressBarPrice
            // 
            this.ProgressBarPrice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBarPrice.Location = new System.Drawing.Point(0, 44);
            this.ProgressBarPrice.Name = "ProgressBarPrice";
            this.ProgressBarPrice.Size = new System.Drawing.Size(786, 10);
            this.ProgressBarPrice.TabIndex = 1;
            // 
            // tabWorks
            // 
            this.tabWorks.Location = new System.Drawing.Point(4, 22);
            this.tabWorks.Name = "tabWorks";
            this.tabWorks.Padding = new System.Windows.Forms.Padding(3);
            this.tabWorks.Size = new System.Drawing.Size(792, 424);
            this.tabWorks.TabIndex = 2;
            this.tabWorks.Text = "Formulas";
            this.tabWorks.UseVisualStyleBackColor = true;
            // 
            // tabCalc
            // 
            this.tabCalc.Location = new System.Drawing.Point(4, 22);
            this.tabCalc.Name = "tabCalc";
            this.tabCalc.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalc.Size = new System.Drawing.Size(792, 424);
            this.tabCalc.TabIndex = 1;
            this.tabCalc.Text = "Calculations";
            this.tabCalc.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "EvE Planetary Calculator";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPrice.ResumeLayout(false);
            this.splitPrices.Panel1.ResumeLayout(false);
            this.splitPrices.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPrices)).EndInit();
            this.splitPrices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVPrices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPrice;
        private System.Windows.Forms.DataGridView DGVPrices;
        private System.Windows.Forms.TabPage tabCalc;
        private System.Windows.Forms.SplitContainer splitPrices;
        private System.Windows.Forms.TabPage tabWorks;
        private System.Windows.Forms.Button UpdatePrices;
        private System.Windows.Forms.ProgressBar ProgressBarPrice;
        private System.Windows.Forms.Button ClearEmpty;
        private System.Windows.Forms.Button SaveBttn;
    }
}

