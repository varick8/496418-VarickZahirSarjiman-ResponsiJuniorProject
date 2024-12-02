using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi2Junpro
{
    public class employee
    {
        private string name;
        private string departement;
        private string position;

        public string Name
        {
            get { return name; }
            set{ name =value; }
        }
        public string Departement
        {
            get { return departement; }
            set { departement = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
