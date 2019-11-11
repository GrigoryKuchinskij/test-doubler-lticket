namespace LTicket
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxOutp = new System.Windows.Forms.TextBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxOutp
            // 
            this.textBoxOutp.Location = new System.Drawing.Point(12, 38);
            this.textBoxOutp.Name = "textBoxOutp";
            this.textBoxOutp.ReadOnly = true;
            this.textBoxOutp.Size = new System.Drawing.Size(169, 20);
            this.textBoxOutp.TabIndex = 0;
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(187, 9);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(71, 49);
            this.buttonCalc.TabIndex = 1;
            this.buttonCalc.Text = "Расчет";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(169, 26);
            this.label.TabIndex = 2;
            this.label.Text = "Счасливые билеты в диапазоне\r\nот \"000000\" до \"999999\"\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 70);
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.textBoxOutp);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(286, 109);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "\"Счасливый\" билет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOutp;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Label label;
    }
}

