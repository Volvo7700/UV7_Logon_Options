
namespace UV7_Logon_Options
{
    partial class Form_main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_sleep = new System.Windows.Forms.Label();
            this.label_hibernate = new System.Windows.Forms.Label();
            this.label_shutdown = new System.Windows.Forms.Label();
            this.label_restart = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_easeOfAccess = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.imageButton_sleep = new UV7_Logon_Options.ImageButton();
            this.imageButton_hibernate = new UV7_Logon_Options.ImageButton();
            this.imageButton_shutdown = new UV7_Logon_Options.ImageButton();
            this.imageButton_restart = new UV7_Logon_Options.ImageButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_sleep
            // 
            this.label_sleep.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_sleep.ForeColor = System.Drawing.Color.White;
            this.label_sleep.Location = new System.Drawing.Point(3, 87);
            this.label_sleep.Name = "label_sleep";
            this.label_sleep.Size = new System.Drawing.Size(90, 30);
            this.label_sleep.TabIndex = 4;
            this.label_sleep.Text = "Energie sparen";
            this.label_sleep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_hibernate
            // 
            this.label_hibernate.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_hibernate.ForeColor = System.Drawing.Color.White;
            this.label_hibernate.Location = new System.Drawing.Point(99, 87);
            this.label_hibernate.Name = "label_hibernate";
            this.label_hibernate.Size = new System.Drawing.Size(90, 30);
            this.label_hibernate.TabIndex = 5;
            this.label_hibernate.Text = "Ruhezustand";
            this.label_hibernate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_shutdown
            // 
            this.label_shutdown.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_shutdown.ForeColor = System.Drawing.Color.White;
            this.label_shutdown.Location = new System.Drawing.Point(195, 87);
            this.label_shutdown.Name = "label_shutdown";
            this.label_shutdown.Size = new System.Drawing.Size(90, 30);
            this.label_shutdown.TabIndex = 6;
            this.label_shutdown.Text = "Herunterfahren";
            this.label_shutdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_restart
            // 
            this.label_restart.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_restart.ForeColor = System.Drawing.Color.White;
            this.label_restart.Location = new System.Drawing.Point(291, 87);
            this.label_restart.Name = "label_restart";
            this.label_restart.Size = new System.Drawing.Size(90, 30);
            this.label_restart.TabIndex = 7;
            this.label_restart.Text = "Neu starten";
            this.label_restart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(387, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Erleichterte Bedienung";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_easeOfAccess
            // 
            this.button_easeOfAccess.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_easeOfAccess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.button_easeOfAccess.FlatAppearance.BorderSize = 0;
            this.button_easeOfAccess.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_easeOfAccess.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_easeOfAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_easeOfAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_easeOfAccess.Image = global::UV7_Logon_Options.Properties.Resources.EaseOfAccess;
            this.button_easeOfAccess.Location = new System.Drawing.Point(387, 34);
            this.button_easeOfAccess.Name = "button_easeOfAccess";
            this.button_easeOfAccess.Size = new System.Drawing.Size(94, 50);
            this.button_easeOfAccess.TabIndex = 8;
            this.button_easeOfAccess.UseVisualStyleBackColor = true;
            this.button_easeOfAccess.Click += new System.EventHandler(this.EaseOfAccess);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.imageButton_sleep, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_sleep, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_easeOfAccess, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton_hibernate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_restart, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_hibernate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_shutdown, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.imageButton_shutdown, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.imageButton_restart, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.54546F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(484, 161);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // imageButton_sleep
            // 
            this.imageButton_sleep.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imageButton_sleep.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.imageButton_sleep.FlatAppearance.BorderSize = 0;
            this.imageButton_sleep.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.imageButton_sleep.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.imageButton_sleep.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.imageButton_sleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageButton_sleep.HoverImage = global::UV7_Logon_Options.Properties.Resources.HibernateHover;
            this.imageButton_sleep.Image = global::UV7_Logon_Options.Properties.Resources.HibernateNormal;
            this.imageButton_sleep.Location = new System.Drawing.Point(3, 34);
            this.imageButton_sleep.Name = "imageButton_sleep";
            this.imageButton_sleep.NormalImage = global::UV7_Logon_Options.Properties.Resources.HibernateNormal;
            this.imageButton_sleep.PressedImage = global::UV7_Logon_Options.Properties.Resources.HibernatePressed;
            this.imageButton_sleep.Size = new System.Drawing.Size(90, 50);
            this.imageButton_sleep.TabIndex = 0;
            this.imageButton_sleep.UseVisualStyleBackColor = true;
            this.imageButton_sleep.Click += new System.EventHandler(this.Sleep);
            // 
            // imageButton_hibernate
            // 
            this.imageButton_hibernate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imageButton_hibernate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.imageButton_hibernate.FlatAppearance.BorderSize = 0;
            this.imageButton_hibernate.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.imageButton_hibernate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.imageButton_hibernate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.imageButton_hibernate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageButton_hibernate.HoverImage = global::UV7_Logon_Options.Properties.Resources.HibernateHover;
            this.imageButton_hibernate.Image = global::UV7_Logon_Options.Properties.Resources.HibernateNormal;
            this.imageButton_hibernate.Location = new System.Drawing.Point(99, 34);
            this.imageButton_hibernate.Name = "imageButton_hibernate";
            this.imageButton_hibernate.NormalImage = global::UV7_Logon_Options.Properties.Resources.HibernateNormal;
            this.imageButton_hibernate.PressedImage = global::UV7_Logon_Options.Properties.Resources.HibernatePressed;
            this.imageButton_hibernate.Size = new System.Drawing.Size(90, 50);
            this.imageButton_hibernate.TabIndex = 1;
            this.imageButton_hibernate.UseVisualStyleBackColor = true;
            this.imageButton_hibernate.Click += new System.EventHandler(this.Hibernate);
            // 
            // imageButton_shutdown
            // 
            this.imageButton_shutdown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imageButton_shutdown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.imageButton_shutdown.FlatAppearance.BorderSize = 0;
            this.imageButton_shutdown.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.imageButton_shutdown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.imageButton_shutdown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.imageButton_shutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageButton_shutdown.HoverImage = global::UV7_Logon_Options.Properties.Resources.ShutdownHover;
            this.imageButton_shutdown.Image = global::UV7_Logon_Options.Properties.Resources.ShutdownNormal;
            this.imageButton_shutdown.Location = new System.Drawing.Point(195, 34);
            this.imageButton_shutdown.Name = "imageButton_shutdown";
            this.imageButton_shutdown.NormalImage = global::UV7_Logon_Options.Properties.Resources.ShutdownNormal;
            this.imageButton_shutdown.PressedImage = global::UV7_Logon_Options.Properties.Resources.ShutdownPressed;
            this.imageButton_shutdown.Size = new System.Drawing.Size(90, 50);
            this.imageButton_shutdown.TabIndex = 2;
            this.imageButton_shutdown.UseVisualStyleBackColor = true;
            this.imageButton_shutdown.Click += new System.EventHandler(this.Shutdown);
            // 
            // imageButton_restart
            // 
            this.imageButton_restart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.imageButton_restart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.imageButton_restart.FlatAppearance.BorderSize = 0;
            this.imageButton_restart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.imageButton_restart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.imageButton_restart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.imageButton_restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imageButton_restart.HoverImage = global::UV7_Logon_Options.Properties.Resources.RestartHover;
            this.imageButton_restart.Image = global::UV7_Logon_Options.Properties.Resources.RestartNormal;
            this.imageButton_restart.Location = new System.Drawing.Point(291, 34);
            this.imageButton_restart.Name = "imageButton_restart";
            this.imageButton_restart.NormalImage = global::UV7_Logon_Options.Properties.Resources.RestartNormal;
            this.imageButton_restart.PressedImage = global::UV7_Logon_Options.Properties.Resources.RestartPressed;
            this.imageButton_restart.Size = new System.Drawing.Size(90, 50);
            this.imageButton_restart.TabIndex = 3;
            this.imageButton_restart.UseVisualStyleBackColor = true;
            this.imageButton_restart.Click += new System.EventHandler(this.Restart);
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(484, 161);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "Form_main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logon-Optionen";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_main_KeyDown);
            this.Leave += new System.EventHandler(this.Form_main_Leave);
            this.MouseLeave += new System.EventHandler(this.Form_main_MouseLeave);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ImageButton imageButton_sleep;
        private ImageButton imageButton_hibernate;
        private ImageButton imageButton_shutdown;
        private ImageButton imageButton_restart;
        private System.Windows.Forms.Label label_sleep;
        private System.Windows.Forms.Label label_hibernate;
        private System.Windows.Forms.Label label_shutdown;
        private System.Windows.Forms.Label label_restart;
        private System.Windows.Forms.Button button_easeOfAccess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

