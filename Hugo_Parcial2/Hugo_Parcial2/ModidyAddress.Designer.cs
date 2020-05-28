using System.ComponentModel;

namespace Hugo_Parcial2
{
    partial class ModidyAddress
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        private void InitializeComponent()
{
    this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
    this.label2 = new System.Windows.Forms.Label();
    this.label1 = new System.Windows.Forms.Label();
    this.comboBox1 = new System.Windows.Forms.ComboBox();
    this.textBox1 = new System.Windows.Forms.TextBox();
    this.button1 = new System.Windows.Forms.Button();
    this.tableLayoutPanel1.SuspendLayout();
    this.SuspendLayout();
    // 
    // tableLayoutPanel1
    // 
    this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.tableLayoutPanel1.ColumnCount = 1;
    this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
    this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
    this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
    this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 1);
    this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 3);
    this.tableLayoutPanel1.Controls.Add(this.button1, 0, 4);
    this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
    this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
    this.tableLayoutPanel1.Name = "tableLayoutPanel1";
    this.tableLayoutPanel1.RowCount = 5;
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
    this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
    this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 175);
    this.tableLayoutPanel1.TabIndex = 0;
    // 
    // label2
    // 
    this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
    this.label2.Location = new System.Drawing.Point(3, 70);
    this.label2.Name = "label2";
    this.label2.Size = new System.Drawing.Size(301, 35);
    this.label2.TabIndex = 4;
    this.label2.Text = "Ingrese la nueva direccion";
    // 
    // label1
    // 
    this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
    this.label1.Location = new System.Drawing.Point(3, 0);
    this.label1.Name = "label1";
    this.label1.Size = new System.Drawing.Size(301, 35);
    this.label1.TabIndex = 0;
    this.label1.Text = "Seleccione la direccion que dese modificar\r\n";
    // 
    // comboBox1
    // 
    this.comboBox1.FormattingEnabled = true;
    this.comboBox1.Location = new System.Drawing.Point(3, 38);
    this.comboBox1.Name = "comboBox1";
    this.comboBox1.Size = new System.Drawing.Size(182, 23);
    this.comboBox1.TabIndex = 1;
    // 
    // textBox1
    // 
    this.textBox1.Location = new System.Drawing.Point(3, 108);
    this.textBox1.Name = "textBox1";
    this.textBox1.Size = new System.Drawing.Size(299, 23);
    this.textBox1.TabIndex = 2;
    // 
    // button1
    // 
    this.button1.Location = new System.Drawing.Point(3, 143);
    this.button1.Name = "button1";
    this.button1.Size = new System.Drawing.Size(174, 29);
    this.button1.TabIndex = 3;
    this.button1.Text = "button1";
    this.button1.UseVisualStyleBackColor = true;
    this.button1.Click += new System.EventHandler(this.button1_Click);
    // 
    // ModidyAddress
    // 
    this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    this.Controls.Add(this.tableLayoutPanel1);
    this.Name = "ModidyAddress";
    this.Size = new System.Drawing.Size(307, 175);
    this.Load += new System.EventHandler(this.ModidyAddress_Load);
    this.tableLayoutPanel1.ResumeLayout(false);
    this.tableLayoutPanel1.PerformLayout();
    this.ResumeLayout(false);
}

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}