namespace TrainSystem.UI
{
    partial class AdminFormEmergency
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtTrainID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StartStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EndStation = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberOfCars = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumberOfSeats = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.StartDate,
            this.EndDate,
            this.StartStation,
            this.EndStation,
            this.NumberOfCars,
            this.NumberOfSeats});
            this.listView1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(31, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(701, 291);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // txtTrainID
            // 
            this.txtTrainID.Location = new System.Drawing.Point(90, 334);
            this.txtTrainID.Name = "txtTrainID";
            this.txtTrainID.Size = new System.Drawing.Size(100, 20);
            this.txtTrainID.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(448, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Remove";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // StartDate
            // 
            this.StartDate.Text = "Start Date";
            this.StartDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartDate.Width = 70;
            // 
            // EndDate
            // 
            this.EndDate.Text = "End Date";
            this.EndDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndDate.Width = 70;
            // 
            // StartStation
            // 
            this.StartStation.Text = "Start Station";
            this.StartStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartStation.Width = 70;
            // 
            // EndStation
            // 
            this.EndStation.Text = "End Station";
            this.EndStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndStation.Width = 70;
            // 
            // NumberOfCars
            // 
            this.NumberOfCars.Text = "Number Of Cars";
            this.NumberOfCars.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberOfCars.Width = 70;
            // 
            // NumberOfSeats
            // 
            this.NumberOfSeats.Text = "Number Of Seats";
            this.NumberOfSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumberOfSeats.Width = 132;
            // 
            // AdminFormEmergency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 438);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTrainID);
            this.Controls.Add(this.listView1);
            this.Name = "AdminFormEmergency";
            this.Text = "AdminFormEmergency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtTrainID;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader StartDate;
        private System.Windows.Forms.ColumnHeader EndDate;
        private System.Windows.Forms.ColumnHeader StartStation;
        private System.Windows.Forms.ColumnHeader EndStation;
        private System.Windows.Forms.ColumnHeader NumberOfCars;
        private System.Windows.Forms.ColumnHeader NumberOfSeats;
    }
}
