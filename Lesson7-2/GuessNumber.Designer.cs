
namespace Lesson7_2
{
    partial class GuessNumber
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GuessNumberHeaderLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GuessedNumberResultLabel = new System.Windows.Forms.Label();
            this.CheckGuessedNumberButton = new System.Windows.Forms.Button();
            this.GuessedNumberTextLabel = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.GuessNumberHeaderLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1698, 567);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // GuessNumberHeaderLabel
            // 
            this.GuessNumberHeaderLabel.AutoSize = true;
            this.GuessNumberHeaderLabel.Font = new System.Drawing.Font("Ravie", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessNumberHeaderLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.GuessNumberHeaderLabel.Location = new System.Drawing.Point(260, 0);
            this.GuessNumberHeaderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GuessNumberHeaderLabel.Name = "GuessNumberHeaderLabel";
            this.GuessNumberHeaderLabel.Size = new System.Drawing.Size(860, 142);
            this.GuessNumberHeaderLabel.TabIndex = 0;
            this.GuessNumberHeaderLabel.Text = "Угадай число";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.GuessedNumberResultLabel);
            this.panel1.Controls.Add(this.CheckGuessedNumberButton);
            this.panel1.Controls.Add(this.GuessedNumberTextLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(260, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 384);
            this.panel1.TabIndex = 1;
            // 
            // GuessedNumberResultLabel
            // 
            this.GuessedNumberResultLabel.AutoSize = true;
            this.GuessedNumberResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessedNumberResultLabel.Location = new System.Drawing.Point(6, 142);
            this.GuessedNumberResultLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.GuessedNumberResultLabel.Name = "GuessedNumberResultLabel";
            this.GuessedNumberResultLabel.Size = new System.Drawing.Size(82, 126);
            this.GuessedNumberResultLabel.TabIndex = 2;
            this.GuessedNumberResultLabel.Text = " ";
            // 
            // CheckGuessedNumberButton
            // 
            this.CheckGuessedNumberButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.CheckGuessedNumberButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckGuessedNumberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CheckGuessedNumberButton.Location = new System.Drawing.Point(346, 6);
            this.CheckGuessedNumberButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CheckGuessedNumberButton.Name = "CheckGuessedNumberButton";
            this.CheckGuessedNumberButton.Size = new System.Drawing.Size(348, 73);
            this.CheckGuessedNumberButton.TabIndex = 1;
            this.CheckGuessedNumberButton.Text = "Проверить";
            this.CheckGuessedNumberButton.UseVisualStyleBackColor = false;
            this.CheckGuessedNumberButton.Click += new System.EventHandler(this.CheckGuessedNumberButton_Click);
            // 
            // GuessedNumberTextLabel
            // 
            this.GuessedNumberTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuessedNumberTextLabel.Location = new System.Drawing.Point(6, 6);
            this.GuessedNumberTextLabel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.GuessedNumberTextLabel.Name = "GuessedNumberTextLabel";
            this.GuessedNumberTextLabel.Size = new System.Drawing.Size(324, 68);
            this.GuessedNumberTextLabel.TabIndex = 0;
            this.GuessedNumberTextLabel.TextChanged += new System.EventHandler(this.GuessedNumberTextLabel_TextChanged);
            // 
            // GuessNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1698, 567);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "GuessNumber";
            this.Text = "GuessNumber";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label GuessNumberHeaderLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label GuessedNumberResultLabel;
        private System.Windows.Forms.Button CheckGuessedNumberButton;
        private System.Windows.Forms.TextBox GuessedNumberTextLabel;
    }
}