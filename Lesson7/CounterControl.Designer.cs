
namespace Lesson7
{
    partial class CounterControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelTurn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.labelSum = new System.Windows.Forms.Label();
            this.labelTextSum = new System.Windows.Forms.Label();
            this.labelCommandCountText = new System.Windows.Forms.Label();
            this.labelCommandCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelTurn);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnCommand2);
            this.panel1.Controls.Add(this.btnCommand1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(600, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 962);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelTurn
            // 
            this.btnCancelTurn.BackColor = System.Drawing.SystemColors.Info;
            this.btnCancelTurn.Enabled = false;
            this.btnCancelTurn.Location = new System.Drawing.Point(6, 508);
            this.btnCancelTurn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCancelTurn.Name = "btnCancelTurn";
            this.btnCancelTurn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCancelTurn.Size = new System.Drawing.Size(388, 154);
            this.btnCancelTurn.TabIndex = 3;
            this.btnCancelTurn.Text = "Отмена хода";
            this.btnCancelTurn.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.Info;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(6, 342);
            this.btnReset.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnReset.Name = "btnReset";
            this.btnReset.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnReset.Size = new System.Drawing.Size(388, 154);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCommand2.Enabled = false;
            this.btnCommand2.Location = new System.Drawing.Point(6, 177);
            this.btnCommand2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(388, 154);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = false;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnCommand1
            // 
            this.btnCommand1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCommand1.Enabled = false;
            this.btnCommand1.Location = new System.Drawing.Point(6, 12);
            this.btnCommand1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(388, 154);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = false;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSum.Location = new System.Drawing.Point(262, 12);
            this.labelSum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(57, 63);
            this.labelSum.TabIndex = 1;
            this.labelSum.Text = "0";
            // 
            // labelTextSum
            // 
            this.labelTextSum.AutoSize = true;
            this.labelTextSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextSum.Location = new System.Drawing.Point(32, 12);
            this.labelTextSum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelTextSum.Name = "labelTextSum";
            this.labelTextSum.Size = new System.Drawing.Size(216, 63);
            this.labelTextSum.TabIndex = 2;
            this.labelTextSum.Text = "Сумма:";
            // 
            // labelCommandCountText
            // 
            this.labelCommandCountText.AutoSize = true;
            this.labelCommandCountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommandCountText.Location = new System.Drawing.Point(36, 104);
            this.labelCommandCountText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCommandCountText.Name = "labelCommandCountText";
            this.labelCommandCountText.Size = new System.Drawing.Size(379, 44);
            this.labelCommandCountText.TabIndex = 3;
            this.labelCommandCountText.Text = "Количество команд:";
            // 
            // labelCommandCount
            // 
            this.labelCommandCount.AutoSize = true;
            this.labelCommandCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommandCount.Location = new System.Drawing.Point(434, 106);
            this.labelCommandCount.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelCommandCount.Name = "labelCommandCount";
            this.labelCommandCount.Size = new System.Drawing.Size(57, 63);
            this.labelCommandCount.TabIndex = 4;
            this.labelCommandCount.Text = "0";
            // 
            // CounterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCommandCount);
            this.Controls.Add(this.labelCommandCountText);
            this.Controls.Add(this.labelTextSum);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CounterControl";
            this.Size = new System.Drawing.Size(1000, 962);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label labelTextSum;
        private System.Windows.Forms.Label labelCommandCountText;
        private System.Windows.Forms.Label labelCommandCount;
        private System.Windows.Forms.Button btnCancelTurn;
    }
}
