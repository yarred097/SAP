
namespace SAP
{
    partial class FrmLogIn
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
            this.pnlB = new System.Windows.Forms.Panel();
            this.pnlD = new System.Windows.Forms.Panel();
            this.btnAcced = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.pnlU = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlB.SuspendLayout();
            this.pnlD.SuspendLayout();
            this.pnlU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlB
            // 
            this.pnlB.Controls.Add(this.pnlD);
            this.pnlB.Controls.Add(this.pnlU);
            this.pnlB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlB.Location = new System.Drawing.Point(0, 0);
            this.pnlB.Name = "pnlB";
            this.pnlB.Size = new System.Drawing.Size(294, 381);
            this.pnlB.TabIndex = 0;
            // 
            // pnlD
            // 
            this.pnlD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(126)))));
            this.pnlD.Controls.Add(this.btnAcced);
            this.pnlD.Controls.Add(this.txtPass);
            this.pnlD.Controls.Add(this.txtUser);
            this.pnlD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlD.Location = new System.Drawing.Point(0, 179);
            this.pnlD.Name = "pnlD";
            this.pnlD.Size = new System.Drawing.Size(294, 202);
            this.pnlD.TabIndex = 1;
            // 
            // btnAcced
            // 
            this.btnAcced.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAcced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.btnAcced.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAcced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcced.ForeColor = System.Drawing.Color.Silver;
            this.btnAcced.Location = new System.Drawing.Point(79, 123);
            this.btnAcced.Name = "btnAcced";
            this.btnAcced.Size = new System.Drawing.Size(146, 30);
            this.btnAcced.TabIndex = 0;
            this.btnAcced.Text = "ACCEDER";
            this.btnAcced.UseVisualStyleBackColor = false;
            this.btnAcced.Click += new System.EventHandler(this.btnAcced_Click);
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(126)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Silver;
            this.txtPass.Location = new System.Drawing.Point(59, 83);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(184, 22);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "Contraseña";
            this.txtPass.Enter += new System.EventHandler(this.txtPass_Enter);
            // 
            // txtUser
            // 
            this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(126)))));
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Silver;
            this.txtUser.Location = new System.Drawing.Point(59, 55);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(184, 22);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Usuario";
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            // 
            // pnlU
            // 
            this.pnlU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.pnlU.Controls.Add(this.pictureBox1);
            this.pnlU.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlU.Location = new System.Drawing.Point(0, 0);
            this.pnlU.Name = "pnlU";
            this.pnlU.Size = new System.Drawing.Size(294, 181);
            this.pnlU.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::SAP.Properties.Resources.controlar;
            this.pictureBox1.Location = new System.Drawing.Point(78, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 381);
            this.Controls.Add(this.pnlB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INICIAR SESION";
            this.pnlB.ResumeLayout(false);
            this.pnlD.ResumeLayout(false);
            this.pnlD.PerformLayout();
            this.pnlU.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlB;
        private System.Windows.Forms.Panel pnlD;
        private System.Windows.Forms.Panel pnlU;
        private System.Windows.Forms.Button btnAcced;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

