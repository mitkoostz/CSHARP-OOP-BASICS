namespace MyCalories
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
            this.ateFoods = new System.Windows.Forms.ListBox();
            this.removeFood = new System.Windows.Forms.Button();
            this.foodTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.foodForAdd = new System.Windows.Forms.ListBox();
            this.addFood = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Sans", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "All foods you ate today:";
            // 
            // ateFoods
            // 
            this.ateFoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ateFoods.FormattingEnabled = true;
            this.ateFoods.ItemHeight = 18;
            this.ateFoods.Location = new System.Drawing.Point(32, 100);
            this.ateFoods.Name = "ateFoods";
            this.ateFoods.Size = new System.Drawing.Size(580, 274);
            this.ateFoods.TabIndex = 1;
            this.ateFoods.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // removeFood
            // 
            this.removeFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeFood.Location = new System.Drawing.Point(234, 394);
            this.removeFood.Name = "removeFood";
            this.removeFood.Size = new System.Drawing.Size(107, 33);
            this.removeFood.TabIndex = 2;
            this.removeFood.Text = "Remove";
            this.removeFood.UseVisualStyleBackColor = true;
            this.removeFood.Click += new System.EventHandler(this.removeFood_Click);
            // 
            // foodTitle
            // 
            this.foodTitle.AutoSize = true;
            this.foodTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.foodTitle.Location = new System.Drawing.Point(26, 66);
            this.foodTitle.Name = "foodTitle";
            this.foodTitle.Size = new System.Drawing.Size(80, 31);
            this.foodTitle.TabIndex = 3;
            this.foodTitle.Text = "Food";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(218, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Amaunt";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(657, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Search foods....";
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // foodForAdd
            // 
            this.foodForAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodForAdd.FormattingEnabled = true;
            this.foodForAdd.ItemHeight = 19;
            this.foodForAdd.Location = new System.Drawing.Point(686, 103);
            this.foodForAdd.Name = "foodForAdd";
            this.foodForAdd.Size = new System.Drawing.Size(158, 213);
            this.foodForAdd.TabIndex = 6;
            // 
            // addFood
            // 
            this.addFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addFood.Location = new System.Drawing.Point(715, 389);
            this.addFood.Name = "addFood";
            this.addFood.Size = new System.Drawing.Size(94, 43);
            this.addFood.TabIndex = 7;
            this.addFood.Text = "Add";
            this.addFood.UseVisualStyleBackColor = true;
            this.addFood.Click += new System.EventHandler(this.addFood_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(755, 341);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(31, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "544";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(697, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "amaunt";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(792, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "(in grams)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 459);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.addFood);
            this.Controls.Add(this.foodForAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.foodTitle);
            this.Controls.Add(this.removeFood);
            this.Controls.Add(this.ateFoods);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "My Calories";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ateFoods;
        private System.Windows.Forms.Button removeFood;
        private System.Windows.Forms.Label foodTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox foodForAdd;
        private System.Windows.Forms.Button addFood;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

