namespace DynamicArrayWinForms
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
            this.txtElement = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtSearchValue = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAddToEnd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSumZeros = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.lblArray = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtElement
            // 
            this.txtElement.Location = new System.Drawing.Point(20, 20);
            this.txtElement.Name = "txtElement";
            this.txtElement.Size = new System.Drawing.Size(100, 20);
            this.txtElement.TabIndex = 0;
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(130, 20);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(50, 20);
            this.txtIndex.TabIndex = 0;
            // 
            // txtSearchValue
            // 
            this.txtSearchValue.Location = new System.Drawing.Point(20, 50);
            this.txtSearchValue.Name = "txtSearchValue";
            this.txtSearchValue.Size = new System.Drawing.Size(100, 20);
            this.txtSearchValue.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(190, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnAddToEnd
            // 
            this.btnAddToEnd.Location = new System.Drawing.Point(280, 20);
            this.btnAddToEnd.Name = "btnAddToEnd";
            this.btnAddToEnd.Size = new System.Drawing.Size(100, 23);
            this.btnAddToEnd.TabIndex = 1;
            this.btnAddToEnd.Text = "Додати в кінець";
            this.btnAddToEnd.UseVisualStyleBackColor = true;
            this.btnAddToEnd.Click += new System.EventHandler(this.BtnAddToEnd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(390, 20);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(80, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Видалити ";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(130, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Шукати";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(20, 130);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(120, 23);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Добуток парних";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.BtnProduct_Click);
            // 
            // btnSumZeros
            // 
            this.btnSumZeros.Location = new System.Drawing.Point(150, 130);
            this.btnSumZeros.Name = "btnSumZeros";
            this.btnSumZeros.Size = new System.Drawing.Size(120, 23);
            this.btnSumZeros.TabIndex = 1;
            this.btnSumZeros.Text = "Сума між нулями";
            this.btnSumZeros.UseVisualStyleBackColor = true;
            this.btnSumZeros.Click += new System.EventHandler(this.BtnSumZeros_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(280, 130);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(120, 23);
            this.btnSort.TabIndex = 1;
            this.btnSort.Text = "Сортувати";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.BtnSort_Click);
            // 
            // lblArray
            // 
            this.lblArray.Location = new System.Drawing.Point(20, 80);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(500, 40);
            this.lblArray.TabIndex = 2;
            this.lblArray.Text = "Масив:";
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(20, 160);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(500, 40);
            this.lblResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 231);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnSumZeros);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddToEnd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearchValue);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtElement);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtElement;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtSearchValue;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAddToEnd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSumZeros;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.Label lblResult;
    }
}

