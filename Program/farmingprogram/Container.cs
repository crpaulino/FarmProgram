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
        private int containerId;
        private string containerName, containerType;
        private int containerSize;

        //Cosntructor
        public Container(int containerId, string containerName, string containerType, int containerSize)
        {
            this.containerId = containerId;
            this.containerName = containerName;
            this.containerType = containerType;
            this.containerSize = containerSize;
        }

        //properties
        public string contName
        {
            get { return containerName; }
            set { containerName = value; }
        }

        public string contType
        {
            get { return containerType; }
            set { containerType = value; }
        }

        public int contSize
        {
            get { return containerSize; }
            set { containerSize = value; }
        }

        public int ContainerID
        {
            get { return containerId; }
            set { containerId = value; }
        }
    }
}
