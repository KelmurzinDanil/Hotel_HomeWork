namespace Hotel
{
    partial class CardGuest
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AnimalGuest = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DateOfBirthGuest = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.PayBox = new System.Windows.Forms.TextBox();
            this.NameGuest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(96, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Карточка гостя";
            // 
            // AnimalGuest
            // 
            this.AnimalGuest.AutoSize = true;
            this.AnimalGuest.ForeColor = System.Drawing.Color.Gray;
            this.AnimalGuest.Location = new System.Drawing.Point(33, 295);
            this.AnimalGuest.Name = "AnimalGuest";
            this.AnimalGuest.Size = new System.Drawing.Size(209, 20);
            this.AnimalGuest.TabIndex = 7;
            this.AnimalGuest.Text = "Путешествую с животными ";
            this.AnimalGuest.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(216, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Количество дней";
            // 
            // DateOfBirthGuest
            // 
            this.DateOfBirthGuest.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirthGuest.ForeColor = System.Drawing.Color.Tan;
            this.DateOfBirthGuest.Location = new System.Drawing.Point(33, 132);
            this.DateOfBirthGuest.Name = "DateOfBirthGuest";
            this.DateOfBirthGuest.ReadOnly = true;
            this.DateOfBirthGuest.Size = new System.Drawing.Size(324, 28);
            this.DateOfBirthGuest.TabIndex = 8;
            // 
            // DateBox
            // 
            this.DateBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateBox.ForeColor = System.Drawing.Color.Tan;
            this.DateBox.Location = new System.Drawing.Point(33, 239);
            this.DateBox.Name = "DateBox";
            this.DateBox.ReadOnly = true;
            this.DateBox.Size = new System.Drawing.Size(119, 28);
            this.DateBox.TabIndex = 10;
            // 
            // PayBox
            // 
            this.PayBox.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayBox.ForeColor = System.Drawing.Color.Tan;
            this.PayBox.Location = new System.Drawing.Point(33, 190);
            this.PayBox.Name = "PayBox";
            this.PayBox.ReadOnly = true;
            this.PayBox.Size = new System.Drawing.Size(324, 28);
            this.PayBox.TabIndex = 11;
            // 
            // NameGuest
            // 
            this.NameGuest.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameGuest.ForeColor = System.Drawing.Color.Tan;
            this.NameGuest.Location = new System.Drawing.Point(33, 75);
            this.NameGuest.Name = "NameGuest";
            this.NameGuest.ReadOnly = true;
            this.NameGuest.Size = new System.Drawing.Size(324, 28);
            this.NameGuest.TabIndex = 12;
            // 
            // CardGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 361);
            this.Controls.Add(this.NameGuest);
            this.Controls.Add(this.PayBox);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DateOfBirthGuest);
            this.Controls.Add(this.AnimalGuest);
            this.Controls.Add(this.label1);
            this.Name = "CardGuest";
            this.Text = "CardGuest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AnimalGuest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DateOfBirthGuest;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.TextBox PayBox;
        private System.Windows.Forms.TextBox NameGuest;
    }
}

