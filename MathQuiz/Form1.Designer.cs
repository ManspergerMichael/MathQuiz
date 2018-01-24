namespace MathQuiz
{
    partial class Form1
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
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLeftBox = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.plusSign = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.plusEquals = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.minusLabel = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.minusEquals = new System.Windows.Forms.Label();
            this.diffrence = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.multiplyEquals = new System.Windows.Forms.Label();
            this.rightMultiplyLable = new System.Windows.Forms.Label();
            this.multiply = new System.Windows.Forms.Label();
            this.leftMultiplyLabel = new System.Windows.Forms.Label();
            this.quotent = new System.Windows.Forms.NumericUpDown();
            this.devideEquals = new System.Windows.Forms.Label();
            this.devideRightLabel = new System.Windows.Forms.Label();
            this.devideSign = new System.Windows.Forms.Label();
            this.devideLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diffrence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotent)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(184, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // timeLeftBox
            // 
            this.timeLeftBox.AutoSize = true;
            this.timeLeftBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftBox.Location = new System.Drawing.Point(58, 9);
            this.timeLeftBox.Name = "timeLeftBox";
            this.timeLeftBox.Size = new System.Drawing.Size(120, 29);
            this.timeLeftBox.TabIndex = 1;
            this.timeLeftBox.Text = "Time Left:";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(94, 70);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(60, 30);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusSign
            // 
            this.plusSign.AutoSize = true;
            this.plusSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusSign.Location = new System.Drawing.Point(151, 73);
            this.plusSign.Name = "plusSign";
            this.plusSign.Size = new System.Drawing.Size(27, 29);
            this.plusSign.TabIndex = 3;
            this.plusSign.Text = "+";
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.AutoSize = true;
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(184, 71);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(25, 29);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            // 
            // plusEquals
            // 
            this.plusEquals.AutoSize = true;
            this.plusEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusEquals.Location = new System.Drawing.Point(215, 71);
            this.plusEquals.Name = "plusEquals";
            this.plusEquals.Size = new System.Drawing.Size(27, 29);
            this.plusEquals.TabIndex = 5;
            this.plusEquals.Text = "=";
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(248, 69);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(85, 35);
            this.sum.TabIndex = 2;
            this.sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(94, 124);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(60, 30);
            this.minusLeftLabel.TabIndex = 7;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLabel
            // 
            this.minusLabel.AutoSize = true;
            this.minusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLabel.Location = new System.Drawing.Point(153, 123);
            this.minusLabel.Name = "minusLabel";
            this.minusLabel.Size = new System.Drawing.Size(21, 29);
            this.minusLabel.TabIndex = 8;
            this.minusLabel.Text = "-";
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.AutoSize = true;
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(184, 125);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(25, 29);
            this.minusRightLabel.TabIndex = 9;
            this.minusRightLabel.Text = "?";
            // 
            // minusEquals
            // 
            this.minusEquals.AutoSize = true;
            this.minusEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusEquals.Location = new System.Drawing.Point(215, 125);
            this.minusEquals.Name = "minusEquals";
            this.minusEquals.Size = new System.Drawing.Size(27, 29);
            this.minusEquals.TabIndex = 10;
            this.minusEquals.Text = "=";
            // 
            // diffrence
            // 
            this.diffrence.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diffrence.Location = new System.Drawing.Point(248, 123);
            this.diffrence.Name = "diffrence";
            this.diffrence.Size = new System.Drawing.Size(85, 35);
            this.diffrence.TabIndex = 3;
            this.diffrence.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.diffrence.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(248, 172);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(85, 35);
            this.product.TabIndex = 4;
            this.product.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.product.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // multiplyEquals
            // 
            this.multiplyEquals.AutoSize = true;
            this.multiplyEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyEquals.Location = new System.Drawing.Point(215, 174);
            this.multiplyEquals.Name = "multiplyEquals";
            this.multiplyEquals.Size = new System.Drawing.Size(27, 29);
            this.multiplyEquals.TabIndex = 15;
            this.multiplyEquals.Text = "=";
            // 
            // rightMultiplyLable
            // 
            this.rightMultiplyLable.AutoSize = true;
            this.rightMultiplyLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightMultiplyLable.Location = new System.Drawing.Point(184, 174);
            this.rightMultiplyLable.Name = "rightMultiplyLable";
            this.rightMultiplyLable.Size = new System.Drawing.Size(25, 29);
            this.rightMultiplyLable.TabIndex = 14;
            this.rightMultiplyLable.Text = "?";
            // 
            // multiply
            // 
            this.multiply.AutoSize = true;
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply.Location = new System.Drawing.Point(152, 181);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(20, 20);
            this.multiply.TabIndex = 13;
            this.multiply.Text = "X";
            // 
            // leftMultiplyLabel
            // 
            this.leftMultiplyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftMultiplyLabel.Location = new System.Drawing.Point(94, 173);
            this.leftMultiplyLabel.Name = "leftMultiplyLabel";
            this.leftMultiplyLabel.Size = new System.Drawing.Size(60, 30);
            this.leftMultiplyLabel.TabIndex = 12;
            this.leftMultiplyLabel.Text = "?";
            this.leftMultiplyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quotent
            // 
            this.quotent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotent.Location = new System.Drawing.Point(248, 225);
            this.quotent.Name = "quotent";
            this.quotent.Size = new System.Drawing.Size(85, 35);
            this.quotent.TabIndex = 5;
            this.quotent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.quotent.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // devideEquals
            // 
            this.devideEquals.AutoSize = true;
            this.devideEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devideEquals.Location = new System.Drawing.Point(215, 227);
            this.devideEquals.Name = "devideEquals";
            this.devideEquals.Size = new System.Drawing.Size(27, 29);
            this.devideEquals.TabIndex = 20;
            this.devideEquals.Text = "=";
            // 
            // devideRightLabel
            // 
            this.devideRightLabel.AutoSize = true;
            this.devideRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devideRightLabel.Location = new System.Drawing.Point(184, 227);
            this.devideRightLabel.Name = "devideRightLabel";
            this.devideRightLabel.Size = new System.Drawing.Size(25, 29);
            this.devideRightLabel.TabIndex = 19;
            this.devideRightLabel.Text = "?";
            // 
            // devideSign
            // 
            this.devideSign.AutoSize = true;
            this.devideSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devideSign.Location = new System.Drawing.Point(151, 227);
            this.devideSign.Name = "devideSign";
            this.devideSign.Size = new System.Drawing.Size(27, 29);
            this.devideSign.TabIndex = 18;
            this.devideSign.Text = "÷";
            // 
            // devideLeftLabel
            // 
            this.devideLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devideLeftLabel.Location = new System.Drawing.Point(94, 226);
            this.devideLeftLabel.Name = "devideLeftLabel";
            this.devideLeftLabel.Size = new System.Drawing.Size(60, 30);
            this.devideLeftLabel.TabIndex = 17;
            this.devideLeftLabel.Text = "?";
            this.devideLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(99, 266);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(234, 32);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start Quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 361);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quotent);
            this.Controls.Add(this.devideEquals);
            this.Controls.Add(this.devideRightLabel);
            this.Controls.Add(this.devideSign);
            this.Controls.Add(this.devideLeftLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.multiplyEquals);
            this.Controls.Add(this.rightMultiplyLable);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.leftMultiplyLabel);
            this.Controls.Add(this.diffrence);
            this.Controls.Add(this.minusEquals);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.minusLabel);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.plusEquals);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.plusSign);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.timeLeftBox);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Math Quiz";
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diffrence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLeftBox;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label plusSign;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label plusEquals;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Label minusLabel;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label minusEquals;
        private System.Windows.Forms.NumericUpDown diffrence;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label multiplyEquals;
        private System.Windows.Forms.Label rightMultiplyLable;
        private System.Windows.Forms.Label multiply;
        private System.Windows.Forms.Label leftMultiplyLabel;
        private System.Windows.Forms.NumericUpDown quotent;
        private System.Windows.Forms.Label devideEquals;
        private System.Windows.Forms.Label devideRightLabel;
        private System.Windows.Forms.Label devideSign;
        private System.Windows.Forms.Label devideLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

