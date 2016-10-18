using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_01
{
    class DisplayObject
    {
        private string _strName = "no name";
        public string Name
        {
            get
            {
                return _strName;
            }
            set
            {

                if (value == "") 
                {
                    _strName = "No Name";
                }
                else
                {
                    _strName = value;
                }
              
            }
        }

        public string ShowName()
        {
            return Name;
        }

        public void Clear()
        {
            _strName = "no name";
        }

    }
}
