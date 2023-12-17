namespace PluginForCAD.View
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            MainGroupBox = new GroupBox();
            DefaultParametersGroupBox = new GroupBox();
            MaximumParametersButton = new Button();
            AverageParametersButton = new Button();
            MinimumParametersButton = new Button();
            MinMaxChamferLengthLabel = new Label();
            ChamferLengthTextBox = new TextBox();
            ChamferLengthLabel = new Label();
            MinMaxSmallPartDiameter = new Label();
            SmallPartDiameterTextBox = new TextBox();
            SmallPartDiameterLabel = new Label();
            MinMaxBigPartDiameterLabel = new Label();
            BigPartDiameterTextBox = new TextBox();
            BigPartDiameterLabel = new Label();
            MinMaxSmallPartLengthLabel = new Label();
            SmallPartLengthTextBox = new TextBox();
            SmallPartLengthLabel = new Label();
            MinMaxBigPartLengthLabel = new Label();
            BigPartLengthLabel = new Label();
            BigPartLengthTextBox = new TextBox();
            TieRodPictureBox = new PictureBox();
            BuildTieRodButton = new Button();
            errorProvider = new ErrorProvider(components);
            MainGroupBox.SuspendLayout();
            DefaultParametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TieRodPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // MainGroupBox
            // 
            MainGroupBox.Controls.Add(DefaultParametersGroupBox);
            MainGroupBox.Controls.Add(MinMaxChamferLengthLabel);
            MainGroupBox.Controls.Add(ChamferLengthTextBox);
            MainGroupBox.Controls.Add(ChamferLengthLabel);
            MainGroupBox.Controls.Add(MinMaxSmallPartDiameter);
            MainGroupBox.Controls.Add(SmallPartDiameterTextBox);
            MainGroupBox.Controls.Add(SmallPartDiameterLabel);
            MainGroupBox.Controls.Add(MinMaxBigPartDiameterLabel);
            MainGroupBox.Controls.Add(BigPartDiameterTextBox);
            MainGroupBox.Controls.Add(BigPartDiameterLabel);
            MainGroupBox.Controls.Add(MinMaxSmallPartLengthLabel);
            MainGroupBox.Controls.Add(SmallPartLengthTextBox);
            MainGroupBox.Controls.Add(SmallPartLengthLabel);
            MainGroupBox.Controls.Add(MinMaxBigPartLengthLabel);
            MainGroupBox.Controls.Add(BigPartLengthLabel);
            MainGroupBox.Controls.Add(BigPartLengthTextBox);
            MainGroupBox.Dock = DockStyle.Left;
            MainGroupBox.Location = new Point(0, 0);
            MainGroupBox.Name = "MainGroupBox";
            MainGroupBox.Size = new Size(257, 646);
            MainGroupBox.TabIndex = 0;
            MainGroupBox.TabStop = false;
            MainGroupBox.Text = "Parameters";
            // 
            // DefaultParametersGroupBox
            // 
            DefaultParametersGroupBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            DefaultParametersGroupBox.Controls.Add(MaximumParametersButton);
            DefaultParametersGroupBox.Controls.Add(AverageParametersButton);
            DefaultParametersGroupBox.Controls.Add(MinimumParametersButton);
            DefaultParametersGroupBox.Location = new Point(5, 567);
            DefaultParametersGroupBox.Name = "DefaultParametersGroupBox";
            DefaultParametersGroupBox.Size = new Size(252, 55);
            DefaultParametersGroupBox.TabIndex = 1;
            DefaultParametersGroupBox.TabStop = false;
            DefaultParametersGroupBox.Text = "Default Parameters";
            // 
            // MaximumParametersButton
            // 
            MaximumParametersButton.Location = new Point(165, 19);
            MaximumParametersButton.Name = "MaximumParametersButton";
            MaximumParametersButton.Size = new Size(75, 23);
            MaximumParametersButton.TabIndex = 2;
            MaximumParametersButton.Text = "Maximum";
            MaximumParametersButton.UseVisualStyleBackColor = true;
            MaximumParametersButton.Click += SetDefaultParameters;
            // 
            // AverageParametersButton
            // 
            AverageParametersButton.Location = new Point(84, 19);
            AverageParametersButton.Name = "AverageParametersButton";
            AverageParametersButton.Size = new Size(75, 23);
            AverageParametersButton.TabIndex = 1;
            AverageParametersButton.Text = "Average";
            AverageParametersButton.UseVisualStyleBackColor = true;
            AverageParametersButton.Click += SetDefaultParameters;
            // 
            // MinimumParametersButton
            // 
            MinimumParametersButton.Location = new Point(6, 19);
            MinimumParametersButton.Name = "MinimumParametersButton";
            MinimumParametersButton.Size = new Size(75, 23);
            MinimumParametersButton.TabIndex = 0;
            MinimumParametersButton.Text = "Minimum";
            MinimumParametersButton.UseVisualStyleBackColor = true;
            MinimumParametersButton.Click += SetDefaultParameters;
            // 
            // MinMaxChamferLengthLabel
            // 
            MinMaxChamferLengthLabel.AutoSize = true;
            MinMaxChamferLengthLabel.ForeColor = SystemColors.ControlDarkDark;
            MinMaxChamferLengthLabel.Location = new Point(6, 324);
            MinMaxChamferLengthLabel.Name = "MinMaxChamferLengthLabel";
            MinMaxChamferLengthLabel.Size = new Size(147, 15);
            MinMaxChamferLengthLabel.TabIndex = 14;
            MinMaxChamferLengthLabel.Text = "Min - 7 mm, Max - 10 mm";
            // 
            // ChamferLengthTextBox
            // 
            ChamferLengthTextBox.Location = new Point(6, 301);
            ChamferLengthTextBox.Name = "ChamferLengthTextBox";
            ChamferLengthTextBox.Size = new Size(200, 23);
            ChamferLengthTextBox.TabIndex = 13;
            ChamferLengthTextBox.Leave += SetParameter;
            // 
            // ChamferLengthLabel
            // 
            ChamferLengthLabel.AutoSize = true;
            ChamferLengthLabel.Location = new Point(6, 283);
            ChamferLengthLabel.Name = "ChamferLengthLabel";
            ChamferLengthLabel.Size = new Size(93, 15);
            ChamferLengthLabel.TabIndex = 12;
            ChamferLengthLabel.Text = "Chamfer Length";
            // 
            // MinMaxSmallPartDiameter
            // 
            MinMaxSmallPartDiameter.AutoSize = true;
            MinMaxSmallPartDiameter.ForeColor = SystemColors.ControlDarkDark;
            MinMaxSmallPartDiameter.Location = new Point(6, 256);
            MinMaxSmallPartDiameter.Name = "MinMaxSmallPartDiameter";
            MinMaxSmallPartDiameter.Size = new Size(153, 15);
            MinMaxSmallPartDiameter.TabIndex = 11;
            MinMaxSmallPartDiameter.Text = "Min - 10 mm, Max - 21 mm";
            // 
            // SmallPartDiameterTextBox
            // 
            SmallPartDiameterTextBox.Location = new Point(6, 232);
            SmallPartDiameterTextBox.Name = "SmallPartDiameterTextBox";
            SmallPartDiameterTextBox.Size = new Size(200, 23);
            SmallPartDiameterTextBox.TabIndex = 10;
            SmallPartDiameterTextBox.Leave += SetParameter;
            // 
            // SmallPartDiameterLabel
            // 
            SmallPartDiameterLabel.AutoSize = true;
            SmallPartDiameterLabel.Location = new Point(6, 214);
            SmallPartDiameterLabel.Name = "SmallPartDiameterLabel";
            SmallPartDiameterLabel.Size = new Size(111, 15);
            SmallPartDiameterLabel.TabIndex = 9;
            SmallPartDiameterLabel.Text = "Small Part Diameter";
            // 
            // MinMaxBigPartDiameterLabel
            // 
            MinMaxBigPartDiameterLabel.AutoSize = true;
            MinMaxBigPartDiameterLabel.ForeColor = SystemColors.ControlDarkDark;
            MinMaxBigPartDiameterLabel.Location = new Point(5, 191);
            MinMaxBigPartDiameterLabel.Name = "MinMaxBigPartDiameterLabel";
            MinMaxBigPartDiameterLabel.Size = new Size(153, 15);
            MinMaxBigPartDiameterLabel.TabIndex = 8;
            MinMaxBigPartDiameterLabel.Text = "Min - 20 mm, Max - 30 mm";
            // 
            // BigPartDiameterTextBox
            // 
            BigPartDiameterTextBox.Location = new Point(5, 168);
            BigPartDiameterTextBox.Name = "BigPartDiameterTextBox";
            BigPartDiameterTextBox.Size = new Size(200, 23);
            BigPartDiameterTextBox.TabIndex = 7;
            BigPartDiameterTextBox.Leave += SetParameter;
            // 
            // BigPartDiameterLabel
            // 
            BigPartDiameterLabel.AutoSize = true;
            BigPartDiameterLabel.Location = new Point(5, 150);
            BigPartDiameterLabel.Name = "BigPartDiameterLabel";
            BigPartDiameterLabel.Size = new Size(99, 15);
            BigPartDiameterLabel.TabIndex = 6;
            BigPartDiameterLabel.Text = "Big Part Diameter";
            // 
            // MinMaxSmallPartLengthLabel
            // 
            MinMaxSmallPartLengthLabel.AutoSize = true;
            MinMaxSmallPartLengthLabel.ForeColor = SystemColors.ControlDarkDark;
            MinMaxSmallPartLengthLabel.Location = new Point(5, 126);
            MinMaxSmallPartLengthLabel.Name = "MinMaxSmallPartLengthLabel";
            MinMaxSmallPartLengthLabel.Size = new Size(159, 15);
            MinMaxSmallPartLengthLabel.TabIndex = 5;
            MinMaxSmallPartLengthLabel.Text = "Min - 75 mm, Max - 190 mm";
            // 
            // SmallPartLengthTextBox
            // 
            SmallPartLengthTextBox.Location = new Point(5, 103);
            SmallPartLengthTextBox.Name = "SmallPartLengthTextBox";
            SmallPartLengthTextBox.Size = new Size(200, 23);
            SmallPartLengthTextBox.TabIndex = 4;
            SmallPartLengthTextBox.Leave += SetParameter;
            // 
            // SmallPartLengthLabel
            // 
            SmallPartLengthLabel.AutoSize = true;
            SmallPartLengthLabel.Location = new Point(6, 85);
            SmallPartLengthLabel.Name = "SmallPartLengthLabel";
            SmallPartLengthLabel.Size = new Size(100, 15);
            SmallPartLengthLabel.TabIndex = 3;
            SmallPartLengthLabel.Text = "Small Part Length";
            // 
            // MinMaxBigPartLengthLabel
            // 
            MinMaxBigPartLengthLabel.AutoSize = true;
            MinMaxBigPartLengthLabel.ForeColor = SystemColors.ControlDarkDark;
            MinMaxBigPartLengthLabel.Location = new Point(6, 63);
            MinMaxBigPartLengthLabel.Name = "MinMaxBigPartLengthLabel";
            MinMaxBigPartLengthLabel.Size = new Size(165, 15);
            MinMaxBigPartLengthLabel.TabIndex = 2;
            MinMaxBigPartLengthLabel.Text = "Min - 300 mm, Max - 380 mm";
            // 
            // BigPartLengthLabel
            // 
            BigPartLengthLabel.AutoSize = true;
            BigPartLengthLabel.Location = new Point(5, 18);
            BigPartLengthLabel.Name = "BigPartLengthLabel";
            BigPartLengthLabel.Size = new Size(88, 15);
            BigPartLengthLabel.TabIndex = 1;
            BigPartLengthLabel.Text = "Big Part Length";
            // 
            // BigPartLengthTextBox
            // 
            BigPartLengthTextBox.Location = new Point(6, 36);
            BigPartLengthTextBox.Name = "BigPartLengthTextBox";
            BigPartLengthTextBox.Size = new Size(200, 23);
            BigPartLengthTextBox.TabIndex = 0;
            BigPartLengthTextBox.Leave += SetParameter;
            // 
            // TieRodPictureBox
            // 
            TieRodPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TieRodPictureBox.BackgroundImage = (Image)resources.GetObject("TieRodPictureBox.BackgroundImage");
            TieRodPictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            TieRodPictureBox.BorderStyle = BorderStyle.FixedSingle;
            TieRodPictureBox.Location = new Point(270, 12);
            TieRodPictureBox.MinimumSize = new Size(701, 318);
            TieRodPictureBox.Name = "TieRodPictureBox";
            TieRodPictureBox.Size = new Size(701, 509);
            TieRodPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            TieRodPictureBox.TabIndex = 2;
            TieRodPictureBox.TabStop = false;
            // 
            // BuildTieRodButton
            // 
            BuildTieRodButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BuildTieRodButton.Location = new Point(914, 592);
            BuildTieRodButton.Name = "BuildTieRodButton";
            BuildTieRodButton.Size = new Size(75, 23);
            BuildTieRodButton.TabIndex = 3;
            BuildTieRodButton.Text = "Build TieRod";
            BuildTieRodButton.UseVisualStyleBackColor = true;
            BuildTieRodButton.Click += BuildTieRodButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(1036, 646);
            Controls.Add(BuildTieRodButton);
            Controls.Add(TieRodPictureBox);
            Controls.Add(MainGroupBox);
            MinimumSize = new Size(1052, 685);
            Name = "MainForm";
            Text = "MainForm";
            MainGroupBox.ResumeLayout(false);
            MainGroupBox.PerformLayout();
            DefaultParametersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TieRodPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox MainGroupBox;
        private Label MinMaxSmallPartDiameter;
        private TextBox SmallPartDiameterTextBox;
        private Label SmallPartDiameterLabel;
        private Label MinMaxBigPartDiameterLabel;
        private TextBox BigPartDiameterTextBox;
        private Label BigPartDiameterLabel;
        private Label MinMaxSmallPartLengthLabel;
        private TextBox SmallPartLengthTextBox;
        private Label SmallPartLengthLabel;
        private Label MinMaxBigPartLengthLabel;
        private Label BigPartLengthLabel;
        private TextBox BigPartLengthTextBox;
        private Label MinMaxChamferLengthLabel;
        private TextBox ChamferLengthTextBox;
        private Label ChamferLengthLabel;
        private GroupBox DefaultParametersGroupBox;
        private Button MaximumParametersButton;
        private Button AverageParametersButton;
        private Button MinimumParametersButton;
        private PictureBox TieRodPictureBox;
        private Button BuildTieRodButton;
        private ErrorProvider errorProvider;
    }
}