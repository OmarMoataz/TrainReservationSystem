namespace TrainSystem.UI
{
    partial class EditTrain
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
            this.txtCarsNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtDepDate = new System.Windows.Forms.TextBox();
            this.txtArrDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCarsNum
            // 
            this.txtCarsNum.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.txtCarsNum.Location = new System.Drawing.Point(141, 155);
            this.txtCarsNum.Name = "txtCarsNum";
            this.txtCarsNum.Size = new System.Drawing.Size(100, 20);
            this.txtCarsNum.TabIndex = 54;
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.button1.Location = new System.Drawing.Point(166, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 53;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Departure Date";
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "No. of Cars";
            // 
            // txtTo
            // 
            this.txtTo.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.txtTo.Location = new System.Drawing.Point(141, 72);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 20);
            this.txtTo.TabIndex = 50;
            // 
            // txtDepDate
            // 
            this.txtDepDate.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.txtDepDate.Location = new System.Drawing.Point(141, 101);
            this.txtDepDate.Name = "txtDepDate";
            this.txtDepDate.Size = new System.Drawing.Size(100, 20);
            this.txtDepDate.TabIndex = 49;
            // 
            // txtArrDate
            // 
            this.txtArrDate.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.txtArrDate.Location = new System.Drawing.Point(141, 129);
            this.txtArrDate.Name = "txtArrDate";
            this.txtArrDate.Size = new System.Drawing.Size(100, 20);
            this.txtArrDate.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Arrival Date";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 45;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(141, 45);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 20);
            this.txtFrom.TabIndex = 55;
            // 
            // EditTrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.txtCarsNum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtDepDate);
            this.Controls.Add(this.txtArrDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditTrain";
            this.Text = "EditTrain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCarsNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtDepDate;
        private System.Windows.Forms.TextBox txtArrDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFrom;
    }
}