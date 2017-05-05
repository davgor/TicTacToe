namespace TicTacToe
{
    partial class tic_tac_toe_form
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
            this.test_winner = new System.Windows.Forms.Button();
            this.master_reset = new System.Windows.Forms.Button();
            this.place_0_0 = new System.Windows.Forms.Button();
            this.place_1_0 = new System.Windows.Forms.Button();
            this.place_2_0 = new System.Windows.Forms.Button();
            this.place_2_1 = new System.Windows.Forms.Button();
            this.place_1_1 = new System.Windows.Forms.Button();
            this.place_0_1 = new System.Windows.Forms.Button();
            this.place_2_2 = new System.Windows.Forms.Button();
            this.place_1_2 = new System.Windows.Forms.Button();
            this.place_0_2 = new System.Windows.Forms.Button();
            this.game_output = new System.Windows.Forms.Label();
            this.player_label_1 = new System.Windows.Forms.Label();
            this.player_label_2 = new System.Windows.Forms.Label();
            this.wins_count_player_1 = new System.Windows.Forms.Label();
            this.wins_count_player_2 = new System.Windows.Forms.Label();
            this.draw_label_1 = new System.Windows.Forms.Label();
            this.draw_count_value = new System.Windows.Forms.Label();
            this.light_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // test_winner
            // 
            this.test_winner.Location = new System.Drawing.Point(7, 303);
            this.test_winner.Name = "test_winner";
            this.test_winner.Size = new System.Drawing.Size(116, 23);
            this.test_winner.TabIndex = 9;
            this.test_winner.Text = "&WINNER TEST";
            this.test_winner.UseVisualStyleBackColor = true;
            this.test_winner.Click += new System.EventHandler(this.random_winner_Click);
            // 
            // master_reset
            // 
            this.master_reset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.master_reset.Location = new System.Drawing.Point(7, 361);
            this.master_reset.Name = "master_reset";
            this.master_reset.Size = new System.Drawing.Size(116, 23);
            this.master_reset.TabIndex = 10;
            this.master_reset.Text = "&RESET ALL";
            this.master_reset.UseVisualStyleBackColor = true;
            this.master_reset.Click += new System.EventHandler(this.reset_all_Click);
            // 
            // place_0_0
            // 
            this.place_0_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.place_0_0.Location = new System.Drawing.Point(12, 12);
            this.place_0_0.Name = "place_0_0";
            this.place_0_0.Size = new System.Drawing.Size(90, 82);
            this.place_0_0.TabIndex = 11;
            this.place_0_0.UseVisualStyleBackColor = true;
            this.place_0_0.Click += new System.EventHandler(this.place_0_0_Click);
            // 
            // place_1_0
            // 
            this.place_1_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.place_1_0.Location = new System.Drawing.Point(12, 100);
            this.place_1_0.Name = "place_1_0";
            this.place_1_0.Size = new System.Drawing.Size(90, 82);
            this.place_1_0.TabIndex = 12;
            this.place_1_0.UseVisualStyleBackColor = true;
            this.place_1_0.Click += new System.EventHandler(this.place_1_0_Click);
            // 
            // place_2_0
            // 
            this.place_2_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.place_2_0.Location = new System.Drawing.Point(12, 188);
            this.place_2_0.Name = "place_2_0";
            this.place_2_0.Size = new System.Drawing.Size(90, 82);
            this.place_2_0.TabIndex = 13;
            this.place_2_0.UseVisualStyleBackColor = true;
            this.place_2_0.Click += new System.EventHandler(this.place_2_0_Click);
            // 
            // place_2_1
            // 
            this.place_2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.place_2_1.Location = new System.Drawing.Point(108, 188);
            this.place_2_1.Name = "place_2_1";
            this.place_2_1.Size = new System.Drawing.Size(90, 82);
            this.place_2_1.TabIndex = 16;
            this.place_2_1.UseVisualStyleBackColor = true;
            this.place_2_1.Click += new System.EventHandler(this.place_2_1_Click);
            // 
            // place_1_1
            // 
            this.place_1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.place_1_1.Location = new System.Drawing.Point(108, 100);
            this.place_1_1.Name = "place_1_1";
            this.place_1_1.Size = new System.Drawing.Size(90, 82);
            this.place_1_1.TabIndex = 15;
            this.place_1_1.UseVisualStyleBackColor = true;
            this.place_1_1.Click += new System.EventHandler(this.place_1_1_Click);
            // 
            // place_0_1
            // 
            this.place_0_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.place_0_1.Location = new System.Drawing.Point(108, 12);
            this.place_0_1.Name = "place_0_1";
            this.place_0_1.Size = new System.Drawing.Size(90, 82);
            this.place_0_1.TabIndex = 14;
            this.place_0_1.UseVisualStyleBackColor = true;
            this.place_0_1.Click += new System.EventHandler(this.place_0_1_Click);
            // 
            // place_2_2
            // 
            this.place_2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.place_2_2.Location = new System.Drawing.Point(204, 188);
            this.place_2_2.Name = "place_2_2";
            this.place_2_2.Size = new System.Drawing.Size(90, 82);
            this.place_2_2.TabIndex = 19;
            this.place_2_2.UseVisualStyleBackColor = true;
            this.place_2_2.Click += new System.EventHandler(this.place_2_2_Click);
            // 
            // place_1_2
            // 
            this.place_1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.place_1_2.Location = new System.Drawing.Point(204, 100);
            this.place_1_2.Name = "place_1_2";
            this.place_1_2.Size = new System.Drawing.Size(90, 82);
            this.place_1_2.TabIndex = 18;
            this.place_1_2.UseVisualStyleBackColor = true;
            this.place_1_2.Click += new System.EventHandler(this.place_1_2_Click);
            // 
            // place_0_2
            // 
            this.place_0_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.place_0_2.Location = new System.Drawing.Point(204, 12);
            this.place_0_2.Name = "place_0_2";
            this.place_0_2.Size = new System.Drawing.Size(90, 82);
            this.place_0_2.TabIndex = 17;
            this.place_0_2.UseVisualStyleBackColor = true;
            this.place_0_2.Click += new System.EventHandler(this.place_0_2_Click);
            // 
            // game_output
            // 
            this.game_output.AutoSize = true;
            this.game_output.Location = new System.Drawing.Point(12, 286);
            this.game_output.Name = "game_output";
            this.game_output.Size = new System.Drawing.Size(59, 13);
            this.game_output.TabIndex = 20;
            this.game_output.Text = "Good luck!";
            // 
            // player_label_1
            // 
            this.player_label_1.AutoSize = true;
            this.player_label_1.Location = new System.Drawing.Point(129, 303);
            this.player_label_1.Name = "player_label_1";
            this.player_label_1.Size = new System.Drawing.Size(69, 13);
            this.player_label_1.TabIndex = 21;
            this.player_label_1.Text = "Player 1 wins";
            // 
            // player_label_2
            // 
            this.player_label_2.AutoSize = true;
            this.player_label_2.Location = new System.Drawing.Point(129, 332);
            this.player_label_2.Name = "player_label_2";
            this.player_label_2.Size = new System.Drawing.Size(69, 13);
            this.player_label_2.TabIndex = 22;
            this.player_label_2.Text = "Player 2 wins";
            // 
            // wins_count_player_1
            // 
            this.wins_count_player_1.AutoSize = true;
            this.wins_count_player_1.Location = new System.Drawing.Point(205, 303);
            this.wins_count_player_1.Name = "wins_count_player_1";
            this.wins_count_player_1.Size = new System.Drawing.Size(13, 13);
            this.wins_count_player_1.TabIndex = 23;
            this.wins_count_player_1.Text = "0";
            // 
            // wins_count_player_2
            // 
            this.wins_count_player_2.AutoSize = true;
            this.wins_count_player_2.Location = new System.Drawing.Point(205, 332);
            this.wins_count_player_2.Name = "wins_count_player_2";
            this.wins_count_player_2.Size = new System.Drawing.Size(13, 13);
            this.wins_count_player_2.TabIndex = 24;
            this.wins_count_player_2.Text = "0";
            // 
            // draw_label_1
            // 
            this.draw_label_1.AutoSize = true;
            this.draw_label_1.Location = new System.Drawing.Point(129, 358);
            this.draw_label_1.Name = "draw_label_1";
            this.draw_label_1.Size = new System.Drawing.Size(37, 13);
            this.draw_label_1.TabIndex = 25;
            this.draw_label_1.Text = "Draws";
            // 
            // draw_count_value
            // 
            this.draw_count_value.AutoSize = true;
            this.draw_count_value.Location = new System.Drawing.Point(205, 358);
            this.draw_count_value.Name = "draw_count_value";
            this.draw_count_value.Size = new System.Drawing.Size(13, 13);
            this.draw_count_value.TabIndex = 26;
            this.draw_count_value.Text = "0";
            // 
            // light_reset
            // 
            this.light_reset.Location = new System.Drawing.Point(7, 332);
            this.light_reset.Name = "light_reset";
            this.light_reset.Size = new System.Drawing.Size(116, 23);
            this.light_reset.TabIndex = 27;
            this.light_reset.Text = "&LIGHT RESET";
            this.light_reset.UseVisualStyleBackColor = true;
            this.light_reset.Click += new System.EventHandler(this.light_reset_Click);
            // 
            // tic_tac_toe_form
            // 
            this.AcceptButton = this.test_winner;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.master_reset;
            this.ClientSize = new System.Drawing.Size(309, 412);
            this.Controls.Add(this.light_reset);
            this.Controls.Add(this.draw_count_value);
            this.Controls.Add(this.draw_label_1);
            this.Controls.Add(this.wins_count_player_2);
            this.Controls.Add(this.wins_count_player_1);
            this.Controls.Add(this.player_label_2);
            this.Controls.Add(this.player_label_1);
            this.Controls.Add(this.game_output);
            this.Controls.Add(this.place_2_2);
            this.Controls.Add(this.place_1_2);
            this.Controls.Add(this.place_0_2);
            this.Controls.Add(this.place_2_1);
            this.Controls.Add(this.place_1_1);
            this.Controls.Add(this.place_0_1);
            this.Controls.Add(this.place_2_0);
            this.Controls.Add(this.place_1_0);
            this.Controls.Add(this.place_0_0);
            this.Controls.Add(this.master_reset);
            this.Controls.Add(this.test_winner);
            this.Name = "tic_tac_toe_form";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button test_winner;
        private System.Windows.Forms.Button master_reset;
        private System.Windows.Forms.Button place_0_0;
        private System.Windows.Forms.Button place_1_0;
        private System.Windows.Forms.Button place_2_0;
        private System.Windows.Forms.Button place_2_1;
        private System.Windows.Forms.Button place_1_1;
        private System.Windows.Forms.Button place_0_1;
        private System.Windows.Forms.Button place_2_2;
        private System.Windows.Forms.Button place_1_2;
        private System.Windows.Forms.Button place_0_2;
        private System.Windows.Forms.Label game_output;
        private System.Windows.Forms.Label player_label_1;
        private System.Windows.Forms.Label player_label_2;
        private System.Windows.Forms.Label wins_count_player_1;
        private System.Windows.Forms.Label wins_count_player_2;
        private System.Windows.Forms.Label draw_label_1;
        private System.Windows.Forms.Label draw_count_value;
        private System.Windows.Forms.Button light_reset;
    }
}

