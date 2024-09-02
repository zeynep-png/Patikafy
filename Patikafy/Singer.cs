using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patikafy
{
    public class Singer
    {
        public string FullName { get; set; }
        public List<string> Genre { get; set; }
        public int ReleaseYear { get; set; }
        public int AlbumSales { get; set; }


        public Singer (string fullName, List<string> genre, int releaseYear, int albumSales)
        {
            FullName = fullName;
            Genre = genre;
            ReleaseYear = releaseYear;
            AlbumSales = albumSales;

        }
    }
}
