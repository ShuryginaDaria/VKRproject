namespace VKRproject
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProcessingTimeTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RadiusStepTextBox = new System.Windows.Forms.TextBox();
            this.DepthStepTextBox = new System.Windows.Forms.TextBox();
            this.DensityTextBox = new System.Windows.Forms.TextBox();
            this.HeatSourcesTextBox = new System.Windows.Forms.TextBox();
            this.StartTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.ThermalCapacityTextBox = new System.Windows.Forms.TextBox();
            this.EndTemperatureTextBox = new System.Windows.Forms.TextBox();
            this.TimeStepTextBox = new System.Windows.Forms.TextBox();
            this.TranscalencyTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Время обработки (t,c)";
            // 
            // ProcessingTimeTextBox
            // 
            this.ProcessingTimeTextBox.Location = new System.Drawing.Point(451, 44);
            this.ProcessingTimeTextBox.Name = "ProcessingTimeTextBox";
            this.ProcessingTimeTextBox.Size = new System.Drawing.Size(100, 26);
            this.ProcessingTimeTextBox.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.fffToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::VKRproject.Properties.Resources.icons8_сохранить_64;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::VKRproject.Properties.Resources.icons8_сохранить_как_64;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(167, 30);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            // 
            // fffToolStripMenuItem
            // 
            this.fffToolStripMenuItem.Name = "fffToolStripMenuItem";
            this.fffToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fffToolStripMenuItem.Text = "Edit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Image = global::VKRproject.Properties.Resources.icons8_о_нас_64;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(146, 30);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Шаг по радиусу образца (Nx)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Шаг по глубине образца (Ny)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Плотность образца (p,кг/м3)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Теплоемкость (с,Дж/К*кг)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Источники тепла (Q ,Вт/м2)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(309, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Начальная температура образца (Tн,К)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 413);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(296, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Конечная температура образца (Тк,К)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 511);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(300, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Теплопроводность образца (л,Вт/К*м)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 20);
            this.label10.TabIndex = 11;
            this.label10.Text = "Шаг по времени ( t,c)";
            // 
            // RadiusStepTextBox
            // 
            this.RadiusStepTextBox.Location = new System.Drawing.Point(451, 90);
            this.RadiusStepTextBox.Name = "RadiusStepTextBox";
            this.RadiusStepTextBox.Size = new System.Drawing.Size(100, 26);
            this.RadiusStepTextBox.TabIndex = 12;
            // 
            // DepthStepTextBox
            // 
            this.DepthStepTextBox.Location = new System.Drawing.Point(451, 142);
            this.DepthStepTextBox.Name = "DepthStepTextBox";
            this.DepthStepTextBox.Size = new System.Drawing.Size(100, 26);
            this.DepthStepTextBox.TabIndex = 13;
            // 
            // DensityTextBox
            // 
            this.DensityTextBox.Location = new System.Drawing.Point(451, 195);
            this.DensityTextBox.Name = "DensityTextBox";
            this.DensityTextBox.Size = new System.Drawing.Size(100, 26);
            this.DensityTextBox.TabIndex = 14;
            // 
            // HeatSourcesTextBox
            // 
            this.HeatSourcesTextBox.Location = new System.Drawing.Point(451, 302);
            this.HeatSourcesTextBox.Name = "HeatSourcesTextBox";
            this.HeatSourcesTextBox.Size = new System.Drawing.Size(100, 26);
            this.HeatSourcesTextBox.TabIndex = 15;
            // 
            // StartTemperatureTextBox
            // 
            this.StartTemperatureTextBox.Location = new System.Drawing.Point(451, 356);
            this.StartTemperatureTextBox.Name = "StartTemperatureTextBox";
            this.StartTemperatureTextBox.Size = new System.Drawing.Size(100, 26);
            this.StartTemperatureTextBox.TabIndex = 16;
            // 
            // ThermalCapacityTextBox
            // 
            this.ThermalCapacityTextBox.Location = new System.Drawing.Point(451, 248);
            this.ThermalCapacityTextBox.Name = "ThermalCapacityTextBox";
            this.ThermalCapacityTextBox.Size = new System.Drawing.Size(100, 26);
            this.ThermalCapacityTextBox.TabIndex = 17;
            // 
            // EndTemperatureTextBox
            // 
            this.EndTemperatureTextBox.Location = new System.Drawing.Point(451, 407);
            this.EndTemperatureTextBox.Name = "EndTemperatureTextBox";
            this.EndTemperatureTextBox.Size = new System.Drawing.Size(100, 26);
            this.EndTemperatureTextBox.TabIndex = 18;
            // 
            // TimeStepTextBox
            // 
            this.TimeStepTextBox.Location = new System.Drawing.Point(451, 458);
            this.TimeStepTextBox.Name = "TimeStepTextBox";
            this.TimeStepTextBox.Size = new System.Drawing.Size(100, 26);
            this.TimeStepTextBox.TabIndex = 19;
            // 
            // TranscalencyTextBox
            // 
            this.TranscalencyTextBox.Location = new System.Drawing.Point(451, 505);
            this.TranscalencyTextBox.Name = "TranscalencyTextBox";
            this.TranscalencyTextBox.Size = new System.Drawing.Size(100, 26);
            this.TranscalencyTextBox.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TranscalencyTextBox);
            this.Controls.Add(this.TimeStepTextBox);
            this.Controls.Add(this.EndTemperatureTextBox);
            this.Controls.Add(this.ThermalCapacityTextBox);
            this.Controls.Add(this.StartTemperatureTextBox);
            this.Controls.Add(this.HeatSourcesTextBox);
            this.Controls.Add(this.DensityTextBox);
            this.Controls.Add(this.DepthStepTextBox);
            this.Controls.Add(this.RadiusStepTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProcessingTimeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Моделирование";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProcessingTimeTextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox RadiusStepTextBox;
        private System.Windows.Forms.TextBox DepthStepTextBox;
        private System.Windows.Forms.TextBox DensityTextBox;
        private System.Windows.Forms.TextBox HeatSourcesTextBox;
        private System.Windows.Forms.TextBox StartTemperatureTextBox;
        private System.Windows.Forms.TextBox ThermalCapacityTextBox;
        private System.Windows.Forms.TextBox EndTemperatureTextBox;
        private System.Windows.Forms.TextBox TimeStepTextBox;
        private System.Windows.Forms.TextBox TranscalencyTextBox;
        private System.Windows.Forms.Button button1;
    }
}
