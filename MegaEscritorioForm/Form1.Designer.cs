namespace MegaEscritorioForm
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
            this.numberDays = new System.Windows.Forms.ComboBox();
            this.numberDrawers = new System.Windows.Forms.ComboBox();
            this.wid = new System.Windows.Forms.TextBox();
            this.len = new System.Windows.Forms.TextBox();
            this.enterWid = new System.Windows.Forms.Label();
            this.enterLen = new System.Windows.Forms.Label();
            this.drawers = new System.Windows.Forms.Label();
            this.material = new System.Windows.Forms.Label();
            this.surfaceMaterial = new System.Windows.Forms.ComboBox();
            this.days = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.heading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberDays
            // 
            this.numberDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberDays.FormattingEnabled = true;
            this.numberDays.Items.AddRange(new object[] {
            "3",
            "5 ",
            "7 ",
            "14"});
            this.numberDays.Location = new System.Drawing.Point(565, 216);
            this.numberDays.Margin = new System.Windows.Forms.Padding(6);
            this.numberDays.Name = "numberDays";
            this.numberDays.Size = new System.Drawing.Size(100, 33);
            this.numberDays.TabIndex = 5;
            // 
            // numberDrawers
            // 
            this.numberDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberDrawers.FormattingEnabled = true;
            this.numberDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.numberDrawers.Location = new System.Drawing.Point(565, 87);
            this.numberDrawers.Margin = new System.Windows.Forms.Padding(6);
            this.numberDrawers.Name = "numberDrawers";
            this.numberDrawers.Size = new System.Drawing.Size(100, 33);
            this.numberDrawers.TabIndex = 3;
            // 
            // wid
            // 
            this.wid.Location = new System.Drawing.Point(214, 124);
            this.wid.Margin = new System.Windows.Forms.Padding(6);
            this.wid.Name = "wid";
            this.wid.Size = new System.Drawing.Size(100, 31);
            this.wid.TabIndex = 1;
            // 
            // len
            // 
            this.len.Location = new System.Drawing.Point(214, 187);
            this.len.Margin = new System.Windows.Forms.Padding(6);
            this.len.Name = "len";
            this.len.Size = new System.Drawing.Size(100, 31);
            this.len.TabIndex = 2;
            // 
            // enterWid
            // 
            this.enterWid.AutoSize = true;
            this.enterWid.Location = new System.Drawing.Point(35, 124);
            this.enterWid.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.enterWid.Name = "enterWid";
            this.enterWid.Size = new System.Drawing.Size(161, 25);
            this.enterWid.TabIndex = 0;
            this.enterWid.Text = "Enter Width (in)";
            // 
            // enterLen
            // 
            this.enterLen.AutoSize = true;
            this.enterLen.Location = new System.Drawing.Point(35, 187);
            this.enterLen.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.enterLen.Name = "enterLen";
            this.enterLen.Size = new System.Drawing.Size(172, 25);
            this.enterLen.TabIndex = 0;
            this.enterLen.Text = "Enter Length (in)";
            // 
            // drawers
            // 
            this.drawers.AutoSize = true;
            this.drawers.Location = new System.Drawing.Point(372, 96);
            this.drawers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(133, 25);
            this.drawers.TabIndex = 0;
            this.drawers.Text = "# of Drawers";
            // 
            // material
            // 
            this.material.AutoSize = true;
            this.material.Location = new System.Drawing.Point(372, 160);
            this.material.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.material.Name = "material";
            this.material.Size = new System.Drawing.Size(169, 25);
            this.material.TabIndex = 0;
            this.material.Text = "Surface Material";
            // 
            // surfaceMaterial
            // 
            this.surfaceMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.surfaceMaterial.FormattingEnabled = true;
            this.surfaceMaterial.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine"});
            this.surfaceMaterial.Location = new System.Drawing.Point(565, 152);
            this.surfaceMaterial.Margin = new System.Windows.Forms.Padding(6);
            this.surfaceMaterial.Name = "surfaceMaterial";
            this.surfaceMaterial.Size = new System.Drawing.Size(100, 33);
            this.surfaceMaterial.TabIndex = 4;
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Location = new System.Drawing.Point(375, 221);
            this.days.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(117, 25);
            this.days.TabIndex = 0;
            this.days.Text = "Rush Days";
            // 
            // total
            // 
            this.total.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(271, 283);
            this.total.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(121, 42);
            this.total.TabIndex = 12;
            this.total.Text = "Total: ";
            this.total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.calculate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.calculate.Location = new System.Drawing.Point(214, 356);
            this.calculate.Margin = new System.Windows.Forms.Padding(6);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(260, 44);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Click for Price Estimate";
            this.calculate.UseVisualStyleBackColor = false;
            this.calculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.heading.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.ForeColor = System.Drawing.SystemColors.Desktop;
            this.heading.Location = new System.Drawing.Point(166, 9);
            this.heading.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(375, 46);
            this.heading.TabIndex = 14;
            this.heading.Text = "Mega Escritorio Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 446);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.total);
            this.Controls.Add(this.days);
            this.Controls.Add(this.surfaceMaterial);
            this.Controls.Add(this.material);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.enterLen);
            this.Controls.Add(this.enterWid);
            this.Controls.Add(this.len);
            this.Controls.Add(this.wid);
            this.Controls.Add(this.numberDrawers);
            this.Controls.Add(this.numberDays);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox numberDays;
        private System.Windows.Forms.ComboBox numberDrawers;
        private System.Windows.Forms.TextBox wid;
        private System.Windows.Forms.TextBox len;
        private System.Windows.Forms.Label enterWid;
        private System.Windows.Forms.Label enterLen;
        private System.Windows.Forms.Label drawers;
        private System.Windows.Forms.Label material;
        private System.Windows.Forms.ComboBox surfaceMaterial;
        private System.Windows.Forms.Label days;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label heading;
    }
}

