namespace FormulaBox
{
    partial class Variable
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
            variableTitle = new Label();
            variableValue = new TextBox();
            SuspendLayout();
            // 
            // variableTitle
            // 
            variableTitle.AutoSize = true;
            variableTitle.Location = new Point(5, 6);
            variableTitle.Name = "variableTitle";
            variableTitle.Size = new Size(89, 15);
            variableTitle.TabIndex = 0;
            variableTitle.Text = "VARIABLE HERE";
            // 
            // variableValue
            // 
            variableValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            variableValue.Location = new Point(100, 4);
            variableValue.Name = "variableValue";
            variableValue.Size = new Size(174, 23);
            variableValue.TabIndex = 2;
            // 
            // Variable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(variableValue);
            Controls.Add(variableTitle);
            Name = "Variable";
            Size = new Size(279, 30);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label variableTitle;
        private TextBox variableValue;
    }
}
