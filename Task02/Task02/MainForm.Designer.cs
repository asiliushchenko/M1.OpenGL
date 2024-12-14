
namespace Task02
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderControl1 = new RenderControl();
            rbPointMode = new System.Windows.Forms.RadioButton();
            rbLineMode = new System.Windows.Forms.RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            nUDVertical = new System.Windows.Forms.NumericUpDown();
            nUDHorizontal = new System.Windows.Forms.NumericUpDown();
            lblVertical = new System.Windows.Forms.Label();
            lblHorizontal = new System.Windows.Forms.Label();
            rbFillMode = new System.Windows.Forms.RadioButton();
            groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)nUDVertical).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUDHorizontal).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.SlateBlue;
            renderControl1.DrawMode = 6913U;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(376, 356);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            renderControl1.TilesHorizontal = 1;
            renderControl1.TilesVertical = 1;
            // 
            // rbPointMode
            // 
            rbPointMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbPointMode.AutoSize = true;
            rbPointMode.Location = new System.Drawing.Point(18, 204);
            rbPointMode.Name = "rbPointMode";
            rbPointMode.Size = new System.Drawing.Size(84, 19);
            rbPointMode.TabIndex = 2;
            rbPointMode.Text = "GL_POINTS";
            rbPointMode.UseVisualStyleBackColor = true;
            rbPointMode.CheckedChanged += rbPointMode_CheckedChanged;
            // 
            // rbLineMode
            // 
            rbLineMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbLineMode.AutoSize = true;
            rbLineMode.Location = new System.Drawing.Point(18, 179);
            rbLineMode.Name = "rbLineMode";
            rbLineMode.Size = new System.Drawing.Size(68, 19);
            rbLineMode.TabIndex = 1;
            rbLineMode.Text = "GL_LINE";
            rbLineMode.UseVisualStyleBackColor = true;
            rbLineMode.CheckedChanged += rbLineMode_CheckedChanged;
            // 
            // nUDVertical
            // 
            nUDVertical.Anchor = System.Windows.Forms.AnchorStyles.None;
            nUDVertical.Location = new System.Drawing.Point(77, 89);
            nUDVertical.Name = "nUDVertical";
            nUDVertical.Size = new System.Drawing.Size(68, 23);
            nUDVertical.TabIndex = 3;
            nUDVertical.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nUDVertical.ValueChanged += nUDVertical_ValueChanged;
            // 
            // nUDHorizontal
            // 
            nUDHorizontal.Anchor = System.Windows.Forms.AnchorStyles.None;
            nUDHorizontal.Location = new System.Drawing.Point(77, 46);
            nUDHorizontal.Name = "nUDHorizontal";
            nUDHorizontal.Size = new System.Drawing.Size(68, 23);
            nUDHorizontal.TabIndex = 4;
            nUDHorizontal.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nUDHorizontal.ValueChanged += nUDHorizontal_ValueChanged;
            // 
            // lblVertical
            // 
            lblVertical.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblVertical.AutoSize = true;
            lblVertical.Location = new System.Drawing.Point(26, 91);
            lblVertical.Name = "lblVertical";
            lblVertical.Size = new System.Drawing.Size(45, 15);
            lblVertical.TabIndex = 5;
            lblVertical.Text = "Vertical";
            // 
            // lblHorizontal
            // 
            lblHorizontal.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblHorizontal.AutoSize = true;
            lblHorizontal.Location = new System.Drawing.Point(9, 48);
            lblHorizontal.Name = "lblHorizontal";
            lblHorizontal.Size = new System.Drawing.Size(62, 15);
            lblHorizontal.TabIndex = 6;
            lblHorizontal.Text = "Horizontal";
            // 
            // rbFillMode
            // 
            rbFillMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            rbFillMode.AutoSize = true;
            rbFillMode.Location = new System.Drawing.Point(18, 154);
            rbFillMode.Name = "rbFillMode";
            rbFillMode.Size = new System.Drawing.Size(65, 19);
            rbFillMode.TabIndex = 0;
            rbFillMode.Text = "GL_FILL";
            rbFillMode.UseVisualStyleBackColor = true;
            rbFillMode.CheckedChanged += rbFillMode_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            groupBox1.Controls.Add(rbFillMode);
            groupBox1.Controls.Add(rbPointMode);
            groupBox1.Controls.Add(lblVertical);
            groupBox1.Controls.Add(rbLineMode);
            groupBox1.Controls.Add(nUDHorizontal);
            groupBox1.Controls.Add(lblHorizontal);
            groupBox1.Controls.Add(nUDVertical);
            groupBox1.Location = new System.Drawing.Point(398, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(178, 356);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tile count:";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(589, 417);
            Controls.Add(groupBox1);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)nUDVertical).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUDHorizontal).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.RadioButton rbPointMode;
        private System.Windows.Forms.RadioButton rbLineMode;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown nUDVertical;
        private System.Windows.Forms.NumericUpDown nUDHorizontal;
        private System.Windows.Forms.Label lblVertical;
        private System.Windows.Forms.Label lblHorizontal;
        private System.Windows.Forms.RadioButton rbFillMode;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

