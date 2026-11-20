namespace otp_lab_25
{
    partial class MainForm
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
            menuStrip2 = new MenuStrip();
            fToolStripMenuItem = new ToolStripMenuItem();
            fdsToolStripMenuItem = new ToolStripMenuItem();
            fdsToolStripMenuItem1 = new ToolStripMenuItem();
            fdsToolStripMenuItem2 = new ToolStripMenuItem();
            sdfToolStripMenuItem = new ToolStripMenuItem();
            партииТоваровToolStripMenuItem = new ToolStripMenuItem();
            продажиToolStripMenuItem = new ToolStripMenuItem();
            заявкиНаПополнениеToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fToolStripMenuItem, sdfToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1394, 36);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // fToolStripMenuItem
            // 
            fToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fdsToolStripMenuItem, fdsToolStripMenuItem1, fdsToolStripMenuItem2 });
            fToolStripMenuItem.Name = "fToolStripMenuItem";
            fToolStripMenuItem.Size = new Size(139, 30);
            fToolStripMenuItem.Text = "Справочники";
            // 
            // fdsToolStripMenuItem
            // 
            fdsToolStripMenuItem.Name = "fdsToolStripMenuItem";
            fdsToolStripMenuItem.Size = new Size(216, 34);
            fdsToolStripMenuItem.Text = "Категории";
            fdsToolStripMenuItem.Click += fdsToolStripMenuItem_Click;
            // 
            // fdsToolStripMenuItem1
            // 
            fdsToolStripMenuItem1.Name = "fdsToolStripMenuItem1";
            fdsToolStripMenuItem1.Size = new Size(216, 34);
            fdsToolStripMenuItem1.Text = "Поставщики";
            fdsToolStripMenuItem1.Click += fdsToolStripMenuItem1_Click;
            // 
            // fdsToolStripMenuItem2
            // 
            fdsToolStripMenuItem2.Name = "fdsToolStripMenuItem2";
            fdsToolStripMenuItem2.Size = new Size(216, 34);
            fdsToolStripMenuItem2.Text = "Товары";
            fdsToolStripMenuItem2.Click += fdsToolStripMenuItem2_Click;
            // 
            // sdfToolStripMenuItem
            // 
            sdfToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { партииТоваровToolStripMenuItem, продажиToolStripMenuItem, заявкиНаПополнениеToolStripMenuItem });
            sdfToolStripMenuItem.Name = "sdfToolStripMenuItem";
            sdfToolStripMenuItem.Size = new Size(112, 30);
            sdfToolStripMenuItem.Text = "Операции";
            // 
            // партииТоваровToolStripMenuItem
            // 
            партииТоваровToolStripMenuItem.Name = "партииТоваровToolStripMenuItem";
            партииТоваровToolStripMenuItem.Size = new Size(299, 34);
            партииТоваровToolStripMenuItem.Text = "Партии товаров";
            партииТоваровToolStripMenuItem.Click += ToolStripMenuItem3_Click;
            // 
            // продажиToolStripMenuItem
            // 
            продажиToolStripMenuItem.Name = "продажиToolStripMenuItem";
            продажиToolStripMenuItem.Size = new Size(299, 34);
            продажиToolStripMenuItem.Text = "Продажи";
            продажиToolStripMenuItem.Click += продажиToolStripMenuItem_Click;
            // 
            // заявкиНаПополнениеToolStripMenuItem
            // 
            заявкиНаПополнениеToolStripMenuItem.Name = "заявкиНаПополнениеToolStripMenuItem";
            заявкиНаПополнениеToolStripMenuItem.Size = new Size(299, 34);
            заявкиНаПополнениеToolStripMenuItem.Text = "Заявки на пополнение";
            заявкиНаПополнениеToolStripMenuItem.Click += заявкиНаПополнениеToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1394, 731);
            Controls.Add(menuStrip2);
            Name = "MainForm";
            Text = "Главное окно";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem fdsToolStripMenuItem;
        private ToolStripMenuItem fdsToolStripMenuItem1;
        private ToolStripMenuItem fdsToolStripMenuItem2;
        private ToolStripMenuItem sdfToolStripMenuItem;
        private ToolStripMenuItem партииТоваровToolStripMenuItem;
        private ToolStripMenuItem продажиToolStripMenuItem;
        private ToolStripMenuItem заявкиНаПополнениеToolStripMenuItem;
    }
}