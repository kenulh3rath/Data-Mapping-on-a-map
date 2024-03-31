using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using MongoDB.Bson;
using MongoDB.Driver;


namespace _30051522
{
    public partial class Form1 : Form
    {

        // Connect to MongoDB server
        dbConfig database;

        // Create a new instance of the addData class
        static addData insertData = new addData();

        // Define a field to store the previously clicked marker
        GMapMarker previousMarker = null;


        public Form1()
        {
            InitializeComponent();

            gMapMain.ShowCenter = false;
            gMapMain.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            gMapMain.ShowCenter = false;
            gMapMain.MinZoom = 1;
            gMapMain.MaxZoom = 20;       

            try
            {
                // Connect to MongoDB server
                database = new dbConfig();

                updateData();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void Form1_Click(object sender, EventArgs e)
        {
            lbl_location.Text = "Select a data row";
        }

        private void btn_insertData_Click(object sender, EventArgs e)
        {
            // input validation
            if (txtbox_name.Text == "" || txtbox_inputOne.Text == "" || txtbox_inputTwo.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
                return;
            }

            //name input
            insertData.locationName = txtbox_name.Text;

            try
            {
                //coordinates input
                insertData.coordinates = new List<double>
                                        {
                                            Convert.ToDouble(txtbox_inputOne.Text),
                                            Convert.ToDouble(txtbox_inputTwo.Text)
                                        };

                database.insertData(insertData);

                insertData = new addData();

                emptyRecords();
                updateData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            

            

        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is valid
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the value of the first cell in the row
                object recordID = dataGrid.Rows[e.RowIndex].Cells[0].Value;
                object recordName = dataGrid.Rows[e.RowIndex].Cells[1].Value;
                object recordCoordinatesX = dataGrid.Rows[e.RowIndex].Cells[2].Value;
                object recordCoordinatesY = dataGrid.Rows[e.RowIndex].Cells[3].Value;

                // Convert the cell value to the desired type
                string v_recordID = Convert.ToString(recordID);
                string v_recordName = Convert.ToString(recordName);
                string v_recordCoordinatesX = Convert.ToString(recordCoordinatesX);
                string v_recordCoordinatesY = Convert.ToString(recordCoordinatesY);

                // Now you can use the cell value as needed
                lbl_location.Text = v_recordID;
                txtbox_name.Text = v_recordName;
                txtbox_inputOne.Text = v_recordCoordinatesX;
                txtbox_inputTwo.Text = v_recordCoordinatesY;

                // GMAP
                //Retrive the coordinates from the value provided in the Textboxes
                gMapMain.Position = new PointLatLng(Convert.ToDouble(txtbox_inputTwo.Text), Convert.ToDouble(txtbox_inputOne.Text));

                gMapMain.Zoom = 15;
                gMapMain.Update();
                gMapMain.Refresh();
            }
            else
            {
                lbl_location.Text = "Select a data row";
            }
        }


        private void btn_update_Click(object sender, EventArgs e)
        {
            insertData.locationName = txtbox_name.Text;

            //coordinates input
            insertData.coordinates = new List<double>
            {
                Convert.ToDouble(txtbox_inputOne.Text),
                Convert.ToDouble(txtbox_inputTwo.Text)
            };

            // Convert the _id to ObjectId
            ObjectId objectId = ObjectId.Parse(lbl_location.Text);

            database.updateData(objectId, insertData);

            emptyRecords();
            updateData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Convert the _id to ObjectId
            ObjectId objectId = ObjectId.Parse(lbl_location.Text);

            database.deleteData(objectId);

            emptyRecords();
            updateData();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            emptyRecords();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            emptyRecords();
            updateData();
        }

        private void gMapMain_MouseClick(object sender, MouseEventArgs e)
        {
            txtbox_name.Text = "New Location";

            txtbox_inputOne.Text = e.X.ToString();
            txtbox_inputTwo.Text = e.Y.ToString();
        }

        private void updateData()
        {
            double x = 0;
            double y = 0;

            // Retrieve data from MongoDB   ------ for custom database
            //var documents = database.getData();

            // Clear existing rows in the data grid
            dataGrid.Rows.Clear();

            // update for custom database
            /*
            foreach (var document in documents)
            {
                // Create a new row for the data grid
                DataGridViewRow row = new DataGridViewRow();

                // Loop through each element in the document
                foreach (var element in document.Elements)
                {
                    // If the element is the "Coordinates" array
                    if (element.Value.IsBsonArray)
                    {
                        string trimmedArray = element.Value.ToString().Trim('[', ']');
                        string[] values = trimmedArray.Split(',');

                        foreach (var value in values)
                        {
                            DataGridViewCell cell = new DataGridViewTextBoxCell();
                            cell.Value = value;
                            row.Cells.Add(cell);
                        }

                        x = Convert.ToDouble(values[0]);
                        y = Convert.ToDouble(values[1]);

                        // ----------------- GMAP -----------------
                        //Create the markers and place the pin on the coordinates
                        GMapOverlay markers = new GMapOverlay("markers");
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.green_pushpin);
                        markers.Markers.Add(marker);
                        gMapMain.Overlays.Add(markers);

                    }
                    else
                    {
                        // Add a new cell to the row for other elements
                        DataGridViewCell cell = new DataGridViewTextBoxCell();
                        cell.Value = element.Value.ToString(); // Convert the element value to string
                        row.Cells.Add(cell);
                    }


                }

                // Add the row to the data grid
                dataGrid.Rows.Add(row);
            }
            */


            // Retrieve data from MongoDB   ------ for shipwreck database
            var documents = database.testReadData();

            
            // update for shipwreck database
            foreach (var document in documents)
            {
                // Create a new row for the data grid
                DataGridViewRow row = new DataGridViewRow();

                // Loop through each element in the document
                foreach (var element in document.Elements)
                {
                    // If the element is the "Coordinates" array
                    if (element.Value.IsBsonArray)
                    {
                        string trimmedArray = element.Value.ToString().Trim('[', ']');
                        string[] values = trimmedArray.Split(',');

                        foreach (var value in values)
                        {
                            DataGridViewCell cell = new DataGridViewTextBoxCell();
                            cell.Value = value;
                            row.Cells.Add(cell);
                        }

                        y = Convert.ToDouble(values[0]);
                        x = Convert.ToDouble(values[1]);

                        // ----------------- GMAP -----------------
                        //Create the markers and place the pin on the coordinates

                        GMapOverlay markers = new GMapOverlay("markers");
                        GMapMarker marker = new GMarkerGoogle(new PointLatLng(x, y), GMarkerGoogleType.green_pushpin);
                        marker.ToolTipText = x + ", " + y;
                        
                        //change tooltip style
                        //marker.ToolTip.Fill = Brushes.Black;
                        //marker.ToolTip.Foreground = Brushes.White;
                        //marker.ToolTip.Stroke = Pens.Black;
                        //marker.ToolTip.Format.Alignment = StringAlignment.Center;

                        markers.Markers.Add(marker);
                        gMapMain.Overlays.Add(markers);

                    }
                    else
                    {
                        // Add a new cell to the row for other elements
                        DataGridViewCell cell = new DataGridViewTextBoxCell();

                        cell.Value = element.Value.ToString(); // Convert the element value to string
                        row.Cells.Add(cell);
                    }


                }

                // Add the row to the data grid
                dataGrid.Rows.Add(row);
            }
            



        }

        private void emptyRecords()
        {
            txtbox_name.Text = "";
            txtbox_inputOne.Text = "";
            txtbox_inputTwo.Text = "";
            lbl_location.Text = "Select a data row";
        }

        private void txtbox_name_Click(object sender, EventArgs e)
        {
            txtbox_name.Text = "";
        }
    }
}
