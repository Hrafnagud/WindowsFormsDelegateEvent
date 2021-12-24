
namespace WindowsFormsDelegateEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFirstNumber = new System.Windows.Forms.TextBox();
            this.textBoxSecondNumber = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnOperation = new System.Windows.Forms.Button();
            this.btnControl = new System.Windows.Forms.Button();
            this.btnIsClicked = new System.Windows.Forms.Button();
            this.btnPositiveResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number:";
            // 
            // textBoxFirstNumber
            // 
            this.textBoxFirstNumber.Location = new System.Drawing.Point(311, 56);
            this.textBoxFirstNumber.Name = "textBoxFirstNumber";
            this.textBoxFirstNumber.Size = new System.Drawing.Size(384, 22);
            this.textBoxFirstNumber.TabIndex = 2;
            // 
            // textBoxSecondNumber
            // 
            this.textBoxSecondNumber.Location = new System.Drawing.Point(311, 104);
            this.textBoxSecondNumber.Name = "textBoxSecondNumber";
            this.textBoxSecondNumber.Size = new System.Drawing.Size(384, 22);
            this.textBoxSecondNumber.TabIndex = 3;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(134, 164);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(561, 51);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(134, 230);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(561, 52);
            this.btnOperation.TabIndex = 5;
            this.btnOperation.Text = "Add and Multiply";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(134, 372);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(271, 46);
            this.btnControl.TabIndex = 6;
            this.btnControl.Text = "Control";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // btnIsClicked
            // 
            this.btnIsClicked.Location = new System.Drawing.Point(434, 372);
            this.btnIsClicked.Name = "btnIsClicked";
            this.btnIsClicked.Size = new System.Drawing.Size(261, 46);
            this.btnIsClicked.TabIndex = 7;
            this.btnIsClicked.Text = "isClicked?";
            this.btnIsClicked.UseVisualStyleBackColor = true;
            // 
            // btnPositiveResult
            // 
            this.btnPositiveResult.Location = new System.Drawing.Point(134, 305);
            this.btnPositiveResult.Name = "btnPositiveResult";
            this.btnPositiveResult.Size = new System.Drawing.Size(561, 49);
            this.btnPositiveResult.TabIndex = 8;
            this.btnPositiveResult.Text = "Operate Only Positive Numbers";
            this.btnPositiveResult.UseVisualStyleBackColor = true;
            this.btnPositiveResult.Click += new System.EventHandler(this.btnPositiveResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 430);
            this.Controls.Add(this.btnPositiveResult);
            this.Controls.Add(this.btnIsClicked);
            this.Controls.Add(this.btnControl);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.textBoxSecondNumber);
            this.Controls.Add(this.textBoxFirstNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFirstNumber;
        private System.Windows.Forms.TextBox textBoxSecondNumber;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Button btnIsClicked;
        private System.Windows.Forms.Button btnPositiveResult;
    }
}

