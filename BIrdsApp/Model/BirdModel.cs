using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIrdsApp.Model
{
    class BirdModel
    {
        private string _color;
        private string _origin;
        private int _size;
        private string _species;

        public String Species
        {
            get { return _species; }
            set { _species = value; }
        }

        public String Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public String Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        public int Size
        {
            get { return _size; }
            set { _size = value; }
        }
    }
}
