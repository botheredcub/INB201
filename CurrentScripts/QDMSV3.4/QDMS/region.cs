using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET;

namespace WindowsFormsApplication1
{
    public partial class region : Form
    {
        //Set this form as a child form
        mainform parent;

        //location constants
        private const string BRISBANE = "Brisbane";
        private const string GOLD_COAST = "Gold_Coast";
        private const string SUNSHINE_COAST = "Sunshine Coast";
        private const string TOWNSVILLE = "Townsville";
        private const string CARINS_COAST = "Cairns Coast & Far North";
        private const string MOUNT_ISA = "Mount Isa & north West";
        private const string ROCKHAMPTON = "Rockhampton";
        private const string MACKAY = "Mackay & Whitsunday";
        private const string CENTRAL_WEST = "Central West";
        private const string SOUTH_WEST = "South West & Darling downs";
        private const string GLADSTONE = "Gladstone";
        private const string WIDE_BAY = "Wide Bay & Burnett";
        private string selectedRegion;

        //Initialise the region form
        public region(mainform parent)
        {
            InitializeComponent();

            this.parent = parent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        
            //Combo Box that selects locations
            selectRegion.Items.Add(BRISBANE);
            selectRegion.Items.Add(GOLD_COAST);
            selectRegion.Items.Add(SUNSHINE_COAST);
            selectRegion.Items.Add(TOWNSVILLE);
            selectRegion.Items.Add(CARINS_COAST);
            selectRegion.Items.Add(MOUNT_ISA);
            selectRegion.Items.Add(ROCKHAMPTON);
            selectRegion.Items.Add(MACKAY);
            selectRegion.Items.Add(CENTRAL_WEST);
            selectRegion.Items.Add(SOUTH_WEST);
            selectRegion.Items.Add(GLADSTONE);
            selectRegion.Items.Add(WIDE_BAY);
        }
        //Events that would occur during the selection of a location
        private void selectRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            //When the Brisbane region is selected the form will display all related information
            //regarding that location
            selectedRegion = (string)selectRegion.SelectedItem;
            selectedRegion = (string)selectRegion.SelectedItem;
            if (selectedRegion == BRISBANE)
            {
                regionNamelabel.Text = BRISBANE;
                locationNamelabel.Text = BRISBANE;
                statusText.Text = "No Disaster";
                statusText.ForeColor = Color.Black;
                statusText.Visible = true;

                // Set the API Map interface on Brisbane
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.Position = new PointLatLng(-27.4710107, 153.0234489);
                //gmap.SetPositionByKeywords("Brisbane, Australia");          

                // Set a marker on the location
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-27.4710107, 153.0234489),
                GMarkerGoogleType.green);
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);

                //Set all information regarding the Gold Coast when selected in the combo box
            }
            else if (selectedRegion == GOLD_COAST)
            {
                regionNamelabel.Text = "Southern Eastern";
                locationNamelabel.Text = "Gold Coast";
                statusText.Text = "Tsunami";
                statusText.Visible = true;
                statusText.ForeColor = Color.Red;

                //Set the API Map to the Gold Coast Location
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.Position = new PointLatLng(-28.0172605, 153.4256987);
                //gmap.SetPositionByKeywords("Brisbane, Australia");          

                //Place a marker at the location
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-28.0172605, 153.4256987),
                GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);


            }
            else if (selectedRegion == SUNSHINE_COAST)
            {
                regionNamelabel.Text = "Southern Eastern";
                locationNamelabel.Text = "Sunshine Coast";
                statusText.Text = "Fire";
                statusText.Visible = true;
                statusText.ForeColor = Color.Red;

                //Set the API Map to the sunshine coast Location
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.Position = new PointLatLng(-26.60, 153.001);
                //gmap.SetPositionByKeywords("sunshine coast Australia");          

                //Place a marker at the location
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-26.0172605, 152.7),
                GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);


            }
            else if (selectedRegion == TOWNSVILLE)
            {
                regionNamelabel.Text = "TOWNSVILLE";
                locationNamelabel.Text = "Townsville";
                statusText.Text = "no disaster";
                statusText.Visible = true;
                statusText.ForeColor = Color.Black;

                //Set the API Map to the Townsville
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.Position = new PointLatLng(-19.50, 146.49);
                //gmap.SetPositionByKeywords("Brisbane, Australia");          

                //Place a marker at the location
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-19.48, 146.50),
                GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);
            }
            else if (selectedRegion == CARINS_COAST)
            {
                regionNamelabel.Text = "FAR NORTH";
                locationNamelabel.Text = "CARINS_COAST";
                statusText.Text = "no disaster";
                statusText.Visible = true;
                statusText.ForeColor = Color.Black;

                //Set the API Map to the cairns
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.Position = new PointLatLng(-16.5532, 145.4631);
                //gmap.SetPositionByKeywords("Brisbane, Australia");          

                //Place a marker at the location
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-16.5532, 145.4631),
                GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);
            }
            else if (selectedRegion == ROCKHAMPTON)
            {
                regionNamelabel.Text = "ROCKHAMPTON";
                locationNamelabel.Text = "ROCKHAMPTON";
                statusText.Text = "no disaster";
                statusText.Visible = true;
                statusText.ForeColor = Color.Black;

                //Set the API Map to the ROCKHAMPTON
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.Position = new PointLatLng(-23.225, 150.307);
                //gmap.SetPositionByKeywords("ROCKHAMPTON area, Australia");          

                //Place a marker at the location
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-23.225, 150.307),
                GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);
            }
            else if (selectedRegion == MOUNT_ISA)
            {
                regionNamelabel.Text = "Mount ISA";
                locationNamelabel.Text = "MOUNT_ISA";
                statusText.Text = "no disaster";
                statusText.Visible = true;
                statusText.ForeColor = Color.Black;

                //Set the API Map to the Mount Isa
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.Position = new PointLatLng(-20.44, 139.30);
                //gmap.SetPositionByKeywords("Mount Isa, Australia");          

                //Place a marker at the location
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-20.44, 139.30),
                GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);
            }
            else if (selectedRegion == MACKAY)
            {
                regionNamelabel.Text = "MACKAY";
                locationNamelabel.Text = "Mackay";
                statusText.Text = "no disaster";
                statusText.Visible = true;
                statusText.ForeColor = Color.Black;

                //Set the API Map to the mackay
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.Position = new PointLatLng(-21.0828, 149.1110);
                //gmap.SetPositionByKeywords("Brisbane, Australia");          

                //Place a marker at the location
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-21.0828, 149.1110),
                GMarkerGoogleType.green);
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);
            }
            else if (selectedRegion == CENTRAL_WEST)
            {
                regionNamelabel.Text = "CENTRAL_WEST";
                locationNamelabel.Text = "CENTRAL_WEST";
                statusText.Text = "no disaster";
                statusText.Visible = true;
                statusText.ForeColor = Color.Black;

                //Set the API Map to the longereach
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.Position = new PointLatLng(-23.27, 144.15);
                //gmap.SetPositionByKeywords("longreach, Australia");          

                //Place a marker at the location
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-23.27, 144.15),
                GMarkerGoogleType.green);
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);
            }
            else if (selectedRegion == SOUTH_WEST)
            {
                regionNamelabel.Text = "SOUTH_WEST";
                locationNamelabel.Text = "SOUTH_WEST";
                statusText.Text = "no disaster";
                statusText.Visible = true;
                statusText.ForeColor = Color.Black;

                //Set the API Map to the SOUTH_WEST
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.Position = new PointLatLng(-26.33, 148.48);
                //gmap.SetPositionByKeywords("Roma, Australia");          

                //Place a marker at the location
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-20.44, 139.30),
                GMarkerGoogleType.green);
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);
            }
            else if (selectedRegion == GLADSTONE)
            {
                regionNamelabel.Text = "GLADSTONE";
                locationNamelabel.Text = "Townsville";
                statusText.Text = "no disaster";
                statusText.Visible = true;
                statusText.ForeColor = Color.Black;

                //Set the API Map to the Townsville
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.Position = new PointLatLng(-23.5056, 151.1547);
                //gmap.SetPositionByKeywords("Brisbane, Australia");          

                //Place a marker at the location
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-23.5056, 151.1547),
                GMarkerGoogleType.green);
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);
            }
            else if (selectedRegion == WIDE_BAY)
            {
                regionNamelabel.Text = "Southern Eastern";
                locationNamelabel.Text = "WIDE_BAY";
                statusText.Text = "no disaster";
                statusText.Visible = true;
                statusText.ForeColor = Color.Black;

                //Set the API Map to the Townsville
                gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
                GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
                gmap.Position = new PointLatLng(-24.51, 152.21);
                //gmap.SetPositionByKeywords("Brisbane, Australia");          

                //Place a marker at the location
                GMapOverlay markersOverlay = new GMapOverlay("markers");
                GMarkerGoogle marker = new GMarkerGoogle(new PointLatLng(-24.51, 152.21),
                GMarkerGoogleType.red);
                markersOverlay.Markers.Add(marker);
                gmap.Overlays.Add(markersOverlay);

            }
        }

        //Load form data
        private void region_Load(object sender, EventArgs e)
        {

            gmap.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gmap.Position = new PointLatLng(-27.4710107, 153.0234489);
            //gmap.SetPositionByKeywords("Brisbane, Australia");          
        }

    }
}
