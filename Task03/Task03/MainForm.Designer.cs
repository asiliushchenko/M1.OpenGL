
namespace Task03
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderControl1 = new RenderControl();
            Function1 = new System.Windows.Forms.RadioButton();
            Function2 = new System.Windows.Forms.RadioButton();
            MinXvalue = new System.Windows.Forms.NumericUpDown();
            MaxXvalue = new System.Windows.Forms.NumericUpDown();
            MinYvalue = new System.Windows.Forms.NumericUpDown();
            NumberOfPoints = new System.Windows.Forms.NumericUpDown();
            MaxYvalue = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            buttonShowY = new System.Windows.Forms.Button();
            MenuY = new System.Windows.Forms.GroupBox();
            Functions = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)MinXvalue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxXvalue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinYvalue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaxYvalue).BeginInit();
            MenuY.SuspendLayout();
            Functions.SuspendLayout();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.function = 0;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.MaxX = 3D;
            renderControl1.MaxY = 3D;
            renderControl1.MinX = -3D;
            renderControl1.MinY = -3D;
            renderControl1.Name = "renderControl1";
            renderControl1.showY = true;
            renderControl1.Size = new System.Drawing.Size(489, 391);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 65001;
            // 
            // Function1
            // 
            Function1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            Function1.Checked = true;
            Function1.Image = (System.Drawing.Image)resources.GetObject("Function1.Image");
            Function1.Location = new System.Drawing.Point(6, 22);
            Function1.Name = "Function1";
            Function1.Size = new System.Drawing.Size(255, 59);
            Function1.TabIndex = 1;
            Function1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            Function1.UseVisualStyleBackColor = true;
            Function1.CheckedChanged += Function1_CheckedChanged;
            // 
            // Function2
            // 
            Function2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            Function2.BackColor = System.Drawing.SystemColors.Control;
            Function2.Image = (System.Drawing.Image)resources.GetObject("Function2.Image");
            Function2.Location = new System.Drawing.Point(6, 80);
            Function2.Name = "Function2";
            Function2.Size = new System.Drawing.Size(255, 51);
            Function2.TabIndex = 2;
            Function2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            Function2.UseVisualStyleBackColor = true;
            Function2.CheckedChanged += Function2_CheckedChanged;
            // 
            // MinXvalue
            // 
            MinXvalue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            MinXvalue.Location = new System.Drawing.Point(559, 72);
            MinXvalue.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            MinXvalue.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            MinXvalue.Name = "MinXvalue";
            MinXvalue.Size = new System.Drawing.Size(120, 23);
            MinXvalue.TabIndex = 3;
            MinXvalue.Value = new decimal(new int[] { 2, 0, 0, int.MinValue });
            MinXvalue.ValueChanged += MinXvalue_ValueChanged;
            // 
            // MaxXvalue
            // 
            MaxXvalue.Anchor = System.Windows.Forms.AnchorStyles.Right;
            MaxXvalue.Location = new System.Drawing.Point(559, 101);
            MaxXvalue.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            MaxXvalue.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            MaxXvalue.Name = "MaxXvalue";
            MaxXvalue.Size = new System.Drawing.Size(120, 23);
            MaxXvalue.TabIndex = 4;
            MaxXvalue.Value = new decimal(new int[] { 2, 0, 0, 0 });
            MaxXvalue.ValueChanged += MaxXvalue_ValueChanged;
            // 
            // MinYvalue
            // 
            MinYvalue.Location = new System.Drawing.Point(57, 22);
            MinYvalue.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            MinYvalue.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            MinYvalue.Name = "MinYvalue";
            MinYvalue.Size = new System.Drawing.Size(120, 23);
            MinYvalue.TabIndex = 5;
            MinYvalue.Value = new decimal(new int[] { 2, 0, 0, int.MinValue });
            MinYvalue.ValueChanged += MinYvalue_ValueChanged;
            // 
            // NumberOfPoints
            // 
            NumberOfPoints.Anchor = System.Windows.Forms.AnchorStyles.Right;
            NumberOfPoints.Location = new System.Drawing.Point(610, 29);
            NumberOfPoints.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            NumberOfPoints.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            NumberOfPoints.Name = "NumberOfPoints";
            NumberOfPoints.Size = new System.Drawing.Size(120, 23);
            NumberOfPoints.TabIndex = 6;
            NumberOfPoints.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            NumberOfPoints.ValueChanged += NumberOfPoints_ValueChanged;
            // 
            // MaxYvalue
            // 
            MaxYvalue.Location = new System.Drawing.Point(57, 60);
            MaxYvalue.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            MaxYvalue.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            MaxYvalue.Name = "MaxYvalue";
            MaxYvalue.Size = new System.Drawing.Size(120, 23);
            MaxYvalue.TabIndex = 7;
            MaxYvalue.Value = new decimal(new int[] { 2, 0, 0, 0 });
            MaxYvalue.ValueChanged += MaxYvalue_ValueChanged;
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(513, 31);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 15);
            label1.TabIndex = 8;
            label1.Text = "Кількість точок";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(515, 74);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(38, 15);
            label2.TabIndex = 9;
            label2.Text = "X min";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(515, 103);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 15);
            label3.TabIndex = 10;
            label3.Text = "X max";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(11, 24);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "Y min";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(11, 62);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(40, 15);
            label5.TabIndex = 12;
            label5.Text = "Y max";
            // 
            // buttonShowY
            // 
            buttonShowY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            buttonShowY.Location = new System.Drawing.Point(518, 130);
            buttonShowY.Name = "buttonShowY";
            buttonShowY.Size = new System.Drawing.Size(164, 26);
            buttonShowY.TabIndex = 13;
            buttonShowY.Text = "Показати меню Y";
            buttonShowY.UseVisualStyleBackColor = true;
            buttonShowY.Click += buttonShowY_Click;
            // 
            // MenuY
            // 
            MenuY.Anchor = System.Windows.Forms.AnchorStyles.Right;
            MenuY.Controls.Add(MinYvalue);
            MenuY.Controls.Add(MaxYvalue);
            MenuY.Controls.Add(label5);
            MenuY.Controls.Add(label4);
            MenuY.Location = new System.Drawing.Point(514, 162);
            MenuY.Name = "MenuY";
            MenuY.Size = new System.Drawing.Size(200, 100);
            MenuY.TabIndex = 14;
            MenuY.TabStop = false;
            MenuY.Visible = false;
            // 
            // Functions
            // 
            Functions.Controls.Add(Function1);
            Functions.Controls.Add(Function2);
            Functions.Location = new System.Drawing.Point(513, 272);
            Functions.Name = "Functions";
            Functions.Size = new System.Drawing.Size(263, 137);
            Functions.TabIndex = 15;
            Functions.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(784, 421);
            Controls.Add(Functions);
            Controls.Add(MenuY);
            Controls.Add(buttonShowY);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NumberOfPoints);
            Controls.Add(MaxXvalue);
            Controls.Add(MinXvalue);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)MinXvalue).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxXvalue).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinYvalue).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumberOfPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaxYvalue).EndInit();
            MenuY.ResumeLayout(false);
            MenuY.PerformLayout();
            Functions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.RadioButton Function1;
        private System.Windows.Forms.RadioButton Function2;
        private System.Windows.Forms.NumericUpDown MinXvalue;
        private System.Windows.Forms.NumericUpDown MaxXvalue;
        private System.Windows.Forms.NumericUpDown MinYvalue;
        private System.Windows.Forms.NumericUpDown NumberOfPoints;
        private System.Windows.Forms.NumericUpDown MaxYvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonShowY;
        private System.Windows.Forms.GroupBox MenuY;
        private System.Windows.Forms.GroupBox Functions;
    }
}

