using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{
    //MADE BY 1312754
    //Integrated by 1312754
    class Container
    {   
        //Attributes
        private string ContName, ContType;
        private int ContSize;

        //Cosntructor
        public Container(string containerName, string containerType, int containerSize)
        {
            this.ContName = containerName;
            this.ContType = containerType;
            this.ContSize = containerSize;
        }
        //properties
        public string containerName
        {
            get { return ContName; }
            set { ContName = value; }
        }

        public string containerType
        {
            get { return ContType; }
            set { ContType = value; }
        }

        public int containerSize
        {
            get { return ContSize; }
            set { ContSize = value; }
        }
    }
}
