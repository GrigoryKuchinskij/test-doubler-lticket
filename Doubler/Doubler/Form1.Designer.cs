namespace Doubler
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
            this.textBoxInp = new System.Windows.Forms.TextBox();
            this.buttonMultip = new System.Windows.Forms.Button();
            this.buttonDoubl = new System.Windows.Forms.Button();
            this.textBoxOutp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxInp
            // 
            this.textBoxInp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInp.BackColor = System.Drawing.Color.White;
            this.textBoxInp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxInp.ForeColor = System.Drawing.Color.Black;
            this.textBoxInp.Location = new System.Drawing.Point(58, 6);
            this.textBoxInp.Name = "textBoxInp";
            this.textBoxInp.Size = new System.Drawing.Size(277, 25);
            this.textBoxInp.TabIndex = 0;
            this.textBoxInp.Enter += new System.EventHandler(this.textBoxInp_Enter);
            this.textBoxInp.Leave += new System.EventHandler(this.textBoxInp_Leave);
            // 
            // buttonMultip
            // 
            this.buttonMultip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMultip.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buttonMultip.Location = new System.Drawing.Point(58, 37);
            this.buttonMultip.Name = "buttonMultip";
            this.buttonMultip.Size = new System.Drawing.Size(129, 33);
            this.buttonMultip.TabIndex = 1;
            this.buttonMultip.Text = "Умножить на 2";
            this.buttonMultip.UseVisualStyleBackColor = true;
            this.buttonMultip.Click += new System.EventHandler(this.buttonMultip_Click);
            // 
            // buttonDoubl
            // 
            this.buttonDoubl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDoubl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.buttonDoubl.Location = new System.Drawing.Point(193, 37);
            this.buttonDoubl.Name = "buttonDoubl";
            this.buttonDoubl.Size = new System.Drawing.Size(142, 33);
            this.buttonDoubl.TabIndex = 1;
            this.buttonDoubl.Text = "Дублирование";
            this.buttonDoubl.UseVisualStyleBackColor = true;
            this.buttonDoubl.Click += new System.EventHandler(this.buttonDoubl_Click);
            // 
            // textBoxOutp
            // 
            this.textBoxOutp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxOutp.ForeColor = System.Drawing.Color.Black;
            this.textBoxOutp.Location = new System.Drawing.Point(58, 76);
            this.textBoxOutp.Name = "textBoxOutp";
            this.textBoxOutp.ReadOnly = true;
            this.textBoxOutp.Size = new System.Drawing.Size(277, 25);
            this.textBoxOutp.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ввод";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Вывод";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(343, 113);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOutp);
            this.Controls.Add(this.buttonDoubl);
            this.Controls.Add(this.buttonMultip);
            this.Controls.Add(this.textBoxInp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(252, 129);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInp;
        private System.Windows.Forms.Button buttonMultip;
        private System.Windows.Forms.Button buttonDoubl;
        private System.Windows.Forms.TextBox textBoxOutp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

