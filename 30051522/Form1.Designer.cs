namespace _30051522
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtbox_name = new System.Windows.Forms.TextBox();
            this.txtbox_inputOne = new System.Windows.Forms.TextBox();
            this.lbl_coordinates = new System.Windows.Forms.Label();
            this.txtbox_inputTwo = new System.Windows.Forms.TextBox();
            this.btn_insertData = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.data_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_location = new System.Windows.Forms.Label();
            this.lbl_locationRecord = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.gMapMain = new GMap.NET.WindowsForms.GMapControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(503, 360);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // txtbox_name
            // 
            this.txtbox_name.Location = new System.Drawing.Point(471, 376);
            this.txtbox_name.Name = "txtbox_name";
            this.txtbox_name.Size = new System.Drawing.Size(100, 20);
            this.txtbox_name.TabIndex = 2;
            // 
            // txtbox_inputOne
            // 
            this.txtbox_inputOne.Location = new System.Drawing.Point(469, 426);
            this.txtbox_inputOne.Name = "txtbox_inputOne";
            this.txtbox_inputOne.Size = new System.Drawing.Size(41, 20);
            this.txtbox_inputOne.TabIndex = 4;
            // 
            // lbl_coordinates
            // 
            this.lbl_coordinates.AutoSize = true;
            this.lbl_coordinates.Location = new System.Drawing.Point(482, 405);
            this.lbl_coordinates.Name = "lbl_coordinates";
            this.lbl_coordinates.Size = new System.Drawing.Size(63, 13);
            this.lbl_coordinates.TabIndex = 3;
            this.lbl_coordinates.Text = "Coordinates";
            // 
            // txtbox_inputTwo
            // 
            this.txtbox_inputTwo.Location = new System.Drawing.Point(534, 425);
            this.txtbox_inputTwo.Name = "txtbox_inputTwo";
            this.txtbox_inputTwo.Size = new System.Drawing.Size(41, 20);
            this.txtbox_inputTwo.TabIndex = 5;
            // 
            // btn_insertData
            // 
            this.btn_insertData.Location = new System.Drawing.Point(602, 374);
            this.btn_insertData.Name = "btn_insertData";
            this.btn_insertData.Size = new System.Drawing.Size(54, 20);
            this.btn_insertData.TabIndex = 6;
            this.btn_insertData.Text = "Add";
            this.btn_insertData.UseVisualStyleBackColor = true;
            this.btn_insertData.Click += new System.EventHandler(this.btn_insertData_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeColumns = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data_ID,
            this.grid_name,
            this.grid_x,
            this.grid_y});
            this.dataGrid.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.dataGrid.Location = new System.Drawing.Point(6, 315);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersWidth = 82;
            this.dataGrid.RowTemplate.Height = 33;
            this.dataGrid.Size = new System.Drawing.Size(425, 128);
            this.dataGrid.TabIndex = 7;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // data_ID
            // 
            this.data_ID.HeaderText = "Record ID";
            this.data_ID.MinimumWidth = 150;
            this.data_ID.Name = "data_ID";
            this.data_ID.ReadOnly = true;
            this.data_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.data_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.data_ID.Width = 150;
            // 
            // grid_name
            // 
            this.grid_name.HeaderText = "Location";
            this.grid_name.MinimumWidth = 100;
            this.grid_name.Name = "grid_name";
            this.grid_name.ReadOnly = true;
            this.grid_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // grid_x
            // 
            this.grid_x.HeaderText = "X";
            this.grid_x.MinimumWidth = 45;
            this.grid_x.Name = "grid_x";
            this.grid_x.ReadOnly = true;
            this.grid_x.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grid_x.Width = 45;
            // 
            // grid_y
            // 
            this.grid_y.HeaderText = "Y";
            this.grid_y.MinimumWidth = 45;
            this.grid_y.Name = "grid_y";
            this.grid_y.ReadOnly = true;
            this.grid_y.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.grid_y.Width = 45;
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Location = new System.Drawing.Point(451, 325);
            this.lbl_location.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(90, 13);
            this.lbl_location.TabIndex = 8;
            this.lbl_location.Text = "Select a data row";
            // 
            // lbl_locationRecord
            // 
            this.lbl_locationRecord.AutoSize = true;
            this.lbl_locationRecord.Location = new System.Drawing.Point(492, 305);
            this.lbl_locationRecord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_locationRecord.Name = "lbl_locationRecord";
            this.lbl_locationRecord.Size = new System.Drawing.Size(56, 13);
            this.lbl_locationRecord.TabIndex = 9;
            this.lbl_locationRecord.Text = "Record ID";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(602, 399);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(56, 20);
            this.btn_update.TabIndex = 10;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(602, 422);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(56, 20);
            this.btn_delete.TabIndex = 11;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "X :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(516, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Y :";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(602, 347);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(54, 20);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(9, 296);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(52, 19);
            this.btn_refresh.TabIndex = 16;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // gMapMain
            // 
            this.gMapMain.Bearing = 0F;
            this.gMapMain.CanDragMap = true;
            this.gMapMain.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapMain.GrayScaleMode = false;
            this.gMapMain.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapMain.LevelsKeepInMemory = 5;
            this.gMapMain.Location = new System.Drawing.Point(12, 12);
            this.gMapMain.MarkersEnabled = true;
            this.gMapMain.MaxZoom = 2;
            this.gMapMain.MinZoom = 2;
            this.gMapMain.MouseWheelZoomEnabled = true;
            this.gMapMain.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapMain.Name = "gMapMain";
            this.gMapMain.NegativeMode = false;
            this.gMapMain.PolygonsEnabled = true;
            this.gMapMain.RetryLoadTile = 0;
            this.gMapMain.RoutesEnabled = true;
            this.gMapMain.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapMain.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapMain.ShowTileGridLines = false;
            this.gMapMain.Size = new System.Drawing.Size(642, 278);
            this.gMapMain.TabIndex = 17;
            this.gMapMain.Zoom = 0D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.gMapMain);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_locationRecord);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.btn_insertData);
            this.Controls.Add(this.txtbox_inputTwo);
            this.Controls.Add(this.txtbox_inputOne);
            this.Controls.Add(this.lbl_coordinates);
            this.Controls.Add(this.txtbox_name);
            this.Controls.Add(this.lbl_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txtbox_name;
        private System.Windows.Forms.TextBox txtbox_inputOne;
        private System.Windows.Forms.Label lbl_coordinates;
        private System.Windows.Forms.TextBox txtbox_inputTwo;
        private System.Windows.Forms.Button btn_insertData;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.Label lbl_locationRecord;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn grid_y;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_refresh;
        private GMap.NET.WindowsForms.GMapControl gMapMain;
    }
}

