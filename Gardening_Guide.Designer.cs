namespace EhlertProgram3
{
    partial class Gardening_Guide
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
            this.lblDirections = new System.Windows.Forms.Label();
            this.lstTreeChoices = new System.Windows.Forms.ListBox();
            this.lblTreeListBox = new System.Windows.Forms.Label();
            this.lblFlowersComboBox = new System.Windows.Forms.Label();
            this.lblTreeOutput = new System.Windows.Forms.Label();
            this.txtTreeOutput = new System.Windows.Forms.TextBox();
            this.lblFlowerOutput = new System.Windows.Forms.Label();
            this.txtFlowerOuput = new System.Windows.Forms.TextBox();
            this.cboFlowerChoice = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.BackColor = System.Drawing.Color.DarkBlue;
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.ForeColor = System.Drawing.Color.Yellow;
            this.lblDirections.Location = new System.Drawing.Point(632, 74);
            this.lblDirections.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(311, 39);
            this.lblDirections.TabIndex = 1;
            this.lblDirections.Text = "Mark your selection";
            // 
            // lstTreeChoices
            // 
            this.lstTreeChoices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTreeChoices.FormattingEnabled = true;
            this.lstTreeChoices.ItemHeight = 20;
            this.lstTreeChoices.Items.AddRange(new object[] {
            "Maple",
            "Palm",
            "Pine",
            "Oak",
            "Birch",
            "Buckeye",
            "Redwood"});
            this.lstTreeChoices.Location = new System.Drawing.Point(880, 252);
            this.lstTreeChoices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstTreeChoices.Name = "lstTreeChoices";
            this.lstTreeChoices.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstTreeChoices.Size = new System.Drawing.Size(178, 144);
            this.lstTreeChoices.TabIndex = 2;
            this.lstTreeChoices.SelectedIndexChanged += new System.EventHandler(this.lstTreeChoices_SelectedIndexChanged);
            // 
            // lblTreeListBox
            // 
            this.lblTreeListBox.AutoSize = true;
            this.lblTreeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreeListBox.ForeColor = System.Drawing.Color.Yellow;
            this.lblTreeListBox.Location = new System.Drawing.Point(934, 195);
            this.lblTreeListBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTreeListBox.Name = "lblTreeListBox";
            this.lblTreeListBox.Size = new System.Drawing.Size(66, 26);
            this.lblTreeListBox.TabIndex = 3;
            this.lblTreeListBox.Text = "Trees";
            // 
            // lblFlowersComboBox
            // 
            this.lblFlowersComboBox.AutoSize = true;
            this.lblFlowersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowersComboBox.ForeColor = System.Drawing.Color.Yellow;
            this.lblFlowersComboBox.Location = new System.Drawing.Point(634, 195);
            this.lblFlowersComboBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlowersComboBox.Name = "lblFlowersComboBox";
            this.lblFlowersComboBox.Size = new System.Drawing.Size(88, 26);
            this.lblFlowersComboBox.TabIndex = 4;
            this.lblFlowersComboBox.Text = "Flowers";
            // 
            // lblTreeOutput
            // 
            this.lblTreeOutput.AutoSize = true;
            this.lblTreeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTreeOutput.ForeColor = System.Drawing.Color.Yellow;
            this.lblTreeOutput.Location = new System.Drawing.Point(896, 525);
            this.lblTreeOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTreeOutput.Name = "lblTreeOutput";
            this.lblTreeOutput.Size = new System.Drawing.Size(175, 26);
            this.lblTreeOutput.TabIndex = 5;
            this.lblTreeOutput.Text = "Tree preferences";
            // 
            // txtTreeOutput
            // 
            this.txtTreeOutput.Location = new System.Drawing.Point(880, 587);
            this.txtTreeOutput.Multiline = true;
            this.txtTreeOutput.Name = "txtTreeOutput";
            this.txtTreeOutput.Size = new System.Drawing.Size(205, 121);
            this.txtTreeOutput.TabIndex = 6;
            // 
            // lblFlowerOutput
            // 
            this.lblFlowerOutput.AutoSize = true;
            this.lblFlowerOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowerOutput.Location = new System.Drawing.Point(634, 630);
            this.lblFlowerOutput.Name = "lblFlowerOutput";
            this.lblFlowerOutput.Size = new System.Drawing.Size(196, 25);
            this.lblFlowerOutput.TabIndex = 7;
            this.lblFlowerOutput.Text = "Flower preferences";
            // 
            // txtFlowerOuput
            // 
            this.txtFlowerOuput.Location = new System.Drawing.Point(608, 682);
            this.txtFlowerOuput.Name = "txtFlowerOuput";
            this.txtFlowerOuput.Size = new System.Drawing.Size(241, 26);
            this.txtFlowerOuput.TabIndex = 8;
            // 
            // cboFlowerChoice
            // 
            this.cboFlowerChoice.FormattingEnabled = true;
            this.cboFlowerChoice.Items.AddRange(new object[] {
            "Sunflower",
            "Petunia",
            "Marigold",
            "Dahlia",
            "Azalea",
            "Violets",
            "Rose"});
            this.cboFlowerChoice.Location = new System.Drawing.Point(515, 252);
            this.cboFlowerChoice.Name = "cboFlowerChoice";
            this.cboFlowerChoice.Size = new System.Drawing.Size(334, 28);
            this.cboFlowerChoice.TabIndex = 9;
            this.cboFlowerChoice.SelectedIndexChanged += new System.EventHandler(this.cboFlowerChoice_SelectedIndexChanged);
            this.cboFlowerChoice.TextChanged += new System.EventHandler(this.lstTreeChoices_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1630, 849);
            this.Controls.Add(this.cboFlowerChoice);
            this.Controls.Add(this.txtFlowerOuput);
            this.Controls.Add(this.lblFlowerOutput);
            this.Controls.Add(this.txtTreeOutput);
            this.Controls.Add(this.lblTreeOutput);
            this.Controls.Add(this.lblFlowersComboBox);
            this.Controls.Add(this.lblTreeListBox);
            this.Controls.Add(this.lstTreeChoices);
            this.Controls.Add(this.lblDirections);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Yellow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Gardening Guide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.ListBox lstTreeChoices;
        private System.Windows.Forms.Label lblTreeListBox;
        private System.Windows.Forms.Label lblFlowersComboBox;
        private System.Windows.Forms.Label lblTreeOutput;
        private System.Windows.Forms.TextBox txtTreeOutput;
        private System.Windows.Forms.Label lblFlowerOutput;
        private System.Windows.Forms.TextBox txtFlowerOuput;
        private System.Windows.Forms.ComboBox cboFlowerChoice;
    }
}

