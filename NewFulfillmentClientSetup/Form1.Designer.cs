namespace NewFulfillmentClientSetup
{
    partial class FGS_iis_main
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
            this.Main_text_box = new System.Windows.Forms.TextBox();
            this.Save_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Path_label = new System.Windows.Forms.Label();
            this.Host_label = new System.Windows.Forms.Label();
            this.Message_label = new System.Windows.Forms.Label();
            this.main_box_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Main_text_box
            // 
            this.Main_text_box.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main_text_box.Location = new System.Drawing.Point(62, 34);
            this.Main_text_box.MaxLength = 16;
            this.Main_text_box.Name = "Main_text_box";
            this.Main_text_box.Size = new System.Drawing.Size(496, 30);
            this.Main_text_box.TabIndex = 0;
            this.Main_text_box.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Save_button
            // 
            this.Save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_button.Location = new System.Drawing.Point(62, 179);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(85, 33);
            this.Save_button.TabIndex = 1;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.BackColor = System.Drawing.SystemColors.Control;
            this.Cancel_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_button.Location = new System.Drawing.Point(473, 179);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(85, 33);
            this.Cancel_button.TabIndex = 2;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = false;
            this.Cancel_button.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Path_label
            // 
            this.Path_label.AutoSize = true;
            this.Path_label.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Path_label.Location = new System.Drawing.Point(58, 108);
            this.Path_label.MaximumSize = new System.Drawing.Size(500, 0);
            this.Path_label.Name = "Path_label";
            this.Path_label.Size = new System.Drawing.Size(500, 44);
            this.Path_label.TabIndex = 3;
            this.Path_label.Text = "Path:C:\\DEV\\TeamProject\\Fulfillment\\NAME\\Development\\Source\\Fulfillment.Web";
            // 
            // Host_label
            // 
            this.Host_label.AutoSize = true;
            this.Host_label.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Host_label.ForeColor = System.Drawing.Color.Black;
            this.Host_label.Location = new System.Drawing.Point(58, 76);
            this.Host_label.MaximumSize = new System.Drawing.Size(500, 0);
            this.Host_label.Name = "Host_label";
            this.Host_label.Size = new System.Drawing.Size(290, 22);
            this.Host_label.TabIndex = 4;
            this.Host_label.Text = "Host: NAME.fulfillment.local";
            // 
            // Message_label
            // 
            this.Message_label.AutoSize = true;
            this.Message_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_label.ForeColor = System.Drawing.Color.ForestGreen;
            this.Message_label.Location = new System.Drawing.Point(153, 179);
            this.Message_label.Name = "Message_label";
            this.Message_label.Size = new System.Drawing.Size(135, 29);
            this.Message_label.TabIndex = 5;
            this.Message_label.Text = "SUCCESS";
            this.Message_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Message_label.Visible = false;
            // 
            // main_box_label
            // 
            this.main_box_label.AutoSize = true;
            this.main_box_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.main_box_label.Location = new System.Drawing.Point(179, 9);
            this.main_box_label.Name = "main_box_label";
            this.main_box_label.Size = new System.Drawing.Size(238, 18);
            this.main_box_label.TabIndex = 7;
            this.main_box_label.Text = "Please enter a name for new client.";
            // 
            // FGS_iis_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 241);
            this.Controls.Add(this.main_box_label);
            this.Controls.Add(this.Message_label);
            this.Controls.Add(this.Host_label);
            this.Controls.Add(this.Path_label);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Main_text_box);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(610, 280);
            this.MinimumSize = new System.Drawing.Size(610, 280);
            this.Name = "FGS_iis_main";
            this.Text = "FGS IIS setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Main_text_box;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Label Path_label;
        private System.Windows.Forms.Label Host_label;
        private System.Windows.Forms.Label Message_label;
        private System.Windows.Forms.Label main_box_label;
    }
}

