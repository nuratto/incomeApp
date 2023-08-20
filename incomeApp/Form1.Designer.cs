namespace incomeApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addBTN = new System.Windows.Forms.Button();
            this.addText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taxText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.incomeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.trackBTN = new System.Windows.Forms.Button();
            this.spentText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.spendingNote = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spendingNote)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(159)))), ((int)(((byte)(165)))));
            this.panel1.Controls.Add(this.addBTN);
            this.panel1.Controls.Add(this.addText);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.incomeLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.taxText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.incomeText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 614);
            this.panel1.TabIndex = 0;
            // 
            // addBTN
            // 
            this.addBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBTN.Location = new System.Drawing.Point(14, 495);
            this.addBTN.Name = "addBTN";
            this.addBTN.Size = new System.Drawing.Size(157, 38);
            this.addBTN.TabIndex = 9;
            this.addBTN.Text = "Add";
            this.addBTN.UseVisualStyleBackColor = true;
            this.addBTN.Click += new System.EventHandler(this.addBTN_Click);
            // 
            // addText
            // 
            this.addText.Location = new System.Drawing.Point(0, 442);
            this.addText.Multiline = true;
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(200, 34);
            this.addText.TabIndex = 8;
            this.addText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Add Money";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // incomeLabel
            // 
            this.incomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomeLabel.Location = new System.Drawing.Point(12, 85);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(173, 38);
            this.incomeLabel.TabIndex = 5;
            this.incomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Budget App";
            // 
            // taxText
            // 
            this.taxText.Location = new System.Drawing.Point(0, 281);
            this.taxText.Multiline = true;
            this.taxText.Name = "taxText";
            this.taxText.Size = new System.Drawing.Size(200, 34);
            this.taxText.TabIndex = 4;
            this.taxText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tax Deduction";
            // 
            // incomeText
            // 
            this.incomeText.Location = new System.Drawing.Point(0, 203);
            this.incomeText.Multiline = true;
            this.incomeText.Name = "incomeText";
            this.incomeText.Size = new System.Drawing.Size(200, 34);
            this.incomeText.TabIndex = 2;
            this.incomeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Monthly Income";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(159)))), ((int)(((byte)(165)))));
            this.panel2.Controls.Add(this.deleteBTN);
            this.panel2.Controls.Add(this.trackBTN);
            this.panel2.Controls.Add(this.spentText);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.titleText);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateText);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 114);
            this.panel2.TabIndex = 1;
            // 
            // deleteBTN
            // 
            this.deleteBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.deleteBTN.Location = new System.Drawing.Point(721, 61);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(128, 30);
            this.deleteBTN.TabIndex = 13;
            this.deleteBTN.Text = "Delete";
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // trackBTN
            // 
            this.trackBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            this.trackBTN.Location = new System.Drawing.Point(721, 12);
            this.trackBTN.Name = "trackBTN";
            this.trackBTN.Size = new System.Drawing.Size(128, 30);
            this.trackBTN.TabIndex = 7;
            this.trackBTN.Text = "Track";
            this.trackBTN.UseVisualStyleBackColor = true;
            this.trackBTN.Click += new System.EventHandler(this.trackBTN_Click);
            // 
            // spentText
            // 
            this.spentText.Location = new System.Drawing.Point(491, 41);
            this.spentText.Multiline = true;
            this.spentText.Name = "spentText";
            this.spentText.Size = new System.Drawing.Size(200, 34);
            this.spentText.TabIndex = 12;
            this.spentText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount Spent";
            // 
            // titleText
            // 
            this.titleText.Location = new System.Drawing.Point(256, 41);
            this.titleText.Multiline = true;
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(200, 34);
            this.titleText.TabIndex = 8;
            this.titleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Items";
            // 
            // dateText
            // 
            this.dateText.Location = new System.Drawing.Point(12, 41);
            this.dateText.Multiline = true;
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(200, 34);
            this.dateText.TabIndex = 10;
            this.dateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Date";
            // 
            // spendingNote
            // 
            this.spendingNote.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(10);
            this.spendingNote.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.spendingNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.spendingNote.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.spendingNote.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.spendingNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spendingNote.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.spendingNote.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.spendingNote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.spendingNote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.spendingNote.ColumnHeadersHeight = 50;
            this.spendingNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.spendingNote.DefaultCellStyle = dataGridViewCellStyle3;
            this.spendingNote.Location = new System.Drawing.Point(200, 111);
            this.spendingNote.MultiSelect = false;
            this.spendingNote.Name = "spendingNote";
            this.spendingNote.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(10);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.spendingNote.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.spendingNote.RowHeadersVisible = false;
            this.spendingNote.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10);
            this.spendingNote.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.spendingNote.Size = new System.Drawing.Size(861, 503);
            this.spendingNote.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 614);
            this.Controls.Add(this.spendingNote);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spendingNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox incomeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.TextBox taxText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button trackBTN;
        private System.Windows.Forms.TextBox spentText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox titleText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dateText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView spendingNote;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button addBTN;
        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.Label label7;
    }
}

