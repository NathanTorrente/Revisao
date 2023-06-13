namespace Revisão_prova_2023
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
            bt_divisao = new Button();
            SuspendLayout();
            // 
            // bt_divisao
            // 
            bt_divisao.Location = new Point(86, 144);
            bt_divisao.Name = "bt_divisao";
            bt_divisao.Size = new Size(270, 109);
            bt_divisao.TabIndex = 0;
            bt_divisao.Text = "Divisão";
            bt_divisao.UseVisualStyleBackColor = true;
            bt_divisao.Click += bt_divisao_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bt_divisao);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bt_divisao;
    }
}