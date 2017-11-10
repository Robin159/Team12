namespace Mitarbeiterverwaltung
{
    partial class Datenbank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Datenbank));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Beenden = new System.Windows.Forms.Button();
            this.lbl_datenübersicht = new System.Windows.Forms.Label();
            this.btn_Beenden = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mitarbeiterDataSet1 = new Mitarbeiterverwaltung.MitarbeiterDataSet();
            this.mitarbeiterDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(55, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1041, 515);
            this.dataGridView1.TabIndex = 0;
            // 
            // Beenden
            // 
            this.Beenden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.Beenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Beenden.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beenden.Location = new System.Drawing.Point(12, 645);
            this.Beenden.Name = "Beenden";
            this.Beenden.Size = new System.Drawing.Size(131, 36);
            this.Beenden.TabIndex = 1;
            this.Beenden.Text = "Zurück";
            this.Beenden.UseVisualStyleBackColor = false;
            // 
            // lbl_datenübersicht
            // 
            this.lbl_datenübersicht.AutoSize = true;
            this.lbl_datenübersicht.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datenübersicht.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.lbl_datenübersicht.Location = new System.Drawing.Point(447, 32);
            this.lbl_datenübersicht.Name = "lbl_datenübersicht";
            this.lbl_datenübersicht.Size = new System.Drawing.Size(246, 37);
            this.lbl_datenübersicht.TabIndex = 3;
            this.lbl_datenübersicht.Text = "Datenübersicht";
            // 
            // btn_Beenden
            // 
            this.btn_Beenden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(0)))));
            this.btn_Beenden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Beenden.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Beenden.Location = new System.Drawing.Point(1015, 645);
            this.btn_Beenden.Name = "btn_Beenden";
            this.btn_Beenden.Size = new System.Drawing.Size(129, 36);
            this.btn_Beenden.TabIndex = 4;
            this.btn_Beenden.Text = "Beenden";
            this.btn_Beenden.UseVisualStyleBackColor = false;
            this.btn_Beenden.Click += new System.EventHandler(this.btn_Beenden_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 77);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // mitarbeiterDataSet1
            // 
            this.mitarbeiterDataSet1.DataSetName = "MitarbeiterDataSet";
            this.mitarbeiterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mitarbeiterDataSet1BindingSource
            // 
            this.mitarbeiterDataSet1BindingSource.DataSource = this.mitarbeiterDataSet1;
            this.mitarbeiterDataSet1BindingSource.Position = 0;
            // 
            // Datenbank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1156, 693);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Beenden);
            this.Controls.Add(this.lbl_datenübersicht);
            this.Controls.Add(this.Beenden);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Datenbank";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Load += new System.EventHandler(this.Datenbank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mitarbeiterDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Beenden;
        private System.Windows.Forms.Label lbl_datenübersicht;
        private System.Windows.Forms.Button btn_Beenden;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MitarbeiterDataSet mitarbeiterDataSet1;
        private System.Windows.Forms.BindingSource mitarbeiterDataSet1BindingSource;
    }
}