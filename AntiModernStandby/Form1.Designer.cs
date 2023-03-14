
namespace AntiModernStandby
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButtonNone = new System.Windows.Forms.RadioButton();
            this.radioButtonSystemRequired = new System.Windows.Forms.RadioButton();
            this.radioButtonDisplayRequired = new System.Windows.Forms.RadioButton();
            this.radioButtonDisplayRequiredMouseMove = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonNone
            // 
            this.radioButtonNone.AutoSize = true;
            this.radioButtonNone.Checked = true;
            this.radioButtonNone.Location = new System.Drawing.Point(12, 12);
            this.radioButtonNone.Name = "radioButtonNone";
            this.radioButtonNone.Size = new System.Drawing.Size(80, 29);
            this.radioButtonNone.TabIndex = 2;
            this.radioButtonNone.TabStop = true;
            this.radioButtonNone.Text = "None";
            this.radioButtonNone.UseVisualStyleBackColor = true;
            this.radioButtonNone.CheckedChanged += new System.EventHandler(this.radioButtonNone_CheckedChanged);
            // 
            // radioButtonSystemRequired
            // 
            this.radioButtonSystemRequired.AutoSize = true;
            this.radioButtonSystemRequired.Location = new System.Drawing.Point(12, 47);
            this.radioButtonSystemRequired.Name = "radioButtonSystemRequired";
            this.radioButtonSystemRequired.Size = new System.Drawing.Size(192, 29);
            this.radioButtonSystemRequired.TabIndex = 3;
            this.radioButtonSystemRequired.Text = "SYSTEM_REQUIRED";
            this.radioButtonSystemRequired.UseVisualStyleBackColor = true;
            this.radioButtonSystemRequired.CheckedChanged += new System.EventHandler(this.radioButtonSystemRequired_CheckedChanged);
            // 
            // radioButtonDisplayRequired
            // 
            this.radioButtonDisplayRequired.AutoSize = true;
            this.radioButtonDisplayRequired.Location = new System.Drawing.Point(12, 82);
            this.radioButtonDisplayRequired.Name = "radioButtonDisplayRequired";
            this.radioButtonDisplayRequired.Size = new System.Drawing.Size(195, 29);
            this.radioButtonDisplayRequired.TabIndex = 4;
            this.radioButtonDisplayRequired.Text = "DISPLAY_REQUIRED";
            this.radioButtonDisplayRequired.UseVisualStyleBackColor = true;
            this.radioButtonDisplayRequired.CheckedChanged += new System.EventHandler(this.radioButtonDisplayRequired_CheckedChanged);
            // 
            // radioButtonDisplayRequiredMouseMove
            // 
            this.radioButtonDisplayRequiredMouseMove.AutoSize = true;
            this.radioButtonDisplayRequiredMouseMove.Location = new System.Drawing.Point(12, 117);
            this.radioButtonDisplayRequiredMouseMove.Name = "radioButtonDisplayRequiredMouseMove";
            this.radioButtonDisplayRequiredMouseMove.Size = new System.Drawing.Size(320, 29);
            this.radioButtonDisplayRequiredMouseMove.TabIndex = 4;
            this.radioButtonDisplayRequiredMouseMove.Text = "DISPLAY_REQUIRED_MOUSE_MOVE";
            this.radioButtonDisplayRequiredMouseMove.UseVisualStyleBackColor = true;
            this.radioButtonDisplayRequiredMouseMove.CheckedChanged += new System.EventHandler(this.radioButtonDisplayRequiredMouseMove_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 177);
            this.Controls.Add(this.radioButtonDisplayRequiredMouseMove);
            this.Controls.Add(this.radioButtonDisplayRequired);
            this.Controls.Add(this.radioButtonNone);
            this.Controls.Add(this.radioButtonSystemRequired);
            this.Name = "FormMain";
            this.Text = "AntiModernStandby";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButtonNone;
        private System.Windows.Forms.RadioButton radioButtonSystemRequired;
        private System.Windows.Forms.RadioButton radioButtonDisplayRequired;
        private System.Windows.Forms.RadioButton radioButtonDisplayRequiredMouseMove;
    }
}

