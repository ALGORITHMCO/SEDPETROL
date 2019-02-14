using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace GUI_MODERNISTA
{
    public partial class mapazonasmes : UserControl
    {
        GMarkerGoogle marker;
        GMapOverlay markerOverlay;
        DataTable dt;
        int vContadorDatos;
        Panel panel;
        double latinicial = 4.570868;
        double loninicial = -74.29733299999998;

        String direccion1;
        String direccion2;
        String medidor1;
        public String fechainicio;
        public String fechafin;
        public String variable;
        public String departamento;
        public String ciudad;
        public String zona;
        public String localidad;
        public String barrio;
        public String idmedidor;

        public mapazonasmes()
        {
            InitializeComponent();

        }

        private async void UserControl1_LoadAsync(object sender, EventArgs e)
        {

            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.CanDragMap = true;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 29;
            gMapControl1.Zoom = 12;

            Consultareportesyanalisis datos = new Consultareportesyanalisis();
            datos.FechaInicio = fechainicio;
            datos.FechaFin = fechafin;
            datos.variableaconsultar = variable;
            datos.departamento = departamento;
            datos.ciudad = ciudad;
            datos.zona = zona;
            datos.localidad = localidad;
            datos.barrio = barrio;
            datos.ID_MEDIDOR = idmedidor;

            using (SqlConnection conexi = conexion.conectarbd())
            {
                SqlCommand comando = new SqlCommand();
                if (datos.ciudad != "" && datos.departamento != "" && datos.zona != "")
                {
                    if (datos.barrio == "" && datos.localidad == "") {
                        comando = new SqlCommand(string.Format(
                            "SELECT t1.ID_MEDIDOR, t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.MUNICIPIO FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1'"), conexi);
                    }
                    if (datos.barrio != "" && datos.localidad == "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT t1.ID_MEDIDOR, t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.MUNICIPIO FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "' AND t2.LOCALIDAD = '" + datos.localidad + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1'"), conexi);
                    }
                    if (datos.barrio != "" && datos.localidad != "")
                    {
                        comando = new SqlCommand(string.Format(
                            "SELECT t1.ID_MEDIDOR, t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.MUNICIPIO FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t2.MUNICIPIO ='" + datos.ciudad + "'  AND t2.LOCALIDAD = '" + datos.localidad + "'  AND t2.BARRIO = '" + datos.barrio + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1'"), conexi);
                    }
                }
                if (datos.ciudad != "" && datos.departamento == "" && datos.zona == "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT t1.ID_MEDIDOR, t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.MUNICIPIO  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO ='" + datos.ciudad + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' "), conexi);
                }
                if (datos.ciudad == "" && datos.departamento != "" && datos.zona == "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT t1.ID_MEDIDOR,  t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.MUNICIPIO FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' "), conexi);
                }
                if (datos.ciudad == "" && datos.departamento == "" && datos.zona != "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT t1.ID_MEDIDOR, t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.MUNICIPIO  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' "), conexi);
                }
                if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT t1.ID_MEDIDOR, t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.MUNICIPIO  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "'AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' "), conexi);
                }
                if (datos.ciudad == "" && datos.departamento != "" && datos.zona != "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT  t1.ID_MEDIDOR,t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.MUNICIPIO  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.DEPARTAMENTO = '" + datos.departamento + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' "), conexi);
                }
                if (datos.ciudad != "" && datos.departamento == "" && datos.zona != "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT  t1.ID_MEDIDOR, t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.MUNICIPIO FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO = '" + datos.ciudad + "' AND t2.ZONA = '" + datos.zona + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' GROUP BY DATEPART (MONTH, t1.FECHA), DATEPART (YEAR, t1.FECHA)"), conexi);
                }
                if (datos.ciudad != "" && datos.departamento != "" && datos.zona == "")
                {
                    comando = new SqlCommand(string.Format(
                        "SELECT t1.ID_MEDIDOR, t2.DEPARTAMENTO, t2.ZONA,t2.DIRECCION , t2.MUNICIPIO  FROM PREDIO t2 inner join MEDIDOR M on t2.ID_PREDIO = M.ID_PREDIO inner join VARIABLES t1 on t1.ID_MEDIDOR = M.ID_MEDIDOR WHERE  t2.MUNICIPIO = '" + datos.ciudad + "' AND t2.DEPARTAMENTO = '" + datos.departamento + "' AND t1.FECHA >= '" + datos.FechaInicio + "-1' AND t1.FECHA < '" + datos.FechaFin + "-1' "), conexi);
                }
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {

                    direccion1 = reader.GetString(3);
                    medidor1 = Convert.ToString(reader.GetInt32(0));
                    //ConsultareportesyanalisisIN dire = new ConsultareportesyanalisisIN(panel);
                    //geolocalizacionAsync(reader.GetString(2) + reader.GetString(3) + reader.GetString(0));
                    var address = reader.GetString(3) + reader.GetString(4) + reader.GetString(1);
                    var requestUri = string.Format("https://maps.googleapis.com/maps/api/geocode/json?sensor=false&key=AIzaSyDs-uGlAG_2vurHpmHDL3gW-hoi9iw7kvg&address={0}", Uri.EscapeDataString(address));

                    if (direccion2 != direccion1)
                    {
                        using (var client = new HttpClient())
                        {
                            var request = await client.GetAsync(requestUri);
                            var content = await request.Content.ReadAsStringAsync();
                            RootObject root = JsonConvert.DeserializeObject<RootObject>(content);

                            double lat;
                            double lon;

                            foreach (var item in root.results)
                            {
                                lat = item.geometry.location.lat;
                                lon = item.geometry.location.lng;
                                gMapControl1.DragButton = MouseButtons.Left;
                                gMapControl1.CanDragMap = true;
                                gMapControl1.MapProvider = GMapProviders.GoogleMap;
                                gMapControl1.Position = new PointLatLng(lat, lon);
                                gMapControl1.MinZoom = 0;
                                gMapControl1.MaxZoom = 29;
                                gMapControl1.Zoom = 13;

                                markerOverlay = new GMapOverlay("Marcador");
                                marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.green);
                                markerOverlay.Markers.Add(marker);
                                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                                marker.ToolTipText = String.Format(direccion1 + ", MEDIDOR: " + medidor1);
                                gMapControl1.Overlays.Add(markerOverlay);
                            }
                        }
                    }
                    else
                    {

                    }


                    direccion2 = direccion1;

                }
                conexion.cerrarbd();
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

