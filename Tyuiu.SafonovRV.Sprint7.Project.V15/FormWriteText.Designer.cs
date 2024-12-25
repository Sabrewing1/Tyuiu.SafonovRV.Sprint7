
namespace Tyuiu.SafonovRV.Sprint7.Project.V15
{
    partial class FormWriteText
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
            this.textBoxLabelColumn_KUE = new System.Windows.Forms.TextBox();
            this.textBoxInputLabelColumn_KUE = new System.Windows.Forms.TextBox();
            this.buttonOK_KUE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLabelColumn_KUE
            // 
            this.textBoxLabelColumn_KUE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLabelColumn_KUE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLabelColumn_KUE.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLabelColumn_KUE.Location = new System.Drawing.Point(0, 0);
            this.textBoxLabelColumn_KUE.Name = "textBoxLabelColumn_KUE";
            this.textBoxLabelColumn_KUE.ReadOnly = true;
            this.textBoxLabelColumn_KUE.Size = new System.Drawing.Size(273, 24);
            this.textBoxLabelColumn_KUE.TabIndex = 0;
            this.textBoxLabelColumn_KUE.TabStop = false;
            this.textBoxLabelColumn_KUE.Text = "Введите название столбца";
            this.textBoxLabelColumn_KUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxInputLabelColumn_KUE
            // 
            this.textBoxInputLabelColumn_KUE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxInputLabelColumn_KUE.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInputLabelColumn_KUE.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputLabelColumn_KUE.Location = new System.Drawing.Point(16, 38);
            this.textBoxInputLabelColumn_KUE.Name = "textBoxInputLabelColumn_KUE";
            this.textBoxInputLabelColumn_KUE.Size = new System.Drawing.Size(245, 18);
            this.textBoxInputLabelColumn_KUE.TabIndex = 1;
            this.textBoxInputLabelColumn_KUE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonOK_KUE
            // 
            this.buttonOK_KUE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonOK_KUE.Location = new System.Drawing.Point(174, 71);
            this.buttonOK_KUE.Name = "buttonOK_KUE";
            this.buttonOK_KUE.Size = new System.Drawing.Size(87, 27);
            this.buttonOK_KUE.TabIndex = 2;
            this.buttonOK_KUE.Text = "OK";
            this.buttonOK_KUE.UseVisualStyleBackColor = false;
            this.buttonOK_KUE.Click += new System.EventHandler(this.buttonOK_KUE_Click);
            // 
            // FormWriteText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 104);
            this.Controls.Add(this.buttonOK_KUE);
            this.Controls.Add(this.textBoxInputLabelColumn_KUE);
            this.Controls.Add(this.textBoxLabelColumn_KUE);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormWriteText";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLabelColumn_KUE;
        private System.Windows.Forms.TextBox textBoxInputLabelColumn_KUE;
        private System.Windows.Forms.Button buttonOK_KUE;
    }
}