namespace GameLauncher
{
    partial class Launcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Launcher));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabRandomizer = new System.Windows.Forms.TabPage();
            this.lblError = new System.Windows.Forms.Label();
            this.check16 = new System.Windows.Forms.CheckBox();
            this.check7 = new System.Windows.Forms.CheckBox();
            this.check6 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblShotType = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.lblGame = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.tabLauncher = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabRandomizer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabRandomizer);
            this.tabControl.Controls.Add(this.tabLauncher);
            this.tabControl.Location = new System.Drawing.Point(12, 29);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(644, 403);
            this.tabControl.TabIndex = 0;
            // 
            // tabRandomizer
            // 
            this.tabRandomizer.Controls.Add(this.lblError);
            this.tabRandomizer.Controls.Add(this.check16);
            this.tabRandomizer.Controls.Add(this.check7);
            this.tabRandomizer.Controls.Add(this.check6);
            this.tabRandomizer.Controls.Add(this.label4);
            this.tabRandomizer.Controls.Add(this.lblShotType);
            this.tabRandomizer.Controls.Add(this.lblCharacter);
            this.tabRandomizer.Controls.Add(this.lblGame);
            this.tabRandomizer.Controls.Add(this.label3);
            this.tabRandomizer.Controls.Add(this.label2);
            this.tabRandomizer.Controls.Add(this.label1);
            this.tabRandomizer.Controls.Add(this.btnRandomize);
            this.tabRandomizer.Location = new System.Drawing.Point(4, 25);
            this.tabRandomizer.Name = "tabRandomizer";
            this.tabRandomizer.Padding = new System.Windows.Forms.Padding(3);
            this.tabRandomizer.Size = new System.Drawing.Size(636, 374);
            this.tabRandomizer.TabIndex = 1;
            this.tabRandomizer.Text = "Randomizer";
            this.tabRandomizer.UseVisualStyleBackColor = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(10, 196);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 12;
            // 
            // check16
            // 
            this.check16.AutoSize = true;
            this.check16.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check16.Location = new System.Drawing.Point(319, 340);
            this.check16.Name = "check16";
            this.check16.Size = new System.Drawing.Size(101, 26);
            this.check16.TabIndex = 11;
            this.check16.Text = "Touhou 16";
            this.check16.UseVisualStyleBackColor = true;
            // 
            // check7
            // 
            this.check7.AutoSize = true;
            this.check7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check7.Location = new System.Drawing.Point(319, 313);
            this.check7.Name = "check7";
            this.check7.Size = new System.Drawing.Size(93, 26);
            this.check7.TabIndex = 10;
            this.check7.Text = "Touhou 7";
            this.check7.UseVisualStyleBackColor = true;
            // 
            // check6
            // 
            this.check6.AutoSize = true;
            this.check6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check6.Location = new System.Drawing.Point(319, 286);
            this.check6.Name = "check6";
            this.check6.Size = new System.Drawing.Size(93, 26);
            this.check6.TabIndex = 9;
            this.check6.Text = "Touhou 6";
            this.check6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(315, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Game Selection";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblShotType
            // 
            this.lblShotType.AutoSize = true;
            this.lblShotType.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShotType.Location = new System.Drawing.Point(128, 115);
            this.lblShotType.Name = "lblShotType";
            this.lblShotType.Size = new System.Drawing.Size(0, 22);
            this.lblShotType.TabIndex = 6;
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter.Location = new System.Drawing.Point(128, 73);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(0, 22);
            this.lblCharacter.TabIndex = 5;
            // 
            // lblGame
            // 
            this.lblGame.AutoSize = true;
            this.lblGame.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGame.Location = new System.Drawing.Point(128, 28);
            this.lblGame.Name = "lblGame";
            this.lblGame.Size = new System.Drawing.Size(0, 22);
            this.lblGame.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shot Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Character:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game:";
            // 
            // btnRandomize
            // 
            this.btnRandomize.Location = new System.Drawing.Point(10, 157);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(114, 32);
            this.btnRandomize.TabIndex = 0;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // tabLauncher
            // 
            this.tabLauncher.Location = new System.Drawing.Point(4, 25);
            this.tabLauncher.Name = "tabLauncher";
            this.tabLauncher.Padding = new System.Windows.Forms.Padding(3);
            this.tabLauncher.Size = new System.Drawing.Size(636, 374);
            this.tabLauncher.TabIndex = 0;
            this.tabLauncher.Text = "Game Launcher";
            this.tabLauncher.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // Launcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(681, 444);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(697, 483);
            this.MinimumSize = new System.Drawing.Size(697, 483);
            this.Name = "Launcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Launcher and Touhou Randomiser";
            this.Load += new System.EventHandler(this.Launcher_Load);
            this.tabControl.ResumeLayout(false);
            this.tabRandomizer.ResumeLayout(false);
            this.tabRandomizer.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabLauncher;
        private System.Windows.Forms.TabPage tabRandomizer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Label lblGame;
        private System.Windows.Forms.Label lblShotType;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox check16;
        private System.Windows.Forms.CheckBox check7;
        private System.Windows.Forms.CheckBox check6;
        private System.Windows.Forms.Label lblError;
    }
}

