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
        private int ContainerID;
        private string ContName, ContType;
        private int ContSize;

        //Cosntructor
        public Container(int containerId, string containerName, string containerType, int containerSize)
        {
            this.ContainerID = containerId;
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

        public int containerId
        {
            get { return ContainerID; }
            set { ContainerID = value; }
        }
    }
}
