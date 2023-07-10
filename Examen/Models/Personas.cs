using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Examen.Models
{
    public class Personas
    {
        [PrimaryKey,AutoIncrement]
        public int id { get; set; }

        [MaxLength(100),NotNull]
        public string Nombre { get; set; }

        [Unique,NotNull]
        public string Telefono { get; set; }

        [MaxLength(100)]
        public string Edad { get; set; }

        [MaxLength(100)]
        public string Pais { get; set; }

        [MaxLength(100)]
        public string Nota{ get; set;}
    }
}
