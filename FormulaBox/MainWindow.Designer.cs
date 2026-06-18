
namespace FormulaBox
{
    partial class MainWindow
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
            label1 = new Label();
            formulaBox = new TextBox();
            label2 = new Label();
            variableList = new ListView();
            sampleButton = new Button();
            calculateButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 7);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 0;
            label1.Text = "Formula Text:";
            // 
            // formulaBox
            // 
            formulaBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            formulaBox.Location = new Point(10, 24);
            formulaBox.Margin = new Padding(3, 2, 3, 2);
            formulaBox.Name = "formulaBox";
            formulaBox.Size = new Size(310, 23);
            formulaBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 58);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 2;
            label2.Text = "Variables:";
            // 
            // variableList
            // 
            variableList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            variableList.Location = new Point(10, 75);
            variableList.Margin = new Padding(3, 2, 3, 2);
            variableList.Name = "variableList";
            variableList.Size = new Size(414, 218);
            variableList.TabIndex = 3;
            variableList.UseCompatibleStateImageBehavior = false;
            // 
            // sampleButton
            // 
            sampleButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sampleButton.Location = new Point(326, 23);
            sampleButton.Margin = new Padding(3, 2, 3, 2);
            sampleButton.Name = "sampleButton";
            sampleButton.Size = new Size(98, 22);
            sampleButton.TabIndex = 4;
            sampleButton.Text = "Sample";
            sampleButton.UseVisualStyleBackColor = true;
            sampleButton.Click += sampleButton_Click;
            // 
            // calculateButton
            // 
            calculateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            calculateButton.Location = new Point(10, 296);
            calculateButton.Margin = new Padding(3, 2, 3, 2);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(413, 22);
            calculateButton.TabIndex = 5;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 327);
            Controls.Add(calculateButton);
            Controls.Add(sampleButton);
            Controls.Add(variableList);
            Controls.Add(label2);
            Controls.Add(formulaBox);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainWindow";
            Text = "Formula Box";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox formulaBox;
        private Label label2;
        private ListView variableList;
        private Button sampleButton;
        private Button calculateButton;
    }
}
