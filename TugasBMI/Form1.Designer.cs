namespace TugasBMI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBoxWeight = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.inputWeight = new System.Windows.Forms.NumericUpDown();
            this.groupBoxHeight = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.inputHeight = new System.Windows.Forms.NumericUpDown();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.labelClassification = new System.Windows.Forms.Label();
            this.classification = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBoxWeight.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).BeginInit();
            this.groupBoxHeight.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.groupBoxWeight);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxHeight);
            this.flowLayoutPanel1.Controls.Add(this.buttonSubmit);
            this.flowLayoutPanel1.Controls.Add(this.labelResult);
            this.flowLayoutPanel1.Controls.Add(this.result);
            this.flowLayoutPanel1.Controls.Add(this.labelClassification);
            this.flowLayoutPanel1.Controls.Add(this.classification);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(144, 239);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // groupBoxWeight
            // 
            this.groupBoxWeight.AutoSize = true;
            this.groupBoxWeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxWeight.Controls.Add(this.flowLayoutPanel2);
            this.groupBoxWeight.Location = new System.Drawing.Point(3, 3);
            this.groupBoxWeight.Name = "groupBoxWeight";
            this.groupBoxWeight.Size = new System.Drawing.Size(138, 64);
            this.groupBoxWeight.TabIndex = 0;
            this.groupBoxWeight.TabStop = false;
            this.groupBoxWeight.Text = "Berat Badan (kg)";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.inputWeight);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(126, 26);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // inputWeight
            // 
            this.inputWeight.Location = new System.Drawing.Point(3, 3);
            this.inputWeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(120, 20);
            this.inputWeight.TabIndex = 0;
            // 
            // groupBoxHeight
            // 
            this.groupBoxHeight.AutoSize = true;
            this.groupBoxHeight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxHeight.Controls.Add(this.flowLayoutPanel3);
            this.groupBoxHeight.Location = new System.Drawing.Point(3, 73);
            this.groupBoxHeight.Name = "groupBoxHeight";
            this.groupBoxHeight.Size = new System.Drawing.Size(138, 64);
            this.groupBoxHeight.TabIndex = 1;
            this.groupBoxHeight.TabStop = false;
            this.groupBoxHeight.Text = "Tinggi Badan (cm)";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel3.Controls.Add(this.inputHeight);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(126, 26);
            this.flowLayoutPanel3.TabIndex = 2;
            // 
            // inputHeight
            // 
            this.inputHeight.Location = new System.Drawing.Point(3, 3);
            this.inputHeight.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            this.inputHeight.Name = "inputHeight";
            this.inputHeight.Size = new System.Drawing.Size(120, 20);
            this.inputHeight.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.AutoSize = true;
            this.buttonSubmit.Location = new System.Drawing.Point(3, 143);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(138, 23);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Klasifikasi";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(3, 169);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 13);
            this.labelResult.TabIndex = 1;
            this.labelResult.Text = "Hasil BMI:";
            // 
            // result
            // 
            this.result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(3, 182);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(138, 20);
            this.result.TabIndex = 2;
            this.result.Text = "_________";
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelClassification
            // 
            this.labelClassification.AutoSize = true;
            this.labelClassification.Location = new System.Drawing.Point(3, 206);
            this.labelClassification.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.labelClassification.Name = "labelClassification";
            this.labelClassification.Size = new System.Drawing.Size(56, 13);
            this.labelClassification.TabIndex = 2;
            this.labelClassification.Text = "Klasifikasi:";
            // 
            // classification
            // 
            this.classification.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.classification.AutoSize = true;
            this.classification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classification.Location = new System.Drawing.Point(3, 219);
            this.classification.Name = "classification";
            this.classification.Size = new System.Drawing.Size(138, 20);
            this.classification.TabIndex = 3;
            this.classification.Text = "_________";
            this.classification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(159, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 239);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(510, 300);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBoxWeight.ResumeLayout(false);
            this.groupBoxWeight.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputWeight)).EndInit();
            this.groupBoxHeight.ResumeLayout(false);
            this.groupBoxHeight.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelClassification;
        private System.Windows.Forms.Label classification;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label result;

        private System.Windows.Forms.Label labelResult;

        private System.Windows.Forms.GroupBox groupBoxWeight;
        private System.Windows.Forms.NumericUpDown inputWeight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.NumericUpDown inputHeight;
        private System.Windows.Forms.Button buttonSubmit;

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBoxHeight;

        #endregion
    }
}