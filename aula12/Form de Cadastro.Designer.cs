namespace aula12
{
    partial class Form_de_Cadastro
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
            txtNome = new TextBox();
            txtPreço = new TextBox();
            btnSalvar = new Button();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(189, 43);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(376, 27);
            txtNome.TabIndex = 0;
            // 
            // txtPreço
            // 
            txtPreço.Location = new Point(189, 134);
            txtPreço.Name = "txtPreço";
            txtPreço.Size = new Size(376, 27);
            txtPreço.TabIndex = 1;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(319, 224);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(94, 29);
            btnSalvar.TabIndex = 2;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // Form_de_Cadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalvar);
            Controls.Add(txtPreço);
            Controls.Add(txtNome);
            Name = "Form_de_Cadastro";
            Text = "Form_de_Cadastro";
            Load += Form_de_Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtPreço;
        private Button btnSalvar;
    }
}