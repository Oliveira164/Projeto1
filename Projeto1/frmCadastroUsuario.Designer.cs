namespace Projeto1
{
    partial class frmCadastroUsuario
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
            this.lblTituloUsuario = new System.Windows.Forms.Label();
            this.lblCadUsuario = new System.Windows.Forms.Label();
            this.lblCadSenha = new System.Windows.Forms.Label();
            this.txtCadUsuario = new System.Windows.Forms.TextBox();
            this.txtCadSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloUsuario
            // 
            this.lblTituloUsuario.AutoSize = true;
            this.lblTituloUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloUsuario.Location = new System.Drawing.Point(290, 21);
            this.lblTituloUsuario.Name = "lblTituloUsuario";
            this.lblTituloUsuario.Size = new System.Drawing.Size(226, 31);
            this.lblTituloUsuario.TabIndex = 0;
            this.lblTituloUsuario.Text = "Cadastro Usuário";
            // 
            // lblCadUsuario
            // 
            this.lblCadUsuario.AutoSize = true;
            this.lblCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadUsuario.Location = new System.Drawing.Point(226, 112);
            this.lblCadUsuario.Name = "lblCadUsuario";
            this.lblCadUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblCadUsuario.TabIndex = 1;
            this.lblCadUsuario.Text = "Usuário:";
            // 
            // lblCadSenha
            // 
            this.lblCadSenha.AutoSize = true;
            this.lblCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadSenha.Location = new System.Drawing.Point(234, 181);
            this.lblCadSenha.Name = "lblCadSenha";
            this.lblCadSenha.Size = new System.Drawing.Size(60, 20);
            this.lblCadSenha.TabIndex = 2;
            this.lblCadSenha.Text = "Senha:";
            // 
            // txtCadUsuario
            // 
            this.txtCadUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadUsuario.Location = new System.Drawing.Point(296, 108);
            this.txtCadUsuario.Name = "txtCadUsuario";
            this.txtCadUsuario.Size = new System.Drawing.Size(216, 24);
            this.txtCadUsuario.TabIndex = 3;
            // 
            // txtCadSenha
            // 
            this.txtCadSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCadSenha.Location = new System.Drawing.Point(296, 177);
            this.txtCadSenha.Name = "txtCadSenha";
            this.txtCadSenha.Size = new System.Drawing.Size(216, 24);
            this.txtCadSenha.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(347, 267);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 62);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 405);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtCadSenha);
            this.Controls.Add(this.txtCadUsuario);
            this.Controls.Add(this.lblCadSenha);
            this.Controls.Add(this.lblCadUsuario);
            this.Controls.Add(this.lblTituloUsuario);
            this.Name = "frmCadastroUsuario";
            this.Text = "frmCadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloUsuario;
        private System.Windows.Forms.Label lblCadUsuario;
        private System.Windows.Forms.Label lblCadSenha;
        private System.Windows.Forms.TextBox txtCadUsuario;
        private System.Windows.Forms.TextBox txtCadSenha;
        private System.Windows.Forms.Button btnCadastrar;
    }
}