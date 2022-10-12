
namespace WinFormsAppHolaMundo
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
            this.components = new System.ComponentModel.Container();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Numero1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Numero2TextBox = new System.Windows.Forms.TextBox();
            this.SumarButton = new System.Windows.Forms.Button();
            this.ErroresErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.RestarButton = new System.Windows.Forms.Button();
            this.MultiplicarButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CancelarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ErroresErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CerrarButton
            // 
            this.CerrarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CerrarButton.Location = new System.Drawing.Point(175, 347);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(75, 63);
            this.CerrarButton.TabIndex = 0;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número 1:";
            // 
            // Numero1TextBox
            // 
            this.Numero1TextBox.Location = new System.Drawing.Point(125, 47);
            this.Numero1TextBox.Name = "Numero1TextBox";
            this.Numero1TextBox.Size = new System.Drawing.Size(100, 23);
            this.Numero1TextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número 2:";
            // 
            // Numero2TextBox
            // 
            this.Numero2TextBox.Location = new System.Drawing.Point(125, 89);
            this.Numero2TextBox.Name = "Numero2TextBox";
            this.Numero2TextBox.Size = new System.Drawing.Size(100, 23);
            this.Numero2TextBox.TabIndex = 2;
            // 
            // SumarButton
            // 
            this.SumarButton.Image = global::WinFormsAppHolaMundo.Properties.Resources.joyent_36px;
            this.SumarButton.Location = new System.Drawing.Point(31, 133);
            this.SumarButton.Name = "SumarButton";
            this.SumarButton.Size = new System.Drawing.Size(75, 61);
            this.SumarButton.TabIndex = 3;
            this.SumarButton.Text = "&Sumar";
            this.SumarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SumarButton.UseVisualStyleBackColor = true;
            this.SumarButton.Click += new System.EventHandler(this.SumarButton_Click);
            // 
            // ErroresErrorProvider
            // 
            this.ErroresErrorProvider.ContainerControl = this;
            // 
            // RestarButton
            // 
            this.RestarButton.Image = global::WinFormsAppHolaMundo.Properties.Resources.minus_36px;
            this.RestarButton.Location = new System.Drawing.Point(150, 133);
            this.RestarButton.Name = "RestarButton";
            this.RestarButton.Size = new System.Drawing.Size(75, 61);
            this.RestarButton.TabIndex = 3;
            this.RestarButton.Text = "Restar";
            this.RestarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RestarButton.UseVisualStyleBackColor = true;
            this.RestarButton.Click += new System.EventHandler(this.RestarButton_Click);
            // 
            // MultiplicarButton
            // 
            this.MultiplicarButton.Image = global::WinFormsAppHolaMundo.Properties.Resources.multiplication_36px;
            this.MultiplicarButton.Location = new System.Drawing.Point(31, 211);
            this.MultiplicarButton.Name = "MultiplicarButton";
            this.MultiplicarButton.Size = new System.Drawing.Size(75, 61);
            this.MultiplicarButton.TabIndex = 3;
            this.MultiplicarButton.Text = "Multiplicar";
            this.MultiplicarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.MultiplicarButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::WinFormsAppHolaMundo.Properties.Resources.divide_36px;
            this.button1.Location = new System.Drawing.Point(150, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 3;
            this.button1.Text = "Multiplicar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CancelarButton
            // 
            this.CancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelarButton.Image = global::WinFormsAppHolaMundo.Properties.Resources.cancel_36px;
            this.CancelarButton.Location = new System.Drawing.Point(31, 347);
            this.CancelarButton.Name = "CancelarButton";
            this.CancelarButton.Size = new System.Drawing.Size(75, 63);
            this.CancelarButton.TabIndex = 0;
            this.CancelarButton.Text = "Cancelar";
            this.CancelarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CancelarButton.UseVisualStyleBackColor = true;
            this.CancelarButton.Click += new System.EventHandler(this.CancelarButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 425);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MultiplicarButton);
            this.Controls.Add(this.RestarButton);
            this.Controls.Add(this.SumarButton);
            this.Controls.Add(this.Numero2TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Numero1TextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarButton);
            this.Controls.Add(this.CerrarButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operaciones Básicas";
            ((System.ComponentModel.ISupportInitialize)(this.ErroresErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Numero1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Numero2TextBox;
        private System.Windows.Forms.Button SumarButton;
        private System.Windows.Forms.ErrorProvider ErroresErrorProvider;
        private System.Windows.Forms.Button RestarButton;
        private System.Windows.Forms.Button MultiplicarButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CancelarButton;
    }
}

