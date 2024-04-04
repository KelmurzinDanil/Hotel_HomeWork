namespace Hotel
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.Reserved = new System.Windows.Forms.RadioButton();
            this.Free = new System.Windows.Forms.RadioButton();
            this.Busy = new System.Windows.Forms.RadioButton();
            this.WriteOut = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.DataCheckInBox = new System.Windows.Forms.TextBox();
            this.DateExitBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.OpenCard = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TableGuest = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SearchButt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableGuest)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(169, 536);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(563, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(237, 536);
            this.splitter2.TabIndex = 1;
            this.splitter2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Статус";
            // 
            // Reserved
            // 
            this.Reserved.AutoSize = true;
            this.Reserved.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reserved.Location = new System.Drawing.Point(13, 105);
            this.Reserved.Name = "Reserved";
            this.Reserved.Size = new System.Drawing.Size(128, 19);
            this.Reserved.TabIndex = 3;
            this.Reserved.TabStop = true;
            this.Reserved.Text = "Зарезервировано ";
            this.Reserved.UseVisualStyleBackColor = true;
            this.Reserved.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Reserved_MouseClick);
            // 
            // Free
            // 
            this.Free.AutoSize = true;
            this.Free.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Free.Location = new System.Drawing.Point(12, 131);
            this.Free.Name = "Free";
            this.Free.Size = new System.Drawing.Size(91, 19);
            this.Free.TabIndex = 4;
            this.Free.TabStop = true;
            this.Free.Text = "Свободные";
            this.Free.UseVisualStyleBackColor = true;
            this.Free.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Free_MouseClick);
            // 
            // Busy
            // 
            this.Busy.AutoSize = true;
            this.Busy.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Busy.Location = new System.Drawing.Point(12, 157);
            this.Busy.Name = "Busy";
            this.Busy.Size = new System.Drawing.Size(68, 19);
            this.Busy.TabIndex = 5;
            this.Busy.TabStop = true;
            this.Busy.Text = "Заняты";
            this.Busy.UseVisualStyleBackColor = true;
            this.Busy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Busy_MouseClick);
            // 
            // WriteOut
            // 
            this.WriteOut.AutoSize = true;
            this.WriteOut.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WriteOut.Location = new System.Drawing.Point(12, 183);
            this.WriteOut.Name = "WriteOut";
            this.WriteOut.Size = new System.Drawing.Size(116, 19);
            this.WriteOut.TabIndex = 6;
            this.WriteOut.TabStop = true;
            this.WriteOut.Text = "Выписываются ";
            this.WriteOut.UseVisualStyleBackColor = true;
            this.WriteOut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WriteOut_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(175, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Список гостей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(584, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Номер ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(573, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Статус";
            // 
            // StatusBox
            // 
            this.StatusBox.Location = new System.Drawing.Point(680, 181);
            this.StatusBox.Name = "StatusBox";
            this.StatusBox.ReadOnly = true;
            this.StatusBox.Size = new System.Drawing.Size(109, 22);
            this.StatusBox.TabIndex = 10;
            // 
            // NameBox
            // 
            this.NameBox.ForeColor = System.Drawing.Color.SlateBlue;
            this.NameBox.Location = new System.Drawing.Point(573, 232);
            this.NameBox.Name = "NameBox";
            this.NameBox.ReadOnly = true;
            this.NameBox.Size = new System.Drawing.Size(216, 22);
            this.NameBox.TabIndex = 11;
            // 
            // DataCheckInBox
            // 
            this.DataCheckInBox.Location = new System.Drawing.Point(573, 275);
            this.DataCheckInBox.Name = "DataCheckInBox";
            this.DataCheckInBox.ReadOnly = true;
            this.DataCheckInBox.Size = new System.Drawing.Size(109, 22);
            this.DataCheckInBox.TabIndex = 12;
            // 
            // DateExitBox
            // 
            this.DateExitBox.Location = new System.Drawing.Point(573, 320);
            this.DateExitBox.Name = "DateExitBox";
            this.DateExitBox.ReadOnly = true;
            this.DateExitBox.Size = new System.Drawing.Size(109, 22);
            this.DateExitBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.SlateBlue;
            this.label5.Location = new System.Drawing.Point(572, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата заезда";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.SlateBlue;
            this.label6.Location = new System.Drawing.Point(572, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Дата выезда";
            // 
            // OpenCard
            // 
            this.OpenCard.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenCard.Location = new System.Drawing.Point(635, 487);
            this.OpenCard.Name = "OpenCard";
            this.OpenCard.Size = new System.Drawing.Size(154, 37);
            this.OpenCard.TabIndex = 16;
            this.OpenCard.Text = "Просмотр карточки";
            this.OpenCard.UseVisualStyleBackColor = true;
            this.OpenCard.Click += new System.EventHandler(this.OpenCard_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.SlateBlue;
            this.label7.Location = new System.Drawing.Point(572, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "ФИО";
            // 
            // TableGuest
            // 
            this.TableGuest.BackgroundColor = System.Drawing.Color.White;
            this.TableGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableGuest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FIO,
            this.Dr});
            this.TableGuest.Location = new System.Drawing.Point(175, 98);
            this.TableGuest.Name = "TableGuest";
            this.TableGuest.ReadOnly = true;
            this.TableGuest.RowHeadersWidth = 51;
            this.TableGuest.RowTemplate.Height = 24;
            this.TableGuest.Size = new System.Drawing.Size(382, 426);
            this.TableGuest.TabIndex = 18;
            this.TableGuest.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TableGuest_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // FIO
            // 
            this.FIO.HeaderText = "ФИО";
            this.FIO.MinimumWidth = 6;
            this.FIO.Name = "FIO";
            this.FIO.ReadOnly = true;
            this.FIO.Width = 140;
            // 
            // Dr
            // 
            this.Dr.HeaderText = "Дата рождения";
            this.Dr.MinimumWidth = 6;
            this.Dr.Name = "Dr";
            this.Dr.ReadOnly = true;
            this.Dr.Width = 140;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(12, 12);
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Size = new System.Drawing.Size(138, 22);
            this.Time.TabIndex = 19;
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchBox.Location = new System.Drawing.Point(175, 12);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(345, 22);
            this.SearchBox.TabIndex = 20;
            this.SearchBox.Text = "Поиск...";
            this.SearchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchBox_MouseClick);
            // 
            // SearchButt
            // 
            this.SearchButt.BackgroundImage = global::Hotel.Properties.Resources.poisk_zuh9zawqiluq_512;
            this.SearchButt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SearchButt.Location = new System.Drawing.Point(522, 5);
            this.SearchButt.Name = "SearchButt";
            this.SearchButt.Size = new System.Drawing.Size(35, 35);
            this.SearchButt.TabIndex = 21;
            this.SearchButt.UseVisualStyleBackColor = true;
            this.SearchButt.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.SearchButt);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.TableGuest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.OpenCard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DateExitBox);
            this.Controls.Add(this.DataCheckInBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.StatusBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WriteOut);
            this.Controls.Add(this.Busy);
            this.Controls.Add(this.Free);
            this.Controls.Add(this.Reserved);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Name = "MainForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.TableGuest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Reserved;
        private System.Windows.Forms.RadioButton Free;
        private System.Windows.Forms.RadioButton Busy;
        private System.Windows.Forms.RadioButton WriteOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox StatusBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox DataCheckInBox;
        private System.Windows.Forms.TextBox DateExitBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OpenCard;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView TableGuest;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dr;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button SearchButt;
    }
}