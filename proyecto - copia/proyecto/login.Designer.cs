namespace proyecto
{
    partial class login
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnINico = new System.Windows.Forms.Button();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblusuario = new System.Windows.Forms.Label();
            this.lblcontra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(25, 167);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(149, 32);
            this.btnSalir.TabIndex = 33;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnINico
            // 
            this.btnINico.Location = new System.Drawing.Point(25, 129);
            this.btnINico.Name = "btnINico";
            this.btnINico.Size = new System.Drawing.Size(149, 32);
            this.btnINico.TabIndex = 32;
            this.btnINico.Text = "Iniciar Sesion";
            this.btnINico.UseVisualStyleBackColor = true;
            this.btnINico.Click += new System.EventHandler(this.btnINico_Click);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(25, 91);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(149, 23);
            this.txtContra.TabIndex = 31;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(25, 46);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(149, 23);
            this.txtUsuario.TabIndex = 30;
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblusuario.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblusuario.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblusuario.Location = new System.Drawing.Point(25, 26);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(66, 16);
            this.lblusuario.TabIndex = 29;
            this.lblusuario.Text = "USUARIO";
            // 
            // lblcontra
            // 
            this.lblcontra.AutoSize = true;
            this.lblcontra.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblcontra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcontra.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcontra.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblcontra.Location = new System.Drawing.Point(25, 72);
            this.lblcontra.Name = "lblcontra";
            this.lblcontra.Size = new System.Drawing.Size(98, 16);
            this.lblcontra.TabIndex = 28;
            this.lblcontra.Text = "CONTRASEÑA";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(199, 225);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnINico);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblusuario);
            this.Controls.Add(this.lblcontra);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSalir;
        private Button btnINico;
        private TextBox txtContra;
        private TextBox txtUsuario;
        private Label lblusuario;
        private Label lblcontra;
    }
}