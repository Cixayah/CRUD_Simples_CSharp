
namespace Funcionario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            btnCadastrar = new Button();
            label3 = new Label();
            label4 = new Label();
            txtCpf = new TextBox();
            txtEndereco = new TextBox();
            btnPesquisar = new Button();
            label5 = new Label();
            lblId = new Label();
            btnLimpar = new Button();
            btnAtualizar = new Button();
            btnDeletar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.Name = "txtEmail";
            // 
            // txtNome
            // 
            resources.ApplyResources(txtNome, "txtNome");
            txtNome.Name = "txtNome";
            // 
            // btnCadastrar
            // 
            resources.ApplyResources(btnCadastrar, "btnCadastrar");
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // txtCpf
            // 
            resources.ApplyResources(txtCpf, "txtCpf");
            txtCpf.Name = "txtCpf";
            // 
            // txtEndereco
            // 
            resources.ApplyResources(txtEndereco, "txtEndereco");
            txtEndereco.Name = "txtEndereco";
            // 
            // btnPesquisar
            // 
            resources.ApplyResources(btnPesquisar, "btnPesquisar");
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // lblId
            // 
            resources.ApplyResources(lblId, "lblId");
            lblId.Name = "lblId";
            // 
            // btnLimpar
            // 
            resources.ApplyResources(btnLimpar, "btnLimpar");
            btnLimpar.Name = "btnLimpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnAtualizar
            // 
            resources.ApplyResources(btnAtualizar, "btnAtualizar");
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnDeletar
            // 
            resources.ApplyResources(btnDeletar, "btnDeletar");
            btnDeletar.ForeColor = Color.Red;
            btnDeletar.Name = "btnDeletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDeletar);
            Controls.Add(btnAtualizar);
            Controls.Add(btnLimpar);
            Controls.Add(lblId);
            Controls.Add(label5);
            Controls.Add(btnPesquisar);
            Controls.Add(txtEndereco);
            Controls.Add(txtCpf);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnCadastrar);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

#endregion
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtNome;
        private Button btnCadastrar;
        private Label label3;
        private Label label4;
        private TextBox txtCpf;
        private TextBox txtEndereco;
        private Button btnPesquisar;
        private Label label5;
        private Label lblId;
        private Button btnLimpar;
        private Button btnAtualizar;
        private Button btnDeletar;
    }
}
