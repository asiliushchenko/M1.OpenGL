
namespace Task05
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
            Lighting = new System.Windows.Forms.CheckBox();
            Systems = new System.Windows.Forms.GroupBox();
            PerspectiveSys = new System.Windows.Forms.RadioButton();
            OrthogonalSys = new System.Windows.Forms.RadioButton();
            Systems.SuspendLayout();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.AngleX = 0D;
            renderControl1.AngleY = 0D;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.CameraPhi = 1.5707963267948966D;
            renderControl1.CameraRadius = 10D;
            renderControl1.CameraTheta = 0D;
            renderControl1.CenterX = 0D;
            renderControl1.CenterY = 0D;
            renderControl1.CenterZ = 0D;
            renderControl1.Fill = true;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.IsClipPlane = true;
            renderControl1.LastLeftMouseX = 0D;
            renderControl1.LastLeftMouseY = 0D;
            renderControl1.LastRightMouseX = 0D;
            renderControl1.LastRightMouseY = 0D;
            renderControl1.LightOn = true;
            renderControl1.Location = new System.Drawing.Point(12, 12);
            renderControl1.Mode = true;
            renderControl1.Multi = 1D;
            renderControl1.Name = "renderControl1";
            renderControl1.NotPanning = true;
            renderControl1.NotRotating = true;
            renderControl1.PanOffsetX = 0D;
            renderControl1.PanOffsetY = 0D;
            renderControl1.PanOffsetZ = 0D;
            renderControl1.Size = new System.Drawing.Size(438, 300);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            renderControl1.MouseDown += MouseDown;
            renderControl1.MouseMove += MouseMovement;
            renderControl1.MouseUp += MouseClick;
            renderControl1.MouseWheel += OnWheel;
            // 
            // Lighting
            // 
            Lighting.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Lighting.AutoSize = true;
            Lighting.Checked = true;
            Lighting.CheckState = System.Windows.Forms.CheckState.Checked;
            Lighting.Location = new System.Drawing.Point(456, 102);
            Lighting.Name = "Lighting";
            Lighting.Size = new System.Drawing.Size(88, 19);
            Lighting.TabIndex = 1;
            Lighting.Text = "Освітлення";
            Lighting.UseVisualStyleBackColor = true;
            Lighting.CheckedChanged += Light;
            // 
            // Systems
            // 
            Systems.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Systems.Controls.Add(PerspectiveSys);
            Systems.Controls.Add(OrthogonalSys);
            Systems.Location = new System.Drawing.Point(456, 12);
            Systems.Name = "Systems";
            Systems.Size = new System.Drawing.Size(172, 84);
            Systems.TabIndex = 2;
            Systems.TabStop = false;
            // 
            // PerspectiveSys
            // 
            PerspectiveSys.AutoSize = true;
            PerspectiveSys.Checked = true;
            PerspectiveSys.Location = new System.Drawing.Point(6, 22);
            PerspectiveSys.Name = "PerspectiveSys";
            PerspectiveSys.Size = new System.Drawing.Size(155, 19);
            PerspectiveSys.TabIndex = 1;
            PerspectiveSys.TabStop = true;
            PerspectiveSys.Text = "Перспективна проекція";
            PerspectiveSys.UseVisualStyleBackColor = true;
            PerspectiveSys.CheckedChanged += PerspectiveSystem;
            // 
            // OrthogonalSys
            // 
            OrthogonalSys.AutoSize = true;
            OrthogonalSys.Location = new System.Drawing.Point(6, 47);
            OrthogonalSys.Name = "OrthogonalSys";
            OrthogonalSys.Size = new System.Drawing.Size(156, 19);
            OrthogonalSys.TabIndex = 0;
            OrthogonalSys.TabStop = true;
            OrthogonalSys.Text = "Ортогональна проекція";
            OrthogonalSys.UseVisualStyleBackColor = true;
            OrthogonalSys.CheckedChanged += OrthogonalSystem;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(640, 324);
            Controls.Add(Systems);
            Controls.Add(Lighting);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Main Form";
            Systems.ResumeLayout(false);
            Systems.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.CheckBox Lighting;
        private System.Windows.Forms.GroupBox Systems;
        private System.Windows.Forms.RadioButton PerspectiveSys;
        private System.Windows.Forms.RadioButton OrthogonalSys;
    }
}

