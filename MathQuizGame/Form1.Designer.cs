namespace MathQuizGame
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
            this.timeLeftTextBook = new System.Windows.Forms.Label();
            this.addSign = new System.Windows.Forms.Label();
            this.multiplyRight = new System.Windows.Forms.Label();
            this.multiplySign = new System.Windows.Forms.Label();
            this.multiplyLeft = new System.Windows.Forms.Label();
            this.subtractRight = new System.Windows.Forms.Label();
            this.addLeft = new System.Windows.Forms.Label();
            this.subtractSign = new System.Windows.Forms.Label();
            this.subtractLeft = new System.Windows.Forms.Label();
            this.addRight = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.diffrence = new System.Windows.Forms.NumericUpDown();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.quotent = new System.Windows.Forms.NumericUpDown();
            this.divideLeft = new System.Windows.Forms.Label();
            this.divideSign = new System.Windows.Forms.Label();
            this.divideRight = new System.Windows.Forms.Label();
            this.equalSign = new System.Windows.Forms.Label();
            this.equalSign2 = new System.Windows.Forms.Label();
            this.equalSign3 = new System.Windows.Forms.Label();
            this.equalSign4 = new System.Windows.Forms.Label();
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
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(538, 39);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLeftTextBook
            // 
            this.timeLeftTextBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLeftTextBook.Location = new System.Drawing.Point(384, 39);
            this.timeLeftTextBook.Name = "timeLeftTextBook";
            this.timeLeftTextBook.Size = new System.Drawing.Size(126, 30);
            this.timeLeftTextBook.TabIndex = 1;
            this.timeLeftTextBook.Text = "Time Left";
            this.timeLeftTextBook.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addSign
            // 
            this.addSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addSign.Location = new System.Drawing.Point(195, 177);
            this.addSign.Name = "addSign";
            this.addSign.Size = new System.Drawing.Size(80, 40);
            this.addSign.TabIndex = 3;
            this.addSign.Text = "+";
            this.addSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplyRight
            // 
            this.multiplyRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyRight.Location = new System.Drawing.Point(327, 419);
            this.multiplyRight.Name = "multiplyRight";
            this.multiplyRight.Size = new System.Drawing.Size(80, 40);
            this.multiplyRight.TabIndex = 5;
            this.multiplyRight.Text = "?";
            this.multiplyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplySign
            // 
            this.multiplySign.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplySign.Location = new System.Drawing.Point(188, 419);
            this.multiplySign.Name = "multiplySign";
            this.multiplySign.Size = new System.Drawing.Size(80, 40);
            this.multiplySign.TabIndex = 6;
            this.multiplySign.Text = "x";
            this.multiplySign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiplyLeft
            // 
            this.multiplyLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyLeft.Location = new System.Drawing.Point(51, 419);
            this.multiplyLeft.Name = "multiplyLeft";
            this.multiplyLeft.Size = new System.Drawing.Size(80, 40);
            this.multiplyLeft.TabIndex = 7;
            this.multiplyLeft.Text = "?";
            this.multiplyLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtractRight
            // 
            this.subtractRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractRight.Location = new System.Drawing.Point(327, 305);
            this.subtractRight.Name = "subtractRight";
            this.subtractRight.Size = new System.Drawing.Size(80, 40);
            this.subtractRight.TabIndex = 8;
            this.subtractRight.Text = "?";
            this.subtractRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addLeft
            // 
            this.addLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addLeft.Location = new System.Drawing.Point(65, 177);
            this.addLeft.Name = "addLeft";
            this.addLeft.Size = new System.Drawing.Size(80, 40);
            this.addLeft.TabIndex = 10;
            this.addLeft.Text = "?";
            this.addLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtractSign
            // 
            this.subtractSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractSign.Location = new System.Drawing.Point(188, 305);
            this.subtractSign.Name = "subtractSign";
            this.subtractSign.Size = new System.Drawing.Size(80, 40);
            this.subtractSign.TabIndex = 11;
            this.subtractSign.Text = "-";
            this.subtractSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // subtractLeft
            // 
            this.subtractLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractLeft.Location = new System.Drawing.Point(58, 305);
            this.subtractLeft.Name = "subtractLeft";
            this.subtractLeft.Size = new System.Drawing.Size(80, 40);
            this.subtractLeft.TabIndex = 12;
            this.subtractLeft.Text = "?";
            this.subtractLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addRight
            // 
            this.addRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRight.Location = new System.Drawing.Point(334, 177);
            this.addRight.Name = "addRight";
            this.addRight.Size = new System.Drawing.Size(80, 40);
            this.addRight.TabIndex = 13;
            this.addRight.Text = "?";
            this.addRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(614, 177);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(120, 22);
            this.sum.TabIndex = 2;
            this.sum.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // diffrence
            // 
            this.diffrence.Location = new System.Drawing.Point(614, 305);
            this.diffrence.Name = "diffrence";
            this.diffrence.Size = new System.Drawing.Size(120, 22);
            this.diffrence.TabIndex = 3;
            // 
            // product
            // 
            this.product.Location = new System.Drawing.Point(607, 425);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(120, 22);
            this.product.TabIndex = 4;
            // 
            // quotent
            // 
            this.quotent.Location = new System.Drawing.Point(607, 550);
            this.quotent.Name = "quotent";
            this.quotent.Size = new System.Drawing.Size(120, 22);
            this.quotent.TabIndex = 5;
            // 
            // divideLeft
            // 
            this.divideLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideLeft.Location = new System.Drawing.Point(51, 536);
            this.divideLeft.Name = "divideLeft";
            this.divideLeft.Size = new System.Drawing.Size(80, 40);
            this.divideLeft.TabIndex = 19;
            this.divideLeft.Text = "?";
            this.divideLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideSign
            // 
            this.divideSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideSign.Location = new System.Drawing.Point(188, 536);
            this.divideSign.Name = "divideSign";
            this.divideSign.Size = new System.Drawing.Size(80, 40);
            this.divideSign.TabIndex = 18;
            this.divideSign.Text = "÷\r\n";
            this.divideSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divideRight
            // 
            this.divideRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideRight.Location = new System.Drawing.Point(327, 536);
            this.divideRight.Name = "divideRight";
            this.divideRight.Size = new System.Drawing.Size(80, 40);
            this.divideRight.TabIndex = 17;
            this.divideRight.Text = "?";
            this.divideRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSign
            // 
            this.equalSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSign.Location = new System.Drawing.Point(477, 177);
            this.equalSign.Name = "equalSign";
            this.equalSign.Size = new System.Drawing.Size(80, 40);
            this.equalSign.TabIndex = 21;
            this.equalSign.Text = "=";
            this.equalSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSign2
            // 
            this.equalSign2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSign2.Location = new System.Drawing.Point(477, 305);
            this.equalSign2.Name = "equalSign2";
            this.equalSign2.Size = new System.Drawing.Size(80, 40);
            this.equalSign2.TabIndex = 22;
            this.equalSign2.Text = "=";
            this.equalSign2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSign3
            // 
            this.equalSign3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSign3.Location = new System.Drawing.Point(477, 419);
            this.equalSign3.Name = "equalSign3";
            this.equalSign3.Size = new System.Drawing.Size(80, 40);
            this.equalSign3.TabIndex = 23;
            this.equalSign3.Text = "=";
            this.equalSign3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalSign4
            // 
            this.equalSign4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalSign4.Location = new System.Drawing.Point(477, 536);
            this.equalSign4.Name = "equalSign4";
            this.equalSign4.Size = new System.Drawing.Size(80, 40);
            this.equalSign4.TabIndex = 24;
            this.equalSign4.Text = "=";
            this.equalSign4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(270, 619);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(270, 59);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start The Quiz";
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 700);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.equalSign4);
            this.Controls.Add(this.equalSign3);
            this.Controls.Add(this.equalSign2);
            this.Controls.Add(this.equalSign);
            this.Controls.Add(this.quotent);
            this.Controls.Add(this.divideLeft);
            this.Controls.Add(this.divideSign);
            this.Controls.Add(this.divideRight);
            this.Controls.Add(this.product);
            this.Controls.Add(this.diffrence);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.addRight);
            this.Controls.Add(this.subtractLeft);
            this.Controls.Add(this.subtractSign);
            this.Controls.Add(this.addLeft);
            this.Controls.Add(this.subtractRight);
            this.Controls.Add(this.multiplyLeft);
            this.Controls.Add(this.multiplySign);
            this.Controls.Add(this.multiplyRight);
            this.Controls.Add(this.addSign);
            this.Controls.Add(this.timeLeftTextBook);
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

        }

        #endregion
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLeftTextBook;
        private System.Windows.Forms.Label addSign;
        private System.Windows.Forms.Label multiplyRight;
        private System.Windows.Forms.Label multiplySign;
        private System.Windows.Forms.Label multiplyLeft;
        private System.Windows.Forms.Label subtractRight;
        private System.Windows.Forms.Label addLeft;
        private System.Windows.Forms.Label subtractSign;
        private System.Windows.Forms.Label subtractLeft;
        private System.Windows.Forms.Label addRight;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown diffrence;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.NumericUpDown quotent;
        private System.Windows.Forms.Label divideLeft;
        private System.Windows.Forms.Label divideSign;
        private System.Windows.Forms.Label divideRight;
        private System.Windows.Forms.Label equalSign;
        private System.Windows.Forms.Label equalSign2;
        private System.Windows.Forms.Label equalSign3;
        private System.Windows.Forms.Label equalSign4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

