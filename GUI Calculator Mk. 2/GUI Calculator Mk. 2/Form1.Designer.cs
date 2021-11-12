
namespace GUI_Calculator_Mk._2
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
            this.display = new System.Windows.Forms.TextBox();
            this.acBut = new System.Windows.Forms.Button();
            this.zeroBut = new System.Windows.Forms.Button();
            this.fourBut = new System.Windows.Forms.Button();
            this.oneBut = new System.Windows.Forms.Button();
            this.sevenBut = new System.Windows.Forms.Button();
            this.polarityBut = new System.Windows.Forms.Button();
            this.percentBut = new System.Windows.Forms.Button();
            this.divideBut = new System.Windows.Forms.Button();
            this.twoBut = new System.Windows.Forms.Button();
            this.fiveBut = new System.Windows.Forms.Button();
            this.eightBut = new System.Windows.Forms.Button();
            this.threeBut = new System.Windows.Forms.Button();
            this.sixBut = new System.Windows.Forms.Button();
            this.nineBut = new System.Windows.Forms.Button();
            this.dotBut = new System.Windows.Forms.Button();
            this.plusBut = new System.Windows.Forms.Button();
            this.minusBut = new System.Windows.Forms.Button();
            this.timesBut = new System.Windows.Forms.Button();
            this.equalBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(13, 13);
            this.display.Multiline = true;
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(775, 153);
            this.display.TabIndex = 0;
            this.display.Text = "--------------";
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // acBut
            // 
            this.acBut.Location = new System.Drawing.Point(52, 200);
            this.acBut.Name = "acBut";
            this.acBut.Size = new System.Drawing.Size(75, 23);
            this.acBut.TabIndex = 1;
            this.acBut.Text = "AC";
            this.acBut.UseVisualStyleBackColor = true;
            this.acBut.Click += new System.EventHandler(this.acBut_Click);
            // 
            // zeroBut
            // 
            this.zeroBut.Location = new System.Drawing.Point(52, 389);
            this.zeroBut.Name = "zeroBut";
            this.zeroBut.Size = new System.Drawing.Size(230, 23);
            this.zeroBut.TabIndex = 2;
            this.zeroBut.Text = "0";
            this.zeroBut.UseVisualStyleBackColor = true;
            this.zeroBut.Click += new System.EventHandler(this.zeroBut_Click);
            // 
            // fourBut
            // 
            this.fourBut.Location = new System.Drawing.Point(52, 294);
            this.fourBut.Name = "fourBut";
            this.fourBut.Size = new System.Drawing.Size(75, 23);
            this.fourBut.TabIndex = 3;
            this.fourBut.Text = "4";
            this.fourBut.UseVisualStyleBackColor = true;
            this.fourBut.Click += new System.EventHandler(this.fourBut_Click);
            // 
            // oneBut
            // 
            this.oneBut.Location = new System.Drawing.Point(52, 245);
            this.oneBut.Name = "oneBut";
            this.oneBut.Size = new System.Drawing.Size(75, 23);
            this.oneBut.TabIndex = 4;
            this.oneBut.Text = "1";
            this.oneBut.UseVisualStyleBackColor = true;
            this.oneBut.Click += new System.EventHandler(this.oneBut_Click);
            // 
            // sevenBut
            // 
            this.sevenBut.Location = new System.Drawing.Point(52, 343);
            this.sevenBut.Name = "sevenBut";
            this.sevenBut.Size = new System.Drawing.Size(75, 23);
            this.sevenBut.TabIndex = 5;
            this.sevenBut.Text = "7";
            this.sevenBut.UseVisualStyleBackColor = true;
            this.sevenBut.Click += new System.EventHandler(this.sevenBut_Click);
            // 
            // polarityBut
            // 
            this.polarityBut.Location = new System.Drawing.Point(207, 200);
            this.polarityBut.Name = "polarityBut";
            this.polarityBut.Size = new System.Drawing.Size(75, 23);
            this.polarityBut.TabIndex = 6;
            this.polarityBut.Text = "+/-";
            this.polarityBut.UseVisualStyleBackColor = true;
            this.polarityBut.Click += new System.EventHandler(this.polarityBut_Click);
            // 
            // percentBut
            // 
            this.percentBut.Location = new System.Drawing.Point(361, 200);
            this.percentBut.Name = "percentBut";
            this.percentBut.Size = new System.Drawing.Size(75, 23);
            this.percentBut.TabIndex = 7;
            this.percentBut.Text = "%";
            this.percentBut.UseVisualStyleBackColor = true;
            this.percentBut.Click += new System.EventHandler(this.percentBut_Click);
            // 
            // divideBut
            // 
            this.divideBut.Location = new System.Drawing.Point(509, 200);
            this.divideBut.Name = "divideBut";
            this.divideBut.Size = new System.Drawing.Size(75, 23);
            this.divideBut.TabIndex = 8;
            this.divideBut.Text = "/";
            this.divideBut.UseVisualStyleBackColor = true;
            this.divideBut.Click += new System.EventHandler(this.divideBut_Click);
            // 
            // twoBut
            // 
            this.twoBut.Location = new System.Drawing.Point(207, 245);
            this.twoBut.Name = "twoBut";
            this.twoBut.Size = new System.Drawing.Size(75, 23);
            this.twoBut.TabIndex = 9;
            this.twoBut.Text = "2";
            this.twoBut.UseVisualStyleBackColor = true;
            this.twoBut.Click += new System.EventHandler(this.twoBut_Click);
            // 
            // fiveBut
            // 
            this.fiveBut.Location = new System.Drawing.Point(207, 294);
            this.fiveBut.Name = "fiveBut";
            this.fiveBut.Size = new System.Drawing.Size(75, 23);
            this.fiveBut.TabIndex = 10;
            this.fiveBut.Text = "5";
            this.fiveBut.UseVisualStyleBackColor = true;
            this.fiveBut.Click += new System.EventHandler(this.fiveBut_Click);
            // 
            // eightBut
            // 
            this.eightBut.Location = new System.Drawing.Point(207, 343);
            this.eightBut.Name = "eightBut";
            this.eightBut.Size = new System.Drawing.Size(75, 23);
            this.eightBut.TabIndex = 11;
            this.eightBut.Text = "8";
            this.eightBut.UseVisualStyleBackColor = true;
            this.eightBut.Click += new System.EventHandler(this.eightBut_Click);
            // 
            // threeBut
            // 
            this.threeBut.Location = new System.Drawing.Point(361, 245);
            this.threeBut.Name = "threeBut";
            this.threeBut.Size = new System.Drawing.Size(75, 23);
            this.threeBut.TabIndex = 12;
            this.threeBut.Text = "3";
            this.threeBut.UseVisualStyleBackColor = true;
            this.threeBut.Click += new System.EventHandler(this.threeBut_Click);
            // 
            // sixBut
            // 
            this.sixBut.Location = new System.Drawing.Point(361, 294);
            this.sixBut.Name = "sixBut";
            this.sixBut.Size = new System.Drawing.Size(75, 23);
            this.sixBut.TabIndex = 13;
            this.sixBut.Text = "6";
            this.sixBut.UseVisualStyleBackColor = true;
            this.sixBut.Click += new System.EventHandler(this.sixBut_Click);
            // 
            // nineBut
            // 
            this.nineBut.Location = new System.Drawing.Point(361, 343);
            this.nineBut.Name = "nineBut";
            this.nineBut.Size = new System.Drawing.Size(75, 23);
            this.nineBut.TabIndex = 14;
            this.nineBut.Text = "9";
            this.nineBut.UseVisualStyleBackColor = true;
            this.nineBut.Click += new System.EventHandler(this.nineBut_Click);
            // 
            // dotBut
            // 
            this.dotBut.Location = new System.Drawing.Point(361, 389);
            this.dotBut.Name = "dotBut";
            this.dotBut.Size = new System.Drawing.Size(75, 23);
            this.dotBut.TabIndex = 15;
            this.dotBut.Text = ".";
            this.dotBut.UseVisualStyleBackColor = true;
            this.dotBut.Click += new System.EventHandler(this.dotBut_Click);
            // 
            // plusBut
            // 
            this.plusBut.Location = new System.Drawing.Point(509, 245);
            this.plusBut.Name = "plusBut";
            this.plusBut.Size = new System.Drawing.Size(75, 23);
            this.plusBut.TabIndex = 16;
            this.plusBut.Text = "+";
            this.plusBut.UseVisualStyleBackColor = true;
            this.plusBut.Click += new System.EventHandler(this.button16_Click);
            // 
            // minusBut
            // 
            this.minusBut.Location = new System.Drawing.Point(509, 294);
            this.minusBut.Name = "minusBut";
            this.minusBut.Size = new System.Drawing.Size(75, 23);
            this.minusBut.TabIndex = 17;
            this.minusBut.Text = "-";
            this.minusBut.UseVisualStyleBackColor = true;
            this.minusBut.Click += new System.EventHandler(this.minusBut_Click);
            // 
            // timesBut
            // 
            this.timesBut.Location = new System.Drawing.Point(509, 343);
            this.timesBut.Name = "timesBut";
            this.timesBut.Size = new System.Drawing.Size(75, 23);
            this.timesBut.TabIndex = 18;
            this.timesBut.Text = "x";
            this.timesBut.UseVisualStyleBackColor = true;
            this.timesBut.Click += new System.EventHandler(this.timesBut_Click);
            // 
            // equalBut
            // 
            this.equalBut.Location = new System.Drawing.Point(509, 389);
            this.equalBut.Name = "equalBut";
            this.equalBut.Size = new System.Drawing.Size(75, 23);
            this.equalBut.TabIndex = 19;
            this.equalBut.Text = "=";
            this.equalBut.UseVisualStyleBackColor = true;
            this.equalBut.Click += new System.EventHandler(this.equalBut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.equalBut);
            this.Controls.Add(this.timesBut);
            this.Controls.Add(this.minusBut);
            this.Controls.Add(this.plusBut);
            this.Controls.Add(this.dotBut);
            this.Controls.Add(this.nineBut);
            this.Controls.Add(this.sixBut);
            this.Controls.Add(this.threeBut);
            this.Controls.Add(this.eightBut);
            this.Controls.Add(this.fiveBut);
            this.Controls.Add(this.twoBut);
            this.Controls.Add(this.divideBut);
            this.Controls.Add(this.percentBut);
            this.Controls.Add(this.polarityBut);
            this.Controls.Add(this.sevenBut);
            this.Controls.Add(this.oneBut);
            this.Controls.Add(this.fourBut);
            this.Controls.Add(this.zeroBut);
            this.Controls.Add(this.acBut);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button acBut;
        private System.Windows.Forms.Button zeroBut;
        private System.Windows.Forms.Button fourBut;
        private System.Windows.Forms.Button oneBut;
        private System.Windows.Forms.Button sevenBut;
        private System.Windows.Forms.Button polarityBut;
        private System.Windows.Forms.Button percentBut;
        private System.Windows.Forms.Button divideBut;
        private System.Windows.Forms.Button twoBut;
        private System.Windows.Forms.Button fiveBut;
        private System.Windows.Forms.Button eightBut;
        private System.Windows.Forms.Button threeBut;
        private System.Windows.Forms.Button sixBut;
        private System.Windows.Forms.Button nineBut;
        private System.Windows.Forms.Button dotBut;
        private System.Windows.Forms.Button plusBut;
        private System.Windows.Forms.Button minusBut;
        private System.Windows.Forms.Button timesBut;
        private System.Windows.Forms.Button equalBut;
    }
}

