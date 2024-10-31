
using System.ComponentModel;
using System.Drawing;

namespace Lab1
{
    [ToolboxItem(true), ToolboxBitmap(typeof(RenderControl), "RenderControl.bmp"), DefaultEvent("")]
    partial class RenderControl
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
            this.SuspendLayout();
            // 
            // RenderControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "RenderControl";
            this.Size = new System.Drawing.Size(480, 300);
            this.Render += RenderGL;
            this.ResumeLayout(false);
        }

        #endregion
    }
}
