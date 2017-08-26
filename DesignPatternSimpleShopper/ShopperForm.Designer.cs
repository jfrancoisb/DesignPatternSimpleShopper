using DesignPatternSimpleShopper.ShopperAdapters;

namespace DesignPatternSimpleShopper
{
    partial class ShopperForm
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
            this.taxesCalculationTextBox = new System.Windows.Forms.TextBox();
            this.sellingItemsListBox = new System.Windows.Forms.ListBox();
            this.availableItemsToPurchase = new System.Windows.Forms.ComboBox();
            this.selectItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taxesCalculationTextBox
            // 
            this.taxesCalculationTextBox.Location = new System.Drawing.Point(12, 276);
            this.taxesCalculationTextBox.Multiline = true;
            this.taxesCalculationTextBox.Name = "taxesCalculationTextBox";
            this.taxesCalculationTextBox.Size = new System.Drawing.Size(264, 120);
            this.taxesCalculationTextBox.TabIndex = 0;
            // 
            // sellingItemsListBox
            // 
            this.sellingItemsListBox.FormattingEnabled = true;
            this.sellingItemsListBox.Location = new System.Drawing.Point(12, 93);
            this.sellingItemsListBox.Name = "sellingItemsListBox";
            this.sellingItemsListBox.Size = new System.Drawing.Size(367, 160);
            this.sellingItemsListBox.TabIndex = 2;
            // 
            // availableItemsToPurchase
            // 
            this.availableItemsToPurchase.FormattingEnabled = true;
            this.availableItemsToPurchase.Location = new System.Drawing.Point(12, 53);
            this.availableItemsToPurchase.Name = "availableItemsToPurchase";
            this.availableItemsToPurchase.Size = new System.Drawing.Size(367, 21);
            this.availableItemsToPurchase.TabIndex = 3;
            // 
            // selectItemButton
            // 
            this.selectItemButton.Location = new System.Drawing.Point(394, 51);
            this.selectItemButton.Name = "selectItemButton";
            this.selectItemButton.Size = new System.Drawing.Size(75, 23);
            this.selectItemButton.TabIndex = 5;
            this.selectItemButton.Text = "Select Item";
            this.selectItemButton.UseVisualStyleBackColor = true;
            // 
            // ShopperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 418);
            this.Controls.Add(this.selectItemButton);
            this.Controls.Add(this.availableItemsToPurchase);
            this.Controls.Add(this.sellingItemsListBox);
            this.Controls.Add(this.taxesCalculationTextBox);
            this.Name = "ShopperForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox taxesCalculationTextBox;
        private System.Windows.Forms.ListBox sellingItemsListBox;
        private System.Windows.Forms.ComboBox availableItemsToPurchase;
        private System.Windows.Forms.Button selectItemButton;

    }
}

