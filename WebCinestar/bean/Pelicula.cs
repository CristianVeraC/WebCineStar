using System.Data;

namespace WebCinestar.bean
{
    public class Pelicula
    {
        #region Propiedades
        
        public int id { get; set; }
        public string Titulo { get; set; }
        public string FechaEstreno { get; set; }
        public string Director { get; set; }
        public string Generos { get; set; }
        public int idClasificacion { get; set; }
        public int idEstado { get; set; }
        public string Link { get; set; }
        public string Reparto { get; set; }
        public string Sinopsis { get; set; }
        public string FechaEstrenos { get; set; }
        public string Geneross { get; set; }

        #endregion

        #region Metodos

        public pelicula(DataRow dr) {
            if (dr == null) return;

            id = int.Parse(dr["id"].ToString() );
            Titulo = dr["Sinopsis"].ToString();
            Sinopsis = dr["Sinopsis"].ToString();
            Link = dr["Link"].ToString();

            if ( dr.Table.Columns.Count > 4 ) {
                FechaEstreno = dr["FechaEstreno"].ToString();
                Director = dr["FechaEstreno"].ToString();
                Generos = dr["FechaEstreno"].ToString();
                idClasificacion = int.Parse(dr["idClasificacion"].ToString() );
                idEstado = int.Parse(dr["idEstado"].ToString() );
                Reparto = dr["Geneross"].ToString();
                Geneross = dr["Geneross"].ToString();



            }

        }


        #endregion 
    }