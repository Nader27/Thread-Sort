namespace No_Thread_Sort
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.label = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.browse_button = new System.Windows.Forms.Button();
            this.openfiledialog = new System.Windows.Forms.OpenFileDialog();
            this.ok_button = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.Counter = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.Bubble_radioButton = new System.Windows.Forms.RadioButton();
            this.insertion_radioButton = new System.Windows.Forms.RadioButton();
            this.Selection_radioButton = new System.Windows.Forms.RadioButton();
            this.Quick_radioButton = new System.Windows.Forms.RadioButton();
            this.generate_checkBox = new System.Windows.Forms.CheckBox();
            this.Generate_button = new System.Windows.Forms.Button();
            this.Sort_button = new System.Windows.Forms.Button();
            this.length_textBox = new System.Windows.Forms.TextBox();
            this.min_textBox = new System.Windows.Forms.TextBox();
            this.max_textBox = new System.Windows.Forms.TextBox();
            this.length_label = new System.Windows.Forms.Label();
            this.min_label = new System.Windows.Forms.Label();
            this.max_label = new System.Windows.Forms.Label();
            this.result_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(9, 50);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(66, 16);
            this.label.TabIndex = 0;
            this.label.Text = "File Path :";
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(12, 69);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(316, 20);
            this.path.TabIndex = 1;
            // 
            // browse_button
            // 
            this.browse_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_button.Location = new System.Drawing.Point(415, 69);
            this.browse_button.Name = "browse_button";
            this.browse_button.Size = new System.Drawing.Size(75, 23);
            this.browse_button.TabIndex = 2;
            this.browse_button.Text = "Browse";
            this.browse_button.UseVisualStyleBackColor = true;
            this.browse_button.Click += new System.EventHandler(this.browse_button_Click);
            // 
            // openfiledialog
            // 
            this.openfiledialog.AddExtension = false;
            this.openfiledialog.DefaultExt = "txt";
            this.openfiledialog.Filter = "Text Files|*.txt|All files|*.*";
            this.openfiledialog.Title = "Select Test Case File";
            // 
            // ok_button
            // 
            this.ok_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ok_button.Location = new System.Drawing.Point(334, 69);
            this.ok_button.Name = "ok_button";
            this.ok_button.Size = new System.Drawing.Size(75, 23);
            this.ok_button.TabIndex = 3;
            this.ok_button.Text = "OK";
            this.ok_button.UseVisualStyleBackColor = true;
            this.ok_button.Click += new System.EventHandler(this.ok_button_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 125);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(258, 213);
            this.textBox.TabIndex = 4;
            // 
            // Counter
            // 
            this.Counter.AutoSize = true;
            this.Counter.Location = new System.Drawing.Point(276, 128);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(13, 13);
            this.Counter.TabIndex = 6;
            this.Counter.Text = "0";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(13, 96);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(483, 23);
            this.progressBar.TabIndex = 7;
            // 
            // Bubble_radioButton
            // 
            this.Bubble_radioButton.AutoSize = true;
            this.Bubble_radioButton.Checked = true;
            this.Bubble_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bubble_radioButton.Location = new System.Drawing.Point(276, 172);
            this.Bubble_radioButton.Name = "Bubble_radioButton";
            this.Bubble_radioButton.Size = new System.Drawing.Size(103, 22);
            this.Bubble_radioButton.TabIndex = 8;
            this.Bubble_radioButton.TabStop = true;
            this.Bubble_radioButton.Text = "Bubble Sort";
            this.Bubble_radioButton.UseVisualStyleBackColor = true;
            // 
            // insertion_radioButton
            // 
            this.insertion_radioButton.AutoSize = true;
            this.insertion_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertion_radioButton.Location = new System.Drawing.Point(276, 227);
            this.insertion_radioButton.Name = "insertion_radioButton";
            this.insertion_radioButton.Size = new System.Drawing.Size(114, 22);
            this.insertion_radioButton.TabIndex = 9;
            this.insertion_radioButton.Text = "Insertion Sort";
            this.insertion_radioButton.UseVisualStyleBackColor = true;
            // 
            // Selection_radioButton
            // 
            this.Selection_radioButton.AutoSize = true;
            this.Selection_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Selection_radioButton.Location = new System.Drawing.Point(368, 255);
            this.Selection_radioButton.Name = "Selection_radioButton";
            this.Selection_radioButton.Size = new System.Drawing.Size(119, 22);
            this.Selection_radioButton.TabIndex = 10;
            this.Selection_radioButton.Text = "Selection Sort";
            this.Selection_radioButton.UseVisualStyleBackColor = true;
            // 
            // Quick_radioButton
            // 
            this.Quick_radioButton.AutoSize = true;
            this.Quick_radioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quick_radioButton.Location = new System.Drawing.Point(368, 200);
            this.Quick_radioButton.Name = "Quick_radioButton";
            this.Quick_radioButton.Size = new System.Drawing.Size(97, 22);
            this.Quick_radioButton.TabIndex = 11;
            this.Quick_radioButton.Text = "Quick Sort";
            this.Quick_radioButton.UseVisualStyleBackColor = true;
            // 
            // generate_checkBox
            // 
            this.generate_checkBox.AutoSize = true;
            this.generate_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_checkBox.Location = new System.Drawing.Point(12, 23);
            this.generate_checkBox.Name = "generate_checkBox";
            this.generate_checkBox.Size = new System.Drawing.Size(122, 22);
            this.generate_checkBox.TabIndex = 12;
            this.generate_checkBox.Text = "Auto Generate";
            this.generate_checkBox.UseVisualStyleBackColor = true;
            this.generate_checkBox.CheckedChanged += new System.EventHandler(this.generate_checkBox_CheckedChanged);
            // 
            // Generate_button
            // 
            this.Generate_button.Enabled = false;
            this.Generate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_button.Location = new System.Drawing.Point(368, 16);
            this.Generate_button.Name = "Generate_button";
            this.Generate_button.Size = new System.Drawing.Size(112, 31);
            this.Generate_button.TabIndex = 13;
            this.Generate_button.Text = "Generate";
            this.Generate_button.UseVisualStyleBackColor = true;
            this.Generate_button.Click += new System.EventHandler(this.Generate_button_Click);
            // 
            // Sort_button
            // 
            this.Sort_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sort_button.Location = new System.Drawing.Point(415, 136);
            this.Sort_button.Name = "Sort_button";
            this.Sort_button.Size = new System.Drawing.Size(75, 30);
            this.Sort_button.TabIndex = 14;
            this.Sort_button.Text = "Sort";
            this.Sort_button.UseVisualStyleBackColor = true;
            this.Sort_button.Click += new System.EventHandler(this.Sort_button_Click);
            // 
            // length_textBox
            // 
            this.length_textBox.Enabled = false;
            this.length_textBox.Location = new System.Drawing.Point(141, 23);
            this.length_textBox.Name = "length_textBox";
            this.length_textBox.Size = new System.Drawing.Size(63, 20);
            this.length_textBox.TabIndex = 15;
            this.length_textBox.Text = "10000";
            // 
            // min_textBox
            // 
            this.min_textBox.Enabled = false;
            this.min_textBox.Location = new System.Drawing.Point(210, 23);
            this.min_textBox.Name = "min_textBox";
            this.min_textBox.Size = new System.Drawing.Size(63, 20);
            this.min_textBox.TabIndex = 16;
            this.min_textBox.Text = "0";
            // 
            // max_textBox
            // 
            this.max_textBox.Enabled = false;
            this.max_textBox.Location = new System.Drawing.Point(279, 23);
            this.max_textBox.Name = "max_textBox";
            this.max_textBox.Size = new System.Drawing.Size(63, 20);
            this.max_textBox.TabIndex = 17;
            this.max_textBox.Text = "10000";
            // 
            // length_label
            // 
            this.length_label.AutoSize = true;
            this.length_label.Enabled = false;
            this.length_label.Location = new System.Drawing.Point(141, 4);
            this.length_label.Name = "length_label";
            this.length_label.Size = new System.Drawing.Size(40, 13);
            this.length_label.TabIndex = 18;
            this.length_label.Text = "Length";
            // 
            // min_label
            // 
            this.min_label.AutoSize = true;
            this.min_label.Enabled = false;
            this.min_label.Location = new System.Drawing.Point(210, 3);
            this.min_label.Name = "min_label";
            this.min_label.Size = new System.Drawing.Size(24, 13);
            this.min_label.TabIndex = 19;
            this.min_label.Text = "Min";
            // 
            // max_label
            // 
            this.max_label.AutoSize = true;
            this.max_label.Enabled = false;
            this.max_label.Location = new System.Drawing.Point(279, 2);
            this.max_label.Name = "max_label";
            this.max_label.Size = new System.Drawing.Size(27, 13);
            this.max_label.TabIndex = 20;
            this.max_label.Text = "Max";
            // 
            // result_textBox
            // 
            this.result_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_textBox.Location = new System.Drawing.Point(282, 301);
            this.result_textBox.Name = "result_textBox";
            this.result_textBox.ReadOnly = true;
            this.result_textBox.Size = new System.Drawing.Size(198, 26);
            this.result_textBox.TabIndex = 21;
            this.result_textBox.Text = "using : ";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 350);
            this.Controls.Add(this.result_textBox);
            this.Controls.Add(this.max_label);
            this.Controls.Add(this.min_label);
            this.Controls.Add(this.length_label);
            this.Controls.Add(this.max_textBox);
            this.Controls.Add(this.min_textBox);
            this.Controls.Add(this.length_textBox);
            this.Controls.Add(this.Sort_button);
            this.Controls.Add(this.Generate_button);
            this.Controls.Add(this.generate_checkBox);
            this.Controls.Add(this.Quick_radioButton);
            this.Controls.Add(this.Selection_radioButton);
            this.Controls.Add(this.insertion_radioButton);
            this.Controls.Add(this.Bubble_radioButton);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.Counter);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.ok_button);
            this.Controls.Add(this.browse_button);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Sort";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button browse_button;
        private System.Windows.Forms.OpenFileDialog openfiledialog;
        private System.Windows.Forms.Button ok_button;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label Counter;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RadioButton Bubble_radioButton;
        private System.Windows.Forms.RadioButton insertion_radioButton;
        private System.Windows.Forms.RadioButton Selection_radioButton;
        private System.Windows.Forms.RadioButton Quick_radioButton;
        private System.Windows.Forms.CheckBox generate_checkBox;
        private System.Windows.Forms.Button Generate_button;
        private System.Windows.Forms.Button Sort_button;
        private System.Windows.Forms.TextBox length_textBox;
        private System.Windows.Forms.TextBox min_textBox;
        private System.Windows.Forms.TextBox max_textBox;
        private System.Windows.Forms.Label length_label;
        private System.Windows.Forms.Label min_label;
        private System.Windows.Forms.Label max_label;
        private System.Windows.Forms.TextBox result_textBox;
    }
}

