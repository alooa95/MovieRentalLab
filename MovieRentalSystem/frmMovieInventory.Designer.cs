namespace MovieRentalSystem
{
    partial class frmMovieInventory
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnCustomerList = new System.Windows.Forms.Button();
            this.lstMovieInventory = new System.Windows.Forms.ListView();
            this.gbxMovieInfo = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblMovieTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtActor = new System.Windows.Forms.TextBox();
            this.lblActors = new System.Windows.Forms.Label();
            this.txtReleaseYear = new System.Windows.Forms.TextBox();
            this.lblReleaseYear = new System.Windows.Forms.Label();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.lblIntructions = new System.Windows.Forms.Label();
            this.gbxMovieInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnLogOut.Location = new System.Drawing.Point(676, 398);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(86, 34);
            this.btnLogOut.TabIndex = 11;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnCustomerList
            // 
            this.btnCustomerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCustomerList.Location = new System.Drawing.Point(12, 398);
            this.btnCustomerList.Name = "btnCustomerList";
            this.btnCustomerList.Size = new System.Drawing.Size(94, 34);
            this.btnCustomerList.TabIndex = 10;
            this.btnCustomerList.Text = "Go to Customer List";
            this.btnCustomerList.UseVisualStyleBackColor = true;
            this.btnCustomerList.Click += new System.EventHandler(this.btnCustomerList_Click);
            // 
            // lstMovieInventory
            // 
            this.lstMovieInventory.Location = new System.Drawing.Point(12, 12);
            this.lstMovieInventory.Name = "lstMovieInventory";
            this.lstMovieInventory.Size = new System.Drawing.Size(404, 373);
            this.lstMovieInventory.TabIndex = 9;
            this.lstMovieInventory.UseCompatibleStateImageBehavior = false;
            // 
            // gbxMovieInfo
            // 
            this.gbxMovieInfo.Controls.Add(this.lblIntructions);
            this.gbxMovieInfo.Controls.Add(this.btnDeleteMovie);
            this.gbxMovieInfo.Controls.Add(this.btnSearch);
            this.gbxMovieInfo.Controls.Add(this.lblMovieTitle);
            this.gbxMovieInfo.Controls.Add(this.lblGenre);
            this.gbxMovieInfo.Controls.Add(this.txtTitle);
            this.gbxMovieInfo.Controls.Add(this.btnAddMovie);
            this.gbxMovieInfo.Controls.Add(this.txtGenre);
            this.gbxMovieInfo.Controls.Add(this.txtActor);
            this.gbxMovieInfo.Controls.Add(this.lblActors);
            this.gbxMovieInfo.Controls.Add(this.txtReleaseYear);
            this.gbxMovieInfo.Controls.Add(this.lblReleaseYear);
            this.gbxMovieInfo.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMovieInfo.Location = new System.Drawing.Point(422, 12);
            this.gbxMovieInfo.Name = "gbxMovieInfo";
            this.gbxMovieInfo.Size = new System.Drawing.Size(340, 336);
            this.gbxMovieInfo.TabIndex = 23;
            this.gbxMovieInfo.TabStop = false;
            this.gbxMovieInfo.Text = "Movie Information";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(228, 275);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 43);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblMovieTitle
            // 
            this.lblMovieTitle.AutoSize = true;
            this.lblMovieTitle.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieTitle.Location = new System.Drawing.Point(24, 115);
            this.lblMovieTitle.Name = "lblMovieTitle";
            this.lblMovieTitle.Size = new System.Drawing.Size(95, 13);
            this.lblMovieTitle.TabIndex = 2;
            this.lblMovieTitle.Text = "Movie Title";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(24, 241);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(71, 13);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Genre(s)";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(198, 107);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 26);
            this.txtTitle.TabIndex = 1;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(6, 275);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(88, 43);
            this.btnAddMovie.TabIndex = 18;
            this.btnAddMovie.Text = "Add New Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(198, 233);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 26);
            this.txtGenre.TabIndex = 11;
            // 
            // txtActor
            // 
            this.txtActor.Location = new System.Drawing.Point(198, 150);
            this.txtActor.Name = "txtActor";
            this.txtActor.Size = new System.Drawing.Size(100, 26);
            this.txtActor.TabIndex = 5;
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActors.Location = new System.Drawing.Point(24, 158);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(167, 13);
            this.lblActors.TabIndex = 6;
            this.lblActors.Text = "Actor(s)/Actress(es)";
            // 
            // txtReleaseYear
            // 
            this.txtReleaseYear.Location = new System.Drawing.Point(198, 192);
            this.txtReleaseYear.Name = "txtReleaseYear";
            this.txtReleaseYear.Size = new System.Drawing.Size(100, 26);
            this.txtReleaseYear.TabIndex = 7;
            // 
            // lblReleaseYear
            // 
            this.lblReleaseYear.AutoSize = true;
            this.lblReleaseYear.Font = new System.Drawing.Font("Lucida Console", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseYear.Location = new System.Drawing.Point(24, 200);
            this.lblReleaseYear.Name = "lblReleaseYear";
            this.lblReleaseYear.Size = new System.Drawing.Size(103, 13);
            this.lblReleaseYear.TabIndex = 8;
            this.lblReleaseYear.Text = "Release Year";
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Font = new System.Drawing.Font("Perpetua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.Location = new System.Drawing.Point(117, 275);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(88, 43);
            this.btnDeleteMovie.TabIndex = 20;
            this.btnDeleteMovie.Text = "Delete Movie";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            // 
            // lblIntructions
            // 
            this.lblIntructions.AutoSize = true;
            this.lblIntructions.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntructions.Location = new System.Drawing.Point(6, 22);
            this.lblIntructions.Name = "lblIntructions";
            this.lblIntructions.Size = new System.Drawing.Size(11, 14);
            this.lblIntructions.TabIndex = 21;
            this.lblIntructions.Text = "-";
            // 
            // frmMovieInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 444);
            this.Controls.Add(this.gbxMovieInfo);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnCustomerList);
            this.Controls.Add(this.lstMovieInventory);
            this.Name = "frmMovieInventory";
            this.Text = "Movie Inventory";
            this.gbxMovieInfo.ResumeLayout(false);
            this.gbxMovieInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnCustomerList;
        private System.Windows.Forms.ListView lstMovieInventory;
        private System.Windows.Forms.GroupBox gbxMovieInfo;
        private System.Windows.Forms.Label lblMovieTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtActor;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.Label lblReleaseYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Label lblIntructions;
    }
}