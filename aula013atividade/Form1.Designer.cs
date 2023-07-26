namespace aula013atividade
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
            label1 = new Label();
            txtnome = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtidade = new TextBox();
            txtrua = new TextBox();
            txtcidade = new TextBox();
            panel1 = new Panel();
            BTNsalvar = new Button();
            listanomes = new ListView();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(34, 11);
            label1.Name = "label1";
            label1.Size = new Size(143, 21);
            label1.TabIndex = 0;
            label1.Text = "Digite seu nome :";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(34, 49);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(254, 23);
            txtnome.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(34, 84);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 2;
            label2.Text = "Digite sua idade :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(34, 147);
            label3.Name = "label3";
            label3.Size = new Size(128, 21);
            label3.TabIndex = 3;
            label3.Text = "Digite sua Rua :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(34, 224);
            label4.Name = "label4";
            label4.Size = new Size(150, 21);
            label4.TabIndex = 4;
            label4.Text = "Digite sua cidade :";
            // 
            // txtidade
            // 
            txtidade.Location = new Point(34, 118);
            txtidade.Name = "txtidade";
            txtidade.Size = new Size(254, 23);
            txtidade.TabIndex = 5;
            // 
            // txtrua
            // 
            txtrua.Location = new Point(34, 183);
            txtrua.Name = "txtrua";
            txtrua.Size = new Size(254, 23);
            txtrua.TabIndex = 6;
            // 
            // txtcidade
            // 
            txtcidade.Location = new Point(34, 262);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(254, 23);
            txtcidade.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(BTNsalvar);
            panel1.Controls.Add(txtcidade);
            panel1.Controls.Add(txtnome);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtrua);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtidade);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 43);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 290);
            panel1.TabIndex = 8;
            // 
            // BTNsalvar
            // 
            BTNsalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BTNsalvar.Location = new Point(317, 118);
            BTNsalvar.Name = "BTNsalvar";
            BTNsalvar.Size = new Size(108, 59);
            BTNsalvar.TabIndex = 9;
            BTNsalvar.Text = "Salvar";
            BTNsalvar.UseVisualStyleBackColor = true;
            BTNsalvar.Click += BTNsalvar_Click;
            // 
            // listanomes
            // 
            listanomes.Location = new Point(504, 43);
            listanomes.Name = "listanomes";
            listanomes.Size = new Size(260, 297);
            listanomes.TabIndex = 9;
            listanomes.UseCompatibleStateImageBehavior = false;
            listanomes.View = View.List;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(537, 15);
            label5.Name = "label5";
            label5.Size = new Size(188, 25);
            label5.TabIndex = 10;
            label5.Text = "Pessoas cadastradas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(listanomes);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnome;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtidade;
        private TextBox txtrua;
        private TextBox txtcidade;
        private Panel panel1;
        private Button BTNsalvar;
        private ListView listanomes;
        private Label label5;
    }
}