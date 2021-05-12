
namespace SAP.VIEW
{
    partial class FrmMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pleft = new System.Windows.Forms.Panel();
            this.pCenter = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnInventory = new System.Windows.Forms.Button();
            this.pInventory = new System.Windows.Forms.Panel();
            this.btnEPQ = new System.Windows.Forms.Button();
            this.btnEoq = new System.Windows.Forms.Button();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pleft.SuspendLayout();
            this.pMenu.SuspendLayout();
            this.pInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Name = "contextMenuStrip4";
            this.contextMenuStrip4.Size = new System.Drawing.Size(61, 4);
            // 
            // pleft
            // 
            this.pleft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.pleft.Controls.Add(this.pMenu);
            this.pleft.Controls.Add(this.button1);
            this.pleft.Controls.Add(this.pbLogo);
            this.pleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pleft.Location = new System.Drawing.Point(0, 0);
            this.pleft.Name = "pleft";
            this.pleft.Size = new System.Drawing.Size(200, 428);
            this.pleft.TabIndex = 6;
            // 
            // pCenter
            // 
            this.pCenter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(126)))));
            this.pCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCenter.Location = new System.Drawing.Point(200, 0);
            this.pCenter.Name = "pCenter";
            this.pCenter.Size = new System.Drawing.Size(600, 428);
            this.pCenter.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(72)))), ((int)(((byte)(105)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(96)))), ((int)(((byte)(126)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(170, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.pInventory);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMenu.Location = new System.Drawing.Point(0, 170);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(200, 210);
            this.pMenu.TabIndex = 1;
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.Location = new System.Drawing.Point(0, 0);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(200, 30);
            this.btnInventory.TabIndex = 0;
            this.btnInventory.Text = "Control de Inventario";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // pInventory
            // 
            this.pInventory.Controls.Add(this.btnEPQ);
            this.pInventory.Controls.Add(this.btnEoq);
            this.pInventory.Controls.Add(this.btnInventory);
            this.pInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInventory.Location = new System.Drawing.Point(0, 0);
            this.pInventory.Name = "pInventory";
            this.pInventory.Size = new System.Drawing.Size(200, 150);
            this.pInventory.TabIndex = 2;
            // 
            // btnEPQ
            // 
            this.btnEPQ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEPQ.Location = new System.Drawing.Point(0, 60);
            this.btnEPQ.Name = "btnEPQ";
            this.btnEPQ.Size = new System.Drawing.Size(200, 30);
            this.btnEPQ.TabIndex = 3;
            this.btnEPQ.Text = "Modelo EPQ";
            this.btnEPQ.UseVisualStyleBackColor = true;
            // 
            // btnEoq
            // 
            this.btnEoq.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEoq.Location = new System.Drawing.Point(0, 30);
            this.btnEoq.Name = "btnEoq";
            this.btnEoq.Size = new System.Drawing.Size(200, 30);
            this.btnEoq.TabIndex = 2;
            this.btnEoq.Text = "Modelo EOQ";
            this.btnEoq.UseVisualStyleBackColor = true;
            this.btnEoq.Click += new System.EventHandler(this.btnEoq_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::SAP.Properties.Resources.controlar;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 170);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pCenter);
            this.Controls.Add(this.pleft);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Administracion de la Produccion SAP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pleft.ResumeLayout(false);
            this.pMenu.ResumeLayout(false);
            this.pInventory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.Panel pleft;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel pCenter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Panel pInventory;
        private System.Windows.Forms.Button btnEPQ;
        private System.Windows.Forms.Button btnEoq;
    }
}