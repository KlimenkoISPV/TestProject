
namespace TestProject
{
    partial class Klimenko
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.volkovButton = new System.Windows.Forms.Button();
            this.klimenkoButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.volkovButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.klimenkoButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(625, 299);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // volkovButton
            // 
            this.volkovButton.Location = new System.Drawing.Point(3, 3);
            this.volkovButton.Name = "volkovButton";
            this.volkovButton.Size = new System.Drawing.Size(75, 23);
            this.volkovButton.TabIndex = 0;
            this.volkovButton.Text = "Волков";
            this.volkovButton.UseVisualStyleBackColor = true;
            this.volkovButton.Click += new System.EventHandler(this.VolkovButton_Click);
            // 
            // klimenkoButton
            // 
            this.klimenkoButton.Location = new System.Drawing.Point(159, 3);
            this.klimenkoButton.Name = "klimenkoButton";
            this.klimenkoButton.Size = new System.Drawing.Size(75, 23);
            this.klimenkoButton.TabIndex = 1;
            this.klimenkoButton.Text = "Клименко";
            this.klimenkoButton.UseVisualStyleBackColor = true;
            this.klimenkoButton.Click += new System.EventHandler(this.klimenkoButton_Click);
            // 
            // Klimenko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 324);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Klimenko";
            this.Text = "Главная форма";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button volkovButton;
        private System.Windows.Forms.Button klimenkoButton;
    }
}

