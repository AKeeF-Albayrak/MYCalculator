namespace MYCalculator
{
    partial class CalculatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
            panelClose = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panelResults = new Panel();
            labelEquation = new Label();
            labelNumber = new Label();
            panel1 = new Panel();
            buttonPercent = new Button();
            buttonDeleteNumber = new Button();
            buttonClear = new Button();
            buttonDelete = new Button();
            buttonInverse = new Button();
            buttonsquared = new Button();
            buttonRoot = new Button();
            buttonDivision = new Button();
            buttonSeven = new Button();
            buttonEight = new Button();
            buttonNine = new Button();
            buttonMultiplication = new Button();
            buttonFour = new Button();
            buttonFive = new Button();
            buttonSix = new Button();
            buttonSubtraction = new Button();
            buttonOne = new Button();
            buttonTwo = new Button();
            buttonThree = new Button();
            buttonPlus = new Button();
            buttonReverse = new Button();
            buttonZero = new Button();
            buttonDot = new Button();
            buttonEqual = new Button();
            panelClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelResults.SuspendLayout();
            SuspendLayout();
            // 
            // panelClose
            // 
            panelClose.Controls.Add(pictureBox2);
            panelClose.Controls.Add(label1);
            panelClose.Controls.Add(pictureBox1);
            panelClose.Location = new Point(0, 0);
            panelClose.Name = "panelClose";
            panelClose.Size = new Size(291, 45);
            panelClose.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.clsoeButton;
            pictureBox2.Location = new Point(257, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 1;
            label1.Text = "MYCalculator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calculator;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(23, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelResults
            // 
            panelResults.Controls.Add(labelEquation);
            panelResults.Controls.Add(labelNumber);
            panelResults.Controls.Add(panel1);
            panelResults.Location = new Point(0, 42);
            panelResults.Name = "panelResults";
            panelResults.Size = new Size(291, 141);
            panelResults.TabIndex = 1;
            // 
            // labelEquation
            // 
            labelEquation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelEquation.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelEquation.ForeColor = SystemColors.ControlDarkDark;
            labelEquation.Location = new Point(12, 6);
            labelEquation.Name = "labelEquation";
            labelEquation.Size = new Size(262, 34);
            labelEquation.TabIndex = 5;
            labelEquation.TextAlign = ContentAlignment.TopRight;
            // 
            // labelNumber
            // 
            labelNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelNumber.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            labelNumber.Location = new Point(12, 93);
            labelNumber.Name = "labelNumber";
            labelNumber.Size = new Size(262, 37);
            labelNumber.TabIndex = 4;
            labelNumber.Text = "0";
            labelNumber.TextAlign = ContentAlignment.TopRight;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 147);
            panel1.Name = "panel1";
            panel1.Size = new Size(291, 392);
            panel1.TabIndex = 2;
            // 
            // buttonPercent
            // 
            buttonPercent.Location = new Point(3, 189);
            buttonPercent.Name = "buttonPercent";
            buttonPercent.Size = new Size(65, 50);
            buttonPercent.TabIndex = 2;
            buttonPercent.Text = "%";
            buttonPercent.UseVisualStyleBackColor = true;
            buttonPercent.Click += buttonPercent_Click;
            // 
            // buttonDeleteNumber
            // 
            buttonDeleteNumber.Location = new Point(74, 189);
            buttonDeleteNumber.Name = "buttonDeleteNumber";
            buttonDeleteNumber.Size = new Size(65, 50);
            buttonDeleteNumber.TabIndex = 3;
            buttonDeleteNumber.Text = "CE";
            buttonDeleteNumber.UseVisualStyleBackColor = true;
            buttonDeleteNumber.Click += buttonDeleteNumber_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(145, 189);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(65, 50);
            buttonClear.TabIndex = 4;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(216, 192);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(65, 50);
            buttonDelete.TabIndex = 5;
            buttonDelete.Text = "<---";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonInverse
            // 
            buttonInverse.Location = new Point(3, 245);
            buttonInverse.Name = "buttonInverse";
            buttonInverse.Size = new Size(65, 50);
            buttonInverse.TabIndex = 6;
            buttonInverse.Text = "1/x";
            buttonInverse.UseVisualStyleBackColor = true;
            buttonInverse.Click += buttonInverse_Click;
            // 
            // buttonsquared
            // 
            buttonsquared.Location = new Point(74, 245);
            buttonsquared.Name = "buttonsquared";
            buttonsquared.Size = new Size(65, 50);
            buttonsquared.TabIndex = 7;
            buttonsquared.Text = "x^(2)";
            buttonsquared.UseVisualStyleBackColor = true;
            buttonsquared.Click += buttonsquared_Click;
            // 
            // buttonRoot
            // 
            buttonRoot.Location = new Point(145, 245);
            buttonRoot.Name = "buttonRoot";
            buttonRoot.Size = new Size(65, 50);
            buttonRoot.TabIndex = 8;
            buttonRoot.Text = "x^(1/2)";
            buttonRoot.UseVisualStyleBackColor = true;
            buttonRoot.Click += buttonRoot_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.Location = new Point(216, 245);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(65, 50);
            buttonDivision.TabIndex = 9;
            buttonDivision.Text = "÷";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.Location = new Point(3, 301);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(65, 50);
            buttonSeven.TabIndex = 10;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += buttonSeven_Click;
            // 
            // buttonEight
            // 
            buttonEight.Location = new Point(74, 301);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(65, 50);
            buttonEight.TabIndex = 11;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += buttonEight_Click;
            // 
            // buttonNine
            // 
            buttonNine.Location = new Point(145, 301);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(65, 50);
            buttonNine.TabIndex = 12;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += buttonNine_Click;
            // 
            // buttonMultiplication
            // 
            buttonMultiplication.Location = new Point(216, 301);
            buttonMultiplication.Name = "buttonMultiplication";
            buttonMultiplication.Size = new Size(65, 50);
            buttonMultiplication.TabIndex = 13;
            buttonMultiplication.Text = "x";
            buttonMultiplication.UseVisualStyleBackColor = true;
            buttonMultiplication.Click += buttonMultiplication_Click;
            // 
            // buttonFour
            // 
            buttonFour.Location = new Point(3, 357);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(65, 50);
            buttonFour.TabIndex = 14;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += buttonFour_Click;
            // 
            // buttonFive
            // 
            buttonFive.Location = new Point(74, 357);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(65, 50);
            buttonFive.TabIndex = 15;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += buttonFive_Click;
            // 
            // buttonSix
            // 
            buttonSix.Location = new Point(145, 357);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(65, 50);
            buttonSix.TabIndex = 16;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += buttonSix_Click;
            // 
            // buttonSubtraction
            // 
            buttonSubtraction.Location = new Point(216, 357);
            buttonSubtraction.Name = "buttonSubtraction";
            buttonSubtraction.Size = new Size(65, 50);
            buttonSubtraction.TabIndex = 17;
            buttonSubtraction.Text = "-";
            buttonSubtraction.UseVisualStyleBackColor = true;
            buttonSubtraction.Click += buttonSubtraction_Click;
            // 
            // buttonOne
            // 
            buttonOne.Location = new Point(3, 413);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(65, 50);
            buttonOne.TabIndex = 18;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += buttonOne_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.Location = new Point(74, 413);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(65, 50);
            buttonTwo.TabIndex = 19;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += buttonTwo_Click;
            // 
            // buttonThree
            // 
            buttonThree.Location = new Point(145, 413);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(65, 50);
            buttonThree.TabIndex = 20;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += buttonThree_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(216, 413);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(65, 50);
            buttonPlus.TabIndex = 21;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonReverse
            // 
            buttonReverse.Location = new Point(3, 469);
            buttonReverse.Name = "buttonReverse";
            buttonReverse.Size = new Size(65, 50);
            buttonReverse.TabIndex = 22;
            buttonReverse.Text = "+/-";
            buttonReverse.UseVisualStyleBackColor = true;
            buttonReverse.Click += buttonReverse_Click;
            // 
            // buttonZero
            // 
            buttonZero.Location = new Point(74, 469);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(65, 50);
            buttonZero.TabIndex = 23;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += buttonZero_Click;
            // 
            // buttonDot
            // 
            buttonDot.Location = new Point(145, 469);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(65, 50);
            buttonDot.TabIndex = 24;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += buttonDot_Click;
            // 
            // buttonEqual
            // 
            buttonEqual.Location = new Point(216, 469);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(65, 50);
            buttonEqual.TabIndex = 25;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += buttonEqual_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 523);
            Controls.Add(buttonEqual);
            Controls.Add(buttonDot);
            Controls.Add(buttonZero);
            Controls.Add(buttonReverse);
            Controls.Add(buttonPlus);
            Controls.Add(buttonThree);
            Controls.Add(buttonTwo);
            Controls.Add(buttonOne);
            Controls.Add(buttonSubtraction);
            Controls.Add(buttonSix);
            Controls.Add(buttonFive);
            Controls.Add(buttonFour);
            Controls.Add(buttonMultiplication);
            Controls.Add(buttonNine);
            Controls.Add(buttonEight);
            Controls.Add(buttonSeven);
            Controls.Add(buttonDivision);
            Controls.Add(buttonRoot);
            Controls.Add(buttonsquared);
            Controls.Add(buttonInverse);
            Controls.Add(buttonDelete);
            Controls.Add(buttonClear);
            Controls.Add(buttonDeleteNumber);
            Controls.Add(buttonPercent);
            Controls.Add(panelResults);
            Controls.Add(panelClose);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CalculatorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CalculatorForm";
            Load += CalculatorForm_Load;
            panelClose.ResumeLayout(false);
            panelClose.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelResults.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelClose;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelResults;
        private Panel panel1;
        private Button buttonPercent;
        private Button buttonDeleteNumber;
        private Button buttonClear;
        private Button buttonDelete;
        private Button buttonInverse;
        private Button buttonsquared;
        private Button buttonRoot;
        private Button buttonDivision;
        private Button buttonSeven;
        private Button buttonEight;
        private Button buttonNine;
        private Button buttonMultiplication;
        private Button buttonFour;
        private Button buttonFive;
        private Button buttonSix;
        private Button buttonSubtraction;
        private Button buttonOne;
        private Button buttonTwo;
        private Button buttonThree;
        private Button buttonPlus;
        private Button buttonReverse;
        private Button buttonZero;
        private Button buttonDot;
        private Button buttonEqual;
        private Label labelNumber;
        private Label labelEquation;
    }
}