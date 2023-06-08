namespace vegwtation
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
            Start = new Button();
            AVG_INDEX_TX_BOX = new TextBox();
            label1 = new Label();
            Wheat = new CheckBox();
            Corn = new CheckBox();
            Oat = new CheckBox();
            Millet = new CheckBox();
            Rice = new CheckBox();
            Sunflower = new CheckBox();
            textof = new Label();
            Output_Label = new Label();
            checkBoxSOYA = new CheckBox();
            Picture_Box_Main1 = new PictureBox();
            Calculation_Start = new Button();
            ((System.ComponentModel.ISupportInitialize)Picture_Box_Main1).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.Location = new Point(4, 417);
            Start.Margin = new Padding(4, 3, 4, 3);
            Start.Name = "Start";
            Start.Size = new Size(192, 73);
            Start.TabIndex = 0;
            Start.Text = "Start";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Button;
            // 
            // AVG_INDEX_TX_BOX
            // 
            AVG_INDEX_TX_BOX.Location = new Point(12, 131);
            AVG_INDEX_TX_BOX.Margin = new Padding(4, 3, 4, 3);
            AVG_INDEX_TX_BOX.Name = "AVG_INDEX_TX_BOX";
            AVG_INDEX_TX_BOX.Size = new Size(93, 25);
            AVG_INDEX_TX_BOX.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(348, 37);
            label1.TabIndex = 3;
            label1.Text = "AVG VEGETATION INDEX";
            // 
            // Wheat
            // 
            Wheat.AutoSize = true;
            Wheat.Location = new Point(12, 241);
            Wheat.Margin = new Padding(4, 3, 4, 3);
            Wheat.Name = "Wheat";
            Wheat.Size = new Size(82, 21);
            Wheat.TabIndex = 4;
            Wheat.Text = "Пшениця";
            Wheat.UseVisualStyleBackColor = true;
            // 
            // Corn
            // 
            Corn.AutoSize = true;
            Corn.Location = new Point(12, 269);
            Corn.Margin = new Padding(4, 3, 4, 3);
            Corn.Name = "Corn";
            Corn.Size = new Size(85, 21);
            Corn.TabIndex = 5;
            Corn.Text = "кукурудза";
            Corn.UseVisualStyleBackColor = true;
            // 
            // Oat
            // 
            Oat.AutoSize = true;
            Oat.Location = new Point(12, 297);
            Oat.Margin = new Padding(4, 3, 4, 3);
            Oat.Name = "Oat";
            Oat.Size = new Size(57, 21);
            Oat.TabIndex = 7;
            Oat.Text = "Овес";
            Oat.UseVisualStyleBackColor = true;
            // 
            // Millet
            // 
            Millet.AutoSize = true;
            Millet.Location = new Point(12, 326);
            Millet.Margin = new Padding(4, 3, 4, 3);
            Millet.Name = "Millet";
            Millet.Size = new Size(66, 21);
            Millet.TabIndex = 8;
            Millet.Text = "Просо";
            Millet.UseVisualStyleBackColor = true;
            // 
            // Rice
            // 
            Rice.AutoSize = true;
            Rice.Location = new Point(12, 354);
            Rice.Margin = new Padding(4, 3, 4, 3);
            Rice.Name = "Rice";
            Rice.Size = new Size(47, 21);
            Rice.TabIndex = 9;
            Rice.Text = "Рис";
            Rice.UseVisualStyleBackColor = true;
            // 
            // Sunflower
            // 
            Sunflower.AutoSize = true;
            Sunflower.Location = new Point(12, 184);
            Sunflower.Margin = new Padding(4, 3, 4, 3);
            Sunflower.Name = "Sunflower";
            Sunflower.Size = new Size(88, 21);
            Sunflower.TabIndex = 11;
            Sunflower.Text = "Соняшник";
            Sunflower.UseVisualStyleBackColor = true;
            // 
            // textof
            // 
            textof.AutoSize = true;
            textof.Location = new Point(144, 145);
            textof.Margin = new Padding(4, 0, 4, 0);
            textof.Name = "textof";
            textof.Size = new Size(0, 17);
            textof.TabIndex = 12;
            // 
            // Output_Label
            // 
            Output_Label.AutoSize = true;
            Output_Label.Location = new Point(175, 148);
            Output_Label.Margin = new Padding(4, 0, 4, 0);
            Output_Label.Name = "Output_Label";
            Output_Label.Size = new Size(0, 17);
            Output_Label.TabIndex = 13;
            // 
            // checkBoxSOYA
            // 
            checkBoxSOYA.AutoSize = true;
            checkBoxSOYA.Location = new Point(12, 211);
            checkBoxSOYA.Margin = new Padding(4, 3, 4, 3);
            checkBoxSOYA.Name = "checkBoxSOYA";
            checkBoxSOYA.Size = new Size(50, 21);
            checkBoxSOYA.TabIndex = 14;
            checkBoxSOYA.Text = "Соя";
            checkBoxSOYA.UseVisualStyleBackColor = true;
            // 
            // Picture_Box_Main1
            // 
            Picture_Box_Main1.BackColor = SystemColors.ControlDark;
            Picture_Box_Main1.Dock = DockStyle.Right;
            Picture_Box_Main1.Location = new Point(988, 0);
            Picture_Box_Main1.Margin = new Padding(4, 3, 4, 3);
            Picture_Box_Main1.Name = "Picture_Box_Main1";
            Picture_Box_Main1.Size = new Size(916, 1041);
            Picture_Box_Main1.SizeMode = PictureBoxSizeMode.AutoSize;
            Picture_Box_Main1.TabIndex = 15;
            Picture_Box_Main1.TabStop = false;
            Picture_Box_Main1.Click += Picture_Box_Main1_Click;
            Picture_Box_Main1.Paint += PictureBox1_Paint;
            Picture_Box_Main1.MouseDown += Picture_Box_Main1_MouseDown;
            Picture_Box_Main1.MouseUp += Picture_Box_Main1_MouseUp;
            // 
            // Calculation_Start
            // 
            Calculation_Start.Location = new Point(178, 534);
            Calculation_Start.Margin = new Padding(4, 3, 4, 3);
            Calculation_Start.Name = "Calculation_Start";
            Calculation_Start.Size = new Size(75, 24);
            Calculation_Start.TabIndex = 20;
            Calculation_Start.Text = "Calculate";
            Calculation_Start.UseVisualStyleBackColor = true;
            Calculation_Start.Click += Calculation_Start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1904, 1041);
            Controls.Add(Calculation_Start);
            Controls.Add(Picture_Box_Main1);
            Controls.Add(checkBoxSOYA);
            Controls.Add(Output_Label);
            Controls.Add(textof);
            Controls.Add(Sunflower);
            Controls.Add(Rice);
            Controls.Add(Millet);
            Controls.Add(Oat);
            Controls.Add(Corn);
            Controls.Add(Wheat);
            Controls.Add(label1);
            Controls.Add(AVG_INDEX_TX_BOX);
            Controls.Add(Start);
            Cursor = Cursors.NoMove2D;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Picture_Box_Main1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button Start;
        private TextBox AVG_INDEX_TX_BOX;
        private Label label1;
        private CheckBox Wheat;
        private CheckBox Corn;
        private CheckBox soybeansCheckBox;
        private CheckBox Oat;
        private CheckBox Millet;
        private CheckBox Rice;
        private CheckBox Sunflower;
        private Label textof;
        private Label Output_Label;
        private CheckBox checkBoxSOYA;
        public PictureBox Picture_Box_Main1;
        private Button Calculation_Start;

    }
}