namespace WinFormsAppRest1
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtCod = new TextBox();
            txtDesc = new TextBox();
            cmdIncluir = new Button();
            cboTipo = new ComboBox();
            cboUM = new ComboBox();
            cboLocpad = new ComboBox();
            cboGrupo = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 25);
            label1.Name = "label1";
            label1.Size = new Size(391, 28);
            label1.TabIndex = 0;
            label1.Text = "Preencha os campos e clique em Incluir:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 86);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 1;
            label2.Text = "Código:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 133);
            label3.Name = "label3";
            label3.Size = new Size(100, 28);
            label3.TabIndex = 2;
            label3.Text = "Descrição:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 176);
            label4.Name = "label4";
            label4.Size = new Size(55, 28);
            label4.TabIndex = 3;
            label4.Text = "Tipo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 222);
            label5.Name = "label5";
            label5.Size = new Size(134, 28);
            label5.TabIndex = 4;
            label5.Text = "Unid. Medida:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(31, 269);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 5;
            label6.Text = "Armazém:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(31, 310);
            label7.Name = "label7";
            label7.Size = new Size(72, 28);
            label7.TabIndex = 6;
            label7.Text = "Grupo:";
            // 
            // txtCod
            // 
            txtCod.CharacterCasing = CharacterCasing.Upper;
            txtCod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCod.Location = new Point(188, 80);
            txtCod.MaxLength = 15;
            txtCod.Name = "txtCod";
            txtCod.Size = new Size(125, 34);
            txtCod.TabIndex = 7;
            // 
            // txtDesc
            // 
            txtDesc.CharacterCasing = CharacterCasing.Upper;
            txtDesc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDesc.Location = new Point(188, 127);
            txtDesc.MaxLength = 30;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(497, 34);
            txtDesc.TabIndex = 8;
            // 
            // cmdIncluir
            // 
            cmdIncluir.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmdIncluir.Location = new Point(31, 368);
            cmdIncluir.Name = "cmdIncluir";
            cmdIncluir.Size = new Size(94, 43);
            cmdIncluir.TabIndex = 13;
            cmdIncluir.Text = "Incluir";
            cmdIncluir.UseVisualStyleBackColor = true;
            cmdIncluir.Click += cmdIncluir_Click;
            // 
            // cboTipo
            // 
            cboTipo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTipo.FormattingEnabled = true;
            cboTipo.Location = new Point(188, 168);
            cboTipo.Name = "cboTipo";
            cboTipo.Size = new Size(329, 36);
            cboTipo.TabIndex = 14;
            // 
            // cboUM
            // 
            cboUM.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboUM.FormattingEnabled = true;
            cboUM.Location = new Point(188, 214);
            cboUM.Name = "cboUM";
            cboUM.Size = new Size(329, 36);
            cboUM.TabIndex = 15;
            // 
            // cboLocpad
            // 
            cboLocpad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboLocpad.FormattingEnabled = true;
            cboLocpad.Location = new Point(188, 261);
            cboLocpad.Name = "cboLocpad";
            cboLocpad.Size = new Size(329, 36);
            cboLocpad.TabIndex = 16;
            // 
            // cboGrupo
            // 
            cboGrupo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboGrupo.FormattingEnabled = true;
            cboGrupo.Location = new Point(188, 307);
            cboGrupo.Name = "cboGrupo";
            cboGrupo.Size = new Size(329, 36);
            cboGrupo.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cboGrupo);
            Controls.Add(cboLocpad);
            Controls.Add(cboUM);
            Controls.Add(cboTipo);
            Controls.Add(cmdIncluir);
            Controls.Add(txtDesc);
            Controls.Add(txtCod);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Criação de Produto no Protheus (SB1)";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtCod;
        private TextBox txtDesc;
        private Button cmdIncluir;
        private ComboBox cboTipo;
        private ComboBox cboUM;
        private ComboBox cboLocpad;
        private ComboBox cboGrupo;
    }
}
