namespace Rnd_game
{
    partial class FormMainWindow
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
            this.checkBox_closeProgram = new System.Windows.Forms.CheckBox();
            this.bt_clearList = new System.Windows.Forms.Button();
            this.bt_savePreset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_gameName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_presets = new System.Windows.Forms.ComboBox();
            this.bt_runRndGame = new System.Windows.Forms.Button();
            this.bt_addGame = new System.Windows.Forms.Button();
            this.checkListBox_games = new System.Windows.Forms.CheckedListBox();
            this.bt_delElemInList = new System.Windows.Forms.Button();
            this.bt_addPreset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_openFolder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_closeProgram
            // 
            this.checkBox_closeProgram.AutoSize = true;
            this.checkBox_closeProgram.Checked = true;
            this.checkBox_closeProgram.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_closeProgram.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_closeProgram.Location = new System.Drawing.Point(12, 525);
            this.checkBox_closeProgram.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_closeProgram.Name = "checkBox_closeProgram";
            this.checkBox_closeProgram.Size = new System.Drawing.Size(351, 24);
            this.checkBox_closeProgram.TabIndex = 29;
            this.checkBox_closeProgram.Text = "Закрывать программу после запуска игры";
            this.checkBox_closeProgram.UseVisualStyleBackColor = true;
            this.checkBox_closeProgram.CheckedChanged += new System.EventHandler(this.checkBox_closeProgram_CheckedChanged);
            // 
            // bt_clearList
            // 
            this.bt_clearList.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_clearList.Location = new System.Drawing.Point(345, 347);
            this.bt_clearList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_clearList.Name = "bt_clearList";
            this.bt_clearList.Size = new System.Drawing.Size(122, 32);
            this.bt_clearList.TabIndex = 27;
            this.bt_clearList.Text = "Очистить всё";
            this.bt_clearList.UseVisualStyleBackColor = true;
            this.bt_clearList.Click += new System.EventHandler(this.bt_clearList_Click);
            // 
            // bt_savePreset
            // 
            this.bt_savePreset.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_savePreset.Location = new System.Drawing.Point(354, 67);
            this.bt_savePreset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_savePreset.Name = "bt_savePreset";
            this.bt_savePreset.Size = new System.Drawing.Size(155, 32);
            this.bt_savePreset.TabIndex = 26;
            this.bt_savePreset.Text = "Сохранить пресет";
            this.bt_savePreset.UseVisualStyleBackColor = true;
            this.bt_savePreset.Click += new System.EventHandler(this.bt_savePreset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Имя игры";
            // 
            // textBox_gameName
            // 
            this.textBox_gameName.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_gameName.Location = new System.Drawing.Point(96, 27);
            this.textBox_gameName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_gameName.Name = "textBox_gameName";
            this.textBox_gameName.Size = new System.Drawing.Size(413, 33);
            this.textBox_gameName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Пресет";
            // 
            // comboBox_presets
            // 
            this.comboBox_presets.Enabled = false;
            this.comboBox_presets.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_presets.FormattingEnabled = true;
            this.comboBox_presets.Location = new System.Drawing.Point(73, 27);
            this.comboBox_presets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox_presets.Name = "comboBox_presets";
            this.comboBox_presets.Size = new System.Drawing.Size(436, 33);
            this.comboBox_presets.TabIndex = 21;
            this.comboBox_presets.Text = "Default";
            // 
            // bt_runRndGame
            // 
            this.bt_runRndGame.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_runRndGame.Location = new System.Drawing.Point(373, 520);
            this.bt_runRndGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_runRndGame.Name = "bt_runRndGame";
            this.bt_runRndGame.Size = new System.Drawing.Size(155, 32);
            this.bt_runRndGame.TabIndex = 20;
            this.bt_runRndGame.Text = "Вперёд!";
            this.bt_runRndGame.UseVisualStyleBackColor = true;
            this.bt_runRndGame.Click += new System.EventHandler(this.bt_runRndGame_Click);
            // 
            // bt_addGame
            // 
            this.bt_addGame.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_addGame.Location = new System.Drawing.Point(354, 70);
            this.bt_addGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_addGame.Name = "bt_addGame";
            this.bt_addGame.Size = new System.Drawing.Size(155, 32);
            this.bt_addGame.TabIndex = 19;
            this.bt_addGame.Text = "Добавить путь";
            this.bt_addGame.UseVisualStyleBackColor = true;
            this.bt_addGame.Click += new System.EventHandler(this.bt_addGame_Click);
            // 
            // checkListBox_games
            // 
            this.checkListBox_games.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkListBox_games.FormattingEnabled = true;
            this.checkListBox_games.Location = new System.Drawing.Point(7, 112);
            this.checkListBox_games.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkListBox_games.Name = "checkListBox_games";
            this.checkListBox_games.Size = new System.Drawing.Size(502, 228);
            this.checkListBox_games.TabIndex = 18;
            // 
            // bt_delElemInList
            // 
            this.bt_delElemInList.BackColor = System.Drawing.SystemColors.Control;
            this.bt_delElemInList.BackgroundImage = global::Rnd_game.Properties.Resources.recycle;
            this.bt_delElemInList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_delElemInList.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_delElemInList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_delElemInList.Location = new System.Drawing.Point(475, 347);
            this.bt_delElemInList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_delElemInList.Name = "bt_delElemInList";
            this.bt_delElemInList.Size = new System.Drawing.Size(34, 32);
            this.bt_delElemInList.TabIndex = 28;
            this.bt_delElemInList.UseVisualStyleBackColor = false;
            this.bt_delElemInList.Click += new System.EventHandler(this.bt_delElemInList_Click);
            // 
            // bt_addPreset
            // 
            this.bt_addPreset.BackColor = System.Drawing.SystemColors.Control;
            this.bt_addPreset.Enabled = false;
            this.bt_addPreset.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_addPreset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_addPreset.Location = new System.Drawing.Point(7, 67);
            this.bt_addPreset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_addPreset.Name = "bt_addPreset";
            this.bt_addPreset.Size = new System.Drawing.Size(155, 32);
            this.bt_addPreset.TabIndex = 22;
            this.bt_addPreset.Text = "Новый пресет";
            this.bt_addPreset.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.bt_openFolder);
            this.groupBox1.Controls.Add(this.comboBox_presets);
            this.groupBox1.Controls.Add(this.bt_addPreset);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bt_savePreset);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 107);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор пресетов";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.textBox_gameName);
            this.groupBox2.Controls.Add(this.checkListBox_games);
            this.groupBox2.Controls.Add(this.bt_addGame);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bt_delElemInList);
            this.groupBox2.Controls.Add(this.bt_clearList);
            this.groupBox2.Location = new System.Drawing.Point(12, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 387);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Редактор списка игр";
            // 
            // bt_openFolder
            // 
            this.bt_openFolder.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_openFolder.Location = new System.Drawing.Point(181, 67);
            this.bt_openFolder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_openFolder.Name = "bt_openFolder";
            this.bt_openFolder.Size = new System.Drawing.Size(155, 32);
            this.bt_openFolder.TabIndex = 32;
            this.bt_openFolder.Text = "Открыть папку";
            this.bt_openFolder.UseVisualStyleBackColor = true;
            this.bt_openFolder.Click += new System.EventHandler(this.bt_openFolder_Click);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkBox_closeProgram);
            this.Controls.Add(this.bt_runRndGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainWindow";
            this.Load += new System.EventHandler(this.FormMainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox_closeProgram;
        private System.Windows.Forms.Button bt_delElemInList;
        private System.Windows.Forms.Button bt_clearList;
        private System.Windows.Forms.Button bt_savePreset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_gameName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_addPreset;
        private System.Windows.Forms.ComboBox comboBox_presets;
        private System.Windows.Forms.Button bt_runRndGame;
        private System.Windows.Forms.Button bt_addGame;
        private System.Windows.Forms.CheckedListBox checkListBox_games;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_openFolder;
    }
}