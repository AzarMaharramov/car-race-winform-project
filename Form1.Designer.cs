namespace CarRace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Red_car = new System.Windows.Forms.Button();
            this.Blue_car = new System.Windows.Forms.Button();
            this.finish = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Red_car
            // 
            this.Red_car.FlatAppearance.BorderSize = 0;
            this.Red_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Red_car.Image = ((System.Drawing.Image)(resources.GetObject("Red_car.Image")));
            this.Red_car.Location = new System.Drawing.Point(44, 141);
            this.Red_car.Name = "Red_car";
            this.Red_car.Size = new System.Drawing.Size(135, 60);
            this.Red_car.TabIndex = 0;
            this.Red_car.UseVisualStyleBackColor = true;
            // 
            // Blue_car
            // 
            this.Blue_car.FlatAppearance.BorderSize = 0;
            this.Blue_car.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Blue_car.Image = ((System.Drawing.Image)(resources.GetObject("Blue_car.Image")));
            this.Blue_car.Location = new System.Drawing.Point(44, 245);
            this.Blue_car.Name = "Blue_car";
            this.Blue_car.Size = new System.Drawing.Size(135, 60);
            this.Blue_car.TabIndex = 1;
            this.Blue_car.UseVisualStyleBackColor = true;
            // 
            // finish
            // 
            this.finish.BackColor = System.Drawing.Color.White;
            this.finish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.finish.Image = ((System.Drawing.Image)(resources.GetObject("finish.Image")));
            this.finish.Location = new System.Drawing.Point(1307, 33);
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 371);
            this.finish.TabIndex = 2;
            this.finish.UseVisualStyleBackColor = false;
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.start.Font = new System.Drawing.Font("Helvetica Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.Location = new System.Drawing.Point(628, 420);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(156, 77);
            this.start.TabIndex = 3;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 553);
            this.Controls.Add(this.start);
            this.Controls.Add(this.finish);
            this.Controls.Add(this.Blue_car);
            this.Controls.Add(this.Red_car);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Red_car;
        private System.Windows.Forms.Button Blue_car;
        private System.Windows.Forms.Button finish;
        private System.Windows.Forms.Button start;
    }
}

