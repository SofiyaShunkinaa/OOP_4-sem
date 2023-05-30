namespace WindowsFormsApp2
{
    partial class Form1
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
            this.Title = new System.Windows.Forms.TextBox();
            this.RegionComboBox1 = new System.Windows.Forms.ComboBox();
            this.RegionComboBox2 = new System.Windows.Forms.ComboBox();
            this.EnteredSize = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.ConvertBTN = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelRegion1 = new System.Windows.Forms.Label();
            this.labelRegion2 = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.OldLace;
            this.Title.Font = new System.Drawing.Font("Goudy Stout", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.OliveDrab;
            this.Title.Location = new System.Drawing.Point(92, 35);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(610, 49);
            this.Title.TabIndex = 0;
            this.Title.Text = "Калькулятор размеров одежды";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //this.Title.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // RegionComboBox1
            // 
            this.RegionComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionComboBox1.FormattingEnabled = true;
            this.RegionComboBox1.Items.AddRange(new object[] {
            "RUS/BEL",
            "UK/USA",
            "EU"});
            this.RegionComboBox1.Location = new System.Drawing.Point(320, 305);
            this.RegionComboBox1.Name = "RegionComboBox1";
            this.RegionComboBox1.Size = new System.Drawing.Size(121, 33);
            this.RegionComboBox1.TabIndex = 1;
            //this.RegionComboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RegionComboBox2
            // 
            this.RegionComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegionComboBox2.FormattingEnabled = true;
            this.RegionComboBox2.Items.AddRange(new object[] {
            "RUS/BEL",
            "UK/USA",
            "EU"});
            this.RegionComboBox2.Location = new System.Drawing.Point(320, 421);
            this.RegionComboBox2.Name = "RegionComboBox2";
            this.RegionComboBox2.Size = new System.Drawing.Size(121, 33);
            this.RegionComboBox2.TabIndex = 3;
            //this.RegionComboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // EnteredSize
            // 
            this.EnteredSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnteredSize.Location = new System.Drawing.Point(320, 176);
            this.EnteredSize.Name = "EnteredSize";
            this.EnteredSize.Size = new System.Drawing.Size(121, 30);
            this.EnteredSize.TabIndex = 5;
            //this.EnteredSize.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTextBox.Location = new System.Drawing.Point(320, 635);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.Size = new System.Drawing.Size(121, 30);
            this.ResultTextBox.TabIndex = 7;
            // 
            // ConvertBTN
            // 
            this.ConvertBTN.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ConvertBTN.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertBTN.Location = new System.Drawing.Point(304, 503);
            this.ConvertBTN.Name = "ConvertBTN";
            this.ConvertBTN.Size = new System.Drawing.Size(154, 43);
            this.ConvertBTN.TabIndex = 17;
            this.ConvertBTN.Text = "Перевести";
            this.ConvertBTN.UseVisualStyleBackColor = false;
            this.ConvertBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSize.Location = new System.Drawing.Point(258, 135);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(259, 27);
            this.labelSize.TabIndex = 19;
            this.labelSize.Text = "Введите размер одежды";
            //this.labelSize.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelRegion1
            // 
            this.labelRegion1.AutoSize = true;
            this.labelRegion1.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegion1.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRegion1.Location = new System.Drawing.Point(255, 263);
            this.labelRegion1.Name = "labelRegion1";
            this.labelRegion1.Size = new System.Drawing.Size(241, 27);
            this.labelRegion1.TabIndex = 21;
            this.labelRegion1.Text = "Выберите регион ввода";
            //this.labelRegion1.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelRegion2
            // 
            this.labelRegion2.AutoSize = true;
            this.labelRegion2.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegion2.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRegion2.Location = new System.Drawing.Point(258, 381);
            this.labelRegion2.Name = "labelRegion2";
            this.labelRegion2.Size = new System.Drawing.Size(255, 27);
            this.labelRegion2.TabIndex = 22;
            this.labelRegion2.Text = "Выберите регион вывода";
            //this.labelRegion2.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.Control;
            this.labelResult.Location = new System.Drawing.Point(231, 596);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(295, 27);
            this.labelResult.TabIndex = 25;
            this.labelResult.Text = "Полученный размер одежды";
            //this.labelResult.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(772, 722);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelRegion2);
            this.Controls.Add(this.labelRegion1);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.ConvertBTN);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.EnteredSize);
            this.Controls.Add(this.RegionComboBox2);
            this.Controls.Add(this.RegionComboBox1);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Калькулятор размеров";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.ComboBox RegionComboBox1;
        private System.Windows.Forms.ComboBox RegionComboBox2;
        private System.Windows.Forms.TextBox EnteredSize;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Button ConvertBTN;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelRegion1;
        private System.Windows.Forms.Label labelRegion2;
        private System.Windows.Forms.Label labelResult;
    }
}

