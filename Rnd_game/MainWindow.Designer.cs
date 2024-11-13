namespace Rnd_game
{
    partial class MainWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_closeProgram
            // 
            this.checkBox_closeProgram.AutoSize = true;
            this.checkBox_closeProgram.Checked = true;
            this.checkBox_closeProgram.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_closeProgram.Location = new System.Drawing.Point(182, 238);
            this.checkBox_closeProgram.Name = "checkBox_closeProgram";
            this.checkBox_closeProgram.Size = new System.Drawing.Size(141, 17);
            this.checkBox_closeProgram.TabIndex = 28;
            this.checkBox_closeProgram.Text = "Закрывать программу";
            this.checkBox_closeProgram.UseVisualStyleBackColor = true;
            this.checkBox_closeProgram.CheckedChanged += new System.EventHandler(this.checkBox_closeProgram_CheckedChanged);
            // 
            // bt_clearList
            // 
            this.bt_clearList.Location = new System.Drawing.Point(12, 232);
            this.bt_clearList.Name = "bt_clearList";
            this.bt_clearList.Size = new System.Drawing.Size(125, 27);
            this.bt_clearList.TabIndex = 26;
            this.bt_clearList.Text = "Очистить всё";
            this.bt_clearList.UseVisualStyleBackColor = true;
            this.bt_clearList.Click += new System.EventHandler(this.bt_clearList_Click);
            // 
            // bt_savePreset
            // 
            this.bt_savePreset.Location = new System.Drawing.Point(413, 106);
            this.bt_savePreset.Name = "bt_savePreset";
            this.bt_savePreset.Size = new System.Drawing.Size(140, 23);
            this.bt_savePreset.TabIndex = 25;
            this.bt_savePreset.Text = "Сохранить пресет";
            this.bt_savePreset.UseVisualStyleBackColor = true;
            this.bt_savePreset.Click += new System.EventHandler(this.bt_savePreset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(410, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Название игры";
            // 
            // textBox_gameName
            // 
            this.textBox_gameName.Location = new System.Drawing.Point(413, 52);
            this.textBox_gameName.Name = "textBox_gameName";
            this.textBox_gameName.Size = new System.Drawing.Size(140, 20);
            this.textBox_gameName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(178, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Мои пресеты";
            // 
            // comboBox_presets
            // 
            this.comboBox_presets.Enabled = false;
            this.comboBox_presets.FormattingEnabled = true;
            this.comboBox_presets.Location = new System.Drawing.Point(179, 28);
            this.comboBox_presets.Name = "comboBox_presets";
            this.comboBox_presets.Size = new System.Drawing.Size(114, 21);
            this.comboBox_presets.TabIndex = 20;
            this.comboBox_presets.Text = "Default";
            // 
            // bt_runRndGame
            // 
            this.bt_runRndGame.Location = new System.Drawing.Point(182, 199);
            this.bt_runRndGame.Name = "bt_runRndGame";
            this.bt_runRndGame.Size = new System.Drawing.Size(139, 27);
            this.bt_runRndGame.TabIndex = 19;
            this.bt_runRndGame.Text = "Вперёд!";
            this.bt_runRndGame.UseVisualStyleBackColor = true;
            this.bt_runRndGame.Click += new System.EventHandler(this.bt_runRndGame_Click);
            // 
            // bt_addGame
            // 
            this.bt_addGame.Location = new System.Drawing.Point(413, 77);
            this.bt_addGame.Name = "bt_addGame";
            this.bt_addGame.Size = new System.Drawing.Size(140, 23);
            this.bt_addGame.TabIndex = 18;
            this.bt_addGame.Text = "Добавить игру";
            this.bt_addGame.UseVisualStyleBackColor = true;
            this.bt_addGame.Click += new System.EventHandler(this.bt_addGame_Click);
            // 
            // checkListBox_games
            // 
            this.checkListBox_games.FormattingEnabled = true;
            this.checkListBox_games.Location = new System.Drawing.Point(12, 12);
            this.checkListBox_games.Name = "checkListBox_games";
            this.checkListBox_games.Size = new System.Drawing.Size(160, 214);
            this.checkListBox_games.TabIndex = 17;
            // 
            // bt_delElemInList
            // 
            this.bt_delElemInList.BackColor = System.Drawing.SystemColors.Control;
            this.bt_delElemInList.BackgroundImage = global::Rnd_game.Properties.Resources.free_icon_recycle_bin_container_12960;
            this.bt_delElemInList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_delElemInList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_delElemInList.Location = new System.Drawing.Point(143, 232);
            this.bt_delElemInList.Name = "bt_delElemInList";
            this.bt_delElemInList.Size = new System.Drawing.Size(29, 27);
            this.bt_delElemInList.TabIndex = 27;
            this.bt_delElemInList.UseVisualStyleBackColor = false;
            this.bt_delElemInList.Click += new System.EventHandler(this.bt_delElemInList_Click);
            // 
            // bt_addPreset
            // 
            this.bt_addPreset.BackColor = System.Drawing.SystemColors.Control;
            this.bt_addPreset.BackgroundImage = global::Rnd_game.Properties.Resources.free_icon_plus_2549959;
            this.bt_addPreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_addPreset.Enabled = false;
            this.bt_addPreset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_addPreset.Location = new System.Drawing.Point(299, 28);
            this.bt_addPreset.Name = "bt_addPreset";
            this.bt_addPreset.Size = new System.Drawing.Size(22, 21);
            this.bt_addPreset.TabIndex = 21;
            this.bt_addPreset.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_closeProgram);
            this.Controls.Add(this.bt_delElemInList);
            this.Controls.Add(this.bt_clearList);
            this.Controls.Add(this.bt_savePreset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_gameName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_addPreset);
            this.Controls.Add(this.comboBox_presets);
            this.Controls.Add(this.bt_runRndGame);
            this.Controls.Add(this.bt_addGame);
            this.Controls.Add(this.checkListBox_games);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
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
        private System.Windows.Forms.Button button1;
    }
}