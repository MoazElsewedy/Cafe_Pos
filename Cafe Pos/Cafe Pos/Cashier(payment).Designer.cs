namespace Cafe_Pos
{
    partial class Cashier_payment_
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SalesHistory_dataGridView = new System.Windows.Forms.DataGridView();
            this.SalesHistory_label = new System.Windows.Forms.Label();
            this.AddMaterial_but = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SalesHistory_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SalesHistory_dataGridView
            // 
            this.SalesHistory_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.SalesHistory_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesHistory_dataGridView.Location = new System.Drawing.Point(37, 93);
            this.SalesHistory_dataGridView.Name = "SalesHistory_dataGridView";
            this.SalesHistory_dataGridView.RowHeadersWidth = 51;
            this.SalesHistory_dataGridView.RowTemplate.Height = 24;
            this.SalesHistory_dataGridView.Size = new System.Drawing.Size(1629, 746);
            this.SalesHistory_dataGridView.TabIndex = 9;
            // 
            // SalesHistory_label
            // 
            this.SalesHistory_label.AutoSize = true;
            this.SalesHistory_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesHistory_label.Location = new System.Drawing.Point(29, 31);
            this.SalesHistory_label.Name = "SalesHistory_label";
            this.SalesHistory_label.Size = new System.Drawing.Size(244, 44);
            this.SalesHistory_label.TabIndex = 10;
            this.SalesHistory_label.Text = "Sales History";
            // 
            // AddMaterial_but
            // 
            this.AddMaterial_but.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.AddMaterial_but.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.AddMaterial_but.FlatAppearance.BorderSize = 0;
            this.AddMaterial_but.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.AddMaterial_but.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(128)))), ((int)(((byte)(25)))));
            this.AddMaterial_but.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMaterial_but.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMaterial_but.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.AddMaterial_but.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddMaterial_but.Location = new System.Drawing.Point(1469, 10);
            this.AddMaterial_but.Name = "AddMaterial_but";
            this.AddMaterial_but.Size = new System.Drawing.Size(197, 65);
            this.AddMaterial_but.TabIndex = 20;
            this.AddMaterial_but.Text = "Filters";
            this.AddMaterial_but.UseVisualStyleBackColor = false;
            // 
            // Cashier_payment_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(158)))));
            this.Controls.Add(this.AddMaterial_but);
            this.Controls.Add(this.SalesHistory_label);
            this.Controls.Add(this.SalesHistory_dataGridView);
            this.Name = "Cashier_payment_";
            this.Size = new System.Drawing.Size(1702, 933);
            ((System.ComponentModel.ISupportInitialize)(this.SalesHistory_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SalesHistory_dataGridView;
        private System.Windows.Forms.Label SalesHistory_label;
        private System.Windows.Forms.Button AddMaterial_but;
    }
}
