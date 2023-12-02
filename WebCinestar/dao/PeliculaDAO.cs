using System.Collections.Generic;
using System.Data;
using WebCinestar.bean;
using WebCinestar.db;
using WebCinestar_webforms;

namespace WebCinestar_webForms.dao
{
    public class PeliculaDAO
    {

        Db db = new Db("cnCineStar");


        internal object getPelicula(int id)
        {
            db.Sentencia("sp_getPelicula " + id);
            List<Pelicula> Peliculas = new List<Pelicula>();
            peliculas.Add(new Pelicula(db.getDataRow()));
            return Peliculas;
            //return db.getDataTable();
        }

        internal object getPeliculas(int id)
        {
            db.Sentencia("sp_getPeliculas " + id);
            DataTable dt = db.getDataTable();

            if ( dt != null || dt.Rows.Count > 0)
            {
                List<Pelicula> peliculas = new List<Pelicula>();
                foreach (DataRow dr in dt.Rows)
                    peliculas.Add(new Pelicula(dr) );
                return peliculas;
            }
            return null;
        }

    }
}