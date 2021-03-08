
namespace Gallery
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.roundedPanel1 = new RoundedPanel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.roundedPanel3 = new RoundedPanel();
            this.roundedPanel2 = new RoundedPanel();
            this.Close_button = new ePOSOne.btnProduct.Button_WOC();
            this.All_Pic = new ePOSOne.btnProduct.Button_WOC();
            this.Multiple_Pic = new ePOSOne.btnProduct.Button_WOC();
            this.One_Pic = new ePOSOne.btnProduct.Button_WOC();
            this.Enter_pic = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC3 = new ePOSOne.btnProduct.Button_WOC();
            this.roundedPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roundedPanel1.Controls.Add(this.button_WOC3);
            this.roundedPanel1.Controls.Add(this.button_WOC2);
            this.roundedPanel1.Controls.Add(this.button_WOC1);
            this.roundedPanel1.Controls.Add(this.checkBox2);
            this.roundedPanel1.Controls.Add(this.checkBox1);
            this.roundedPanel1.Controls.Add(this.roundedPanel3);
            this.roundedPanel1.Controls.Add(this.roundedPanel2);
            this.roundedPanel1.Location = new System.Drawing.Point(92, 123);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Radius = 50;
            this.roundedPanel1.Size = new System.Drawing.Size(1012, 530);
            this.roundedPanel1.TabIndex = 5;
            this.roundedPanel1.Thickness = 0F;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(862, 487);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 29);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Clear";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(707, 490);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 29);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Select All";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.AutoScroll = true;
            this.roundedPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roundedPanel3.Location = new System.Drawing.Point(707, 25);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Radius = 50;
            this.roundedPanel3.Size = new System.Drawing.Size(269, 443);
            this.roundedPanel3.TabIndex = 1;
            this.roundedPanel3.Thickness = 0F;
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.AutoScroll = true;
            this.roundedPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.roundedPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundedPanel2.Location = new System.Drawing.Point(12, 25);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Radius = 50;
            this.roundedPanel2.Size = new System.Drawing.Size(689, 443);
            this.roundedPanel2.TabIndex = 0;
            this.roundedPanel2.Thickness = 0F;
            // 
            // Close_button
            // 
            this.Close_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Close_button.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Close_button.ButtonColor = System.Drawing.Color.Black;
            this.Close_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.Close_button.FlatAppearance.BorderSize = 0;
            this.Close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Close_button.Location = new System.Drawing.Point(1004, 49);
            this.Close_button.Name = "Close_button";
            this.Close_button.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Close_button.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Close_button.OnHoverTextColor = System.Drawing.Color.White;
            this.Close_button.Size = new System.Drawing.Size(91, 42);
            this.Close_button.TabIndex = 4;
            this.Close_button.Text = "Close";
            this.Close_button.TextColor = System.Drawing.Color.White;
            this.Close_button.UseMnemonic = false;
            this.Close_button.UseVisualStyleBackColor = false;
            this.Close_button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // All_Pic
            // 
            this.All_Pic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.All_Pic.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.All_Pic.ButtonColor = System.Drawing.Color.Black;
            this.All_Pic.Cursor = System.Windows.Forms.Cursors.Default;
            this.All_Pic.FlatAppearance.BorderSize = 0;
            this.All_Pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.All_Pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Pic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.All_Pic.Location = new System.Drawing.Point(793, 49);
            this.All_Pic.Name = "All_Pic";
            this.All_Pic.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.All_Pic.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.All_Pic.OnHoverTextColor = System.Drawing.Color.White;
            this.All_Pic.Size = new System.Drawing.Size(186, 42);
            this.All_Pic.TabIndex = 3;
            this.All_Pic.Text = "For All Pictures";
            this.All_Pic.TextColor = System.Drawing.Color.White;
            this.All_Pic.UseMnemonic = false;
            this.All_Pic.UseVisualStyleBackColor = false;
            this.All_Pic.Click += new System.EventHandler(this.All_Pic_Click);
            // 
            // Multiple_Pic
            // 
            this.Multiple_Pic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Multiple_Pic.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Multiple_Pic.ButtonColor = System.Drawing.Color.Black;
            this.Multiple_Pic.Cursor = System.Windows.Forms.Cursors.Default;
            this.Multiple_Pic.FlatAppearance.BorderSize = 0;
            this.Multiple_Pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Multiple_Pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiple_Pic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Multiple_Pic.Location = new System.Drawing.Point(548, 49);
            this.Multiple_Pic.Name = "Multiple_Pic";
            this.Multiple_Pic.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Multiple_Pic.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Multiple_Pic.OnHoverTextColor = System.Drawing.Color.White;
            this.Multiple_Pic.Size = new System.Drawing.Size(204, 42);
            this.Multiple_Pic.TabIndex = 2;
            this.Multiple_Pic.Text = "For Multiple Pictures";
            this.Multiple_Pic.TextColor = System.Drawing.Color.White;
            this.Multiple_Pic.UseMnemonic = false;
            this.Multiple_Pic.UseVisualStyleBackColor = false;
            this.Multiple_Pic.Click += new System.EventHandler(this.Multiple_Pic_Click);
            // 
            // One_Pic
            // 
            this.One_Pic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.One_Pic.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.One_Pic.ButtonColor = System.Drawing.Color.Black;
            this.One_Pic.Cursor = System.Windows.Forms.Cursors.Default;
            this.One_Pic.FlatAppearance.BorderSize = 0;
            this.One_Pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.One_Pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.One_Pic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.One_Pic.Location = new System.Drawing.Point(332, 49);
            this.One_Pic.Name = "One_Pic";
            this.One_Pic.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.One_Pic.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.One_Pic.OnHoverTextColor = System.Drawing.Color.White;
            this.One_Pic.Size = new System.Drawing.Size(186, 42);
            this.One_Pic.TabIndex = 1;
            this.One_Pic.Text = "For One Picture";
            this.One_Pic.TextColor = System.Drawing.Color.White;
            this.One_Pic.UseMnemonic = false;
            this.One_Pic.UseVisualStyleBackColor = false;
            this.One_Pic.Click += new System.EventHandler(this.One_Pic_Click);
            // 
            // Enter_pic
            // 
            this.Enter_pic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Enter_pic.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enter_pic.ButtonColor = System.Drawing.Color.Black;
            this.Enter_pic.Cursor = System.Windows.Forms.Cursors.Default;
            this.Enter_pic.FlatAppearance.BorderSize = 0;
            this.Enter_pic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enter_pic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_pic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Enter_pic.Location = new System.Drawing.Point(101, 49);
            this.Enter_pic.Name = "Enter_pic";
            this.Enter_pic.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enter_pic.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enter_pic.OnHoverTextColor = System.Drawing.Color.White;
            this.Enter_pic.Size = new System.Drawing.Size(186, 42);
            this.Enter_pic.TabIndex = 0;
            this.Enter_pic.Text = "For Enter Picture";
            this.Enter_pic.TextColor = System.Drawing.Color.White;
            this.Enter_pic.UseMnemonic = false;
            this.Enter_pic.UseVisualStyleBackColor = false;
            this.Enter_pic.Click += new System.EventHandler(this.Enter_Pic_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BackColor = System.Drawing.Color.Gold;
            this.button_WOC1.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC1.ButtonColor = System.Drawing.Color.Black;
            this.button_WOC1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_WOC1.Location = new System.Drawing.Point(0, 474);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC1.Size = new System.Drawing.Size(186, 42);
            this.button_WOC1.TabIndex = 6;
            this.button_WOC1.Text = "<<";
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.UseMnemonic = false;
            this.button_WOC1.UseVisualStyleBackColor = false;
            this.button_WOC1.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // button_WOC2
            // 
            this.button_WOC2.BackColor = System.Drawing.Color.Gold;
            this.button_WOC2.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC2.ButtonColor = System.Drawing.Color.Black;
            this.button_WOC2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_WOC2.Location = new System.Drawing.Point(231, 474);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC2.Size = new System.Drawing.Size(186, 42);
            this.button_WOC2.TabIndex = 6;
            this.button_WOC2.Text = "Play ►";
            this.button_WOC2.TextColor = System.Drawing.Color.White;
            this.button_WOC2.UseMnemonic = false;
            this.button_WOC2.UseVisualStyleBackColor = false;
            this.button_WOC2.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // button_WOC3
            // 
            this.button_WOC3.BackColor = System.Drawing.Color.Gold;
            this.button_WOC3.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC3.ButtonColor = System.Drawing.Color.Black;
            this.button_WOC3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button_WOC3.Location = new System.Drawing.Point(456, 474);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.White;
            this.button_WOC3.Size = new System.Drawing.Size(204, 42);
            this.button_WOC3.TabIndex = 6;
            this.button_WOC3.Text = ">>";
            this.button_WOC3.TextColor = System.Drawing.Color.White;
            this.button_WOC3.UseMnemonic = false;
            this.button_WOC3.UseVisualStyleBackColor = false;
            this.button_WOC3.Click += new System.EventHandler(this.button_WOC3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 681);
            this.ControlBox = false;
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.All_Pic);
            this.Controls.Add(this.Multiple_Pic);
            this.Controls.Add(this.One_Pic);
            this.Controls.Add(this.Enter_pic);
            this.ForeColor = System.Drawing.Color.SkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Location = new System.Drawing.Point(975, 552);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1200, 657);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ePOSOne.btnProduct.Button_WOC Enter_pic;
        private ePOSOne.btnProduct.Button_WOC One_Pic;
        private ePOSOne.btnProduct.Button_WOC Multiple_Pic;
        private ePOSOne.btnProduct.Button_WOC All_Pic;
        private ePOSOne.btnProduct.Button_WOC Close_button;
        private RoundedPanel roundedPanel1;
        private RoundedPanel roundedPanel2;
        private RoundedPanel roundedPanel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private ePOSOne.btnProduct.Button_WOC button_WOC3;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
    }
}

