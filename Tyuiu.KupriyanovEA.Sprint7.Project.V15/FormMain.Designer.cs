
namespace Tyuiu.KupriyanovEA.Sprint7.Project.V15
{
    partial class FormMain
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
            this.menuStrip_KUE = new System.Windows.Forms.MenuStrip();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem_KUE = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem_KUE = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem_KUE = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem_KUE = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem_KUE = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem_KUE = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTable_KUE = new System.Windows.Forms.DataGridView();
            this.groupBoxMoves_KUE = new System.Windows.Forms.GroupBox();
            this.buttonOpen_KUE = new System.Windows.Forms.Button();
            this.buttonInfo_KUE = new System.Windows.Forms.Button();
            this.buttonAdd_KUE = new System.Windows.Forms.Button();
            this.buttonDownload_KUE = new System.Windows.Forms.Button();
            this.saveFileDialogTable_KUE = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogTable_KUE = new System.Windows.Forms.OpenFileDialog();
            this.Book_KUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year_KUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor_KUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address_KUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip_KUE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KUE)).BeginInit();
            this.groupBoxMoves_KUE.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_KUE
            // 
            this.menuStrip_KUE.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_KUE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.действияToolStripMenuItem,
            this.aboutProgramToolStripMenuItem_KUE,
            this.exitToolStripMenuItem_KUE});
            this.menuStrip_KUE.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_KUE.Name = "menuStrip_KUE";
            this.menuStrip_KUE.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip_KUE.Size = new System.Drawing.Size(861, 24);
            this.menuStrip_KUE.TabIndex = 0;
            this.menuStrip_KUE.Text = "menuStrip1";
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem_KUE,
            this.saveToolStripMenuItem_KUE,
            this.addToolStripMenuItem_KUE,
            this.infoToolStripMenuItem_KUE});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.действияToolStripMenuItem.Text = "Действия";
            // 
            // openToolStripMenuItem_KUE
            // 
            this.openToolStripMenuItem_KUE.Name = "openToolStripMenuItem_KUE";
            this.openToolStripMenuItem_KUE.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem_KUE.Text = "Открыть";
            // 
            // saveToolStripMenuItem_KUE
            // 
            this.saveToolStripMenuItem_KUE.Name = "saveToolStripMenuItem_KUE";
            this.saveToolStripMenuItem_KUE.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem_KUE.Text = "Сохранить";
            // 
            // addToolStripMenuItem_KUE
            // 
            this.addToolStripMenuItem_KUE.Name = "addToolStripMenuItem_KUE";
            this.addToolStripMenuItem_KUE.Size = new System.Drawing.Size(180, 22);
            this.addToolStripMenuItem_KUE.Text = "Добавить";
            // 
            // infoToolStripMenuItem_KUE
            // 
            this.infoToolStripMenuItem_KUE.Name = "infoToolStripMenuItem_KUE";
            this.infoToolStripMenuItem_KUE.Size = new System.Drawing.Size(180, 22);
            this.infoToolStripMenuItem_KUE.Text = "Инфо";
            // 
            // aboutProgramToolStripMenuItem_KUE
            // 
            this.aboutProgramToolStripMenuItem_KUE.Name = "aboutProgramToolStripMenuItem_KUE";
            this.aboutProgramToolStripMenuItem_KUE.Size = new System.Drawing.Size(94, 20);
            this.aboutProgramToolStripMenuItem_KUE.Text = "О программе";
            this.aboutProgramToolStripMenuItem_KUE.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_KUE_Click);
            // 
            // exitToolStripMenuItem_KUE
            // 
            this.exitToolStripMenuItem_KUE.Name = "exitToolStripMenuItem_KUE";
            this.exitToolStripMenuItem_KUE.Size = new System.Drawing.Size(54, 20);
            this.exitToolStripMenuItem_KUE.Text = "Выход";
            this.exitToolStripMenuItem_KUE.Click += new System.EventHandler(this.exitToolStripMenuItem_KUE_Click);
            // 
            // dataGridViewTable_KUE
            // 
            this.dataGridViewTable_KUE.AllowUserToAddRows = false;
            this.dataGridViewTable_KUE.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewTable_KUE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTable_KUE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable_KUE.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_KUE,
            this.Year_KUE,
            this.Autor_KUE,
            this.Address_KUE});
            this.dataGridViewTable_KUE.Location = new System.Drawing.Point(9, 25);
            this.dataGridViewTable_KUE.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTable_KUE.Name = "dataGridViewTable_KUE";
            this.dataGridViewTable_KUE.RowHeadersWidth = 51;
            this.dataGridViewTable_KUE.RowTemplate.Height = 24;
            this.dataGridViewTable_KUE.Size = new System.Drawing.Size(658, 364);
            this.dataGridViewTable_KUE.TabIndex = 1;
            this.dataGridViewTable_KUE.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dataGridViewTable_KUE_RowPrePaint);
            // 
            // groupBoxMoves_KUE
            // 
            this.groupBoxMoves_KUE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxMoves_KUE.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBoxMoves_KUE.Controls.Add(this.buttonOpen_KUE);
            this.groupBoxMoves_KUE.Controls.Add(this.buttonInfo_KUE);
            this.groupBoxMoves_KUE.Controls.Add(this.buttonAdd_KUE);
            this.groupBoxMoves_KUE.Controls.Add(this.buttonDownload_KUE);
            this.groupBoxMoves_KUE.Location = new System.Drawing.Point(672, 25);
            this.groupBoxMoves_KUE.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMoves_KUE.Name = "groupBoxMoves_KUE";
            this.groupBoxMoves_KUE.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxMoves_KUE.Size = new System.Drawing.Size(180, 364);
            this.groupBoxMoves_KUE.TabIndex = 2;
            this.groupBoxMoves_KUE.TabStop = false;
            this.groupBoxMoves_KUE.Text = "Действия";
            // 
            // buttonOpen_KUE
            // 
            this.buttonOpen_KUE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOpen_KUE.Location = new System.Drawing.Point(4, 58);
            this.buttonOpen_KUE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen_KUE.Name = "buttonOpen_KUE";
            this.buttonOpen_KUE.Size = new System.Drawing.Size(170, 39);
            this.buttonOpen_KUE.TabIndex = 0;
            this.buttonOpen_KUE.Text = "Открыть базу";
            this.buttonOpen_KUE.UseVisualStyleBackColor = true;
            this.buttonOpen_KUE.Click += new System.EventHandler(this.buttonOpen_KUE_Click);
            // 
            // buttonInfo_KUE
            // 
            this.buttonInfo_KUE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_KUE.Location = new System.Drawing.Point(4, 190);
            this.buttonInfo_KUE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonInfo_KUE.Name = "buttonInfo_KUE";
            this.buttonInfo_KUE.Size = new System.Drawing.Size(170, 39);
            this.buttonInfo_KUE.TabIndex = 0;
            this.buttonInfo_KUE.Text = "Информация о разработчике";
            this.buttonInfo_KUE.UseVisualStyleBackColor = true;
            this.buttonInfo_KUE.Click += new System.EventHandler(this.buttonInfo_KUE_Click);
            // 
            // buttonAdd_KUE
            // 
            this.buttonAdd_KUE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd_KUE.Location = new System.Drawing.Point(4, 146);
            this.buttonAdd_KUE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd_KUE.Name = "buttonAdd_KUE";
            this.buttonAdd_KUE.Size = new System.Drawing.Size(170, 39);
            this.buttonAdd_KUE.TabIndex = 0;
            this.buttonAdd_KUE.Text = "Добавить строку";
            this.buttonAdd_KUE.UseVisualStyleBackColor = true;
            this.buttonAdd_KUE.Click += new System.EventHandler(this.buttonAdd_KUE_Click);
            // 
            // buttonDownload_KUE
            // 
            this.buttonDownload_KUE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownload_KUE.Location = new System.Drawing.Point(4, 102);
            this.buttonDownload_KUE.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDownload_KUE.Name = "buttonDownload_KUE";
            this.buttonDownload_KUE.Size = new System.Drawing.Size(170, 39);
            this.buttonDownload_KUE.TabIndex = 0;
            this.buttonDownload_KUE.Text = "Сохранить базу";
            this.buttonDownload_KUE.UseVisualStyleBackColor = true;
            this.buttonDownload_KUE.Click += new System.EventHandler(this.buttonDownload_KUE_Click);
            // 
            // openFileDialogTable_KUE
            // 
            this.openFileDialogTable_KUE.FileName = "openFileDialog1";
            // 
            // Book_KUE
            // 
            this.Book_KUE.HeaderText = "ФИО";
            this.Book_KUE.MinimumWidth = 6;
            this.Book_KUE.Name = "Book_KUE";
            // 
            // Year_KUE
            // 
            this.Year_KUE.HeaderText = "Телефон";
            this.Year_KUE.MinimumWidth = 6;
            this.Year_KUE.Name = "Year_KUE";
            // 
            // Autor_KUE
            // 
            this.Autor_KUE.HeaderText = "Номер";
            this.Autor_KUE.MinimumWidth = 6;
            this.Autor_KUE.Name = "Autor_KUE";
            // 
            // Address_KUE
            // 
            this.Address_KUE.HeaderText = "Адрес";
            this.Address_KUE.Name = "Address_KUE";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 399);
            this.Controls.Add(this.groupBoxMoves_KUE);
            this.Controls.Add(this.dataGridViewTable_KUE);
            this.Controls.Add(this.menuStrip_KUE);
            this.MainMenuStrip = this.menuStrip_KUE;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Договорная деятельность организации";
            this.menuStrip_KUE.ResumeLayout(false);
            this.menuStrip_KUE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable_KUE)).EndInit();
            this.groupBoxMoves_KUE.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_KUE;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem_KUE;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem_KUE;
        private System.Windows.Forms.DataGridView dataGridViewTable_KUE;
        private System.Windows.Forms.GroupBox groupBoxMoves_KUE;
        private System.Windows.Forms.Button buttonOpen_KUE;
        private System.Windows.Forms.Button buttonInfo_KUE;
        private System.Windows.Forms.Button buttonAdd_KUE;
        private System.Windows.Forms.Button buttonDownload_KUE;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem_KUE;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem_KUE;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem_KUE;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem_KUE;
        private System.Windows.Forms.SaveFileDialog saveFileDialogTable_KUE;
        private System.Windows.Forms.OpenFileDialog openFileDialogTable_KUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_KUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Year_KUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autor_KUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address_KUE;
    }
}

