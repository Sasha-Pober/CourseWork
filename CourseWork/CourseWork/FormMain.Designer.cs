
namespace CourseWork
{
    partial class FormMain
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
            this.GotoCuisines = new System.Windows.Forms.Button();
            this.OrderMeal = new System.Windows.Forms.Button();
            this.GenerateDinner = new System.Windows.Forms.Button();
            this.CoockedMealsBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.InsertMealBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(357, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose option";
            // 
            // GotoCuisines
            // 
            this.GotoCuisines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.GotoCuisines.Location = new System.Drawing.Point(104, 72);
            this.GotoCuisines.Margin = new System.Windows.Forms.Padding(2);
            this.GotoCuisines.Name = "GotoCuisines";
            this.GotoCuisines.Size = new System.Drawing.Size(178, 118);
            this.GotoCuisines.TabIndex = 1;
            this.GotoCuisines.Text = "Available Meals";
            this.GotoCuisines.UseVisualStyleBackColor = true;
            this.GotoCuisines.Click += new System.EventHandler(this.GotoCuisines_Click);
            // 
            // OrderMeal
            // 
            this.OrderMeal.Location = new System.Drawing.Point(332, 74);
            this.OrderMeal.Margin = new System.Windows.Forms.Padding(2);
            this.OrderMeal.Name = "OrderMeal";
            this.OrderMeal.Size = new System.Drawing.Size(177, 116);
            this.OrderMeal.TabIndex = 2;
            this.OrderMeal.Text = "Order a Meal";
            this.OrderMeal.UseVisualStyleBackColor = true;
            this.OrderMeal.Click += new System.EventHandler(this.OrderMeal_Click);
            // 
            // GenerateDinner
            // 
            this.GenerateDinner.Location = new System.Drawing.Point(566, 74);
            this.GenerateDinner.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateDinner.Name = "GenerateDinner";
            this.GenerateDinner.Size = new System.Drawing.Size(182, 118);
            this.GenerateDinner.TabIndex = 3;
            this.GenerateDinner.Text = "Generate a Dinner";
            this.GenerateDinner.UseVisualStyleBackColor = true;
            this.GenerateDinner.Click += new System.EventHandler(this.GenerateDinner_Click);
            // 
            // CoockedMealsBtn
            // 
            this.CoockedMealsBtn.Location = new System.Drawing.Point(104, 218);
            this.CoockedMealsBtn.Name = "CoockedMealsBtn";
            this.CoockedMealsBtn.Size = new System.Drawing.Size(405, 159);
            this.CoockedMealsBtn.TabIndex = 4;
            this.CoockedMealsBtn.Text = "Show Coocked Meals";
            this.CoockedMealsBtn.UseVisualStyleBackColor = true;
            this.CoockedMealsBtn.Click += new System.EventHandler(this.CoockedMealsBtn_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(815, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InsertMealBtn
            // 
            this.InsertMealBtn.Location = new System.Drawing.Point(566, 223);
            this.InsertMealBtn.Name = "InsertMealBtn";
            this.InsertMealBtn.Size = new System.Drawing.Size(181, 153);
            this.InsertMealBtn.TabIndex = 6;
            this.InsertMealBtn.Text = "Add Meal Manually";
            this.InsertMealBtn.UseVisualStyleBackColor = true;
            this.InsertMealBtn.Click += new System.EventHandler(this.InsertMealBtn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(860, 411);
            this.ControlBox = false;
            this.Controls.Add(this.InsertMealBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CoockedMealsBtn);
            this.Controls.Add(this.GenerateDinner);
            this.Controls.Add(this.OrderMeal);
            this.Controls.Add(this.GotoCuisines);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GotoCuisines;
        private System.Windows.Forms.Button OrderMeal;
        private System.Windows.Forms.Button GenerateDinner;
        private System.Windows.Forms.Button CoockedMealsBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button InsertMealBtn;
    }
}

