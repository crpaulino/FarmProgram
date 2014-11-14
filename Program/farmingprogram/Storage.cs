using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{
    //MADE BY 1307211
    //Integrated by 1312754
    class Storage
    {
        //attribute
        private int StorageCapacity, StorageAvailable;
        private string StorageName, StorageNote;

        //Constructor
        public Storage(string storageName, int storageCapacity, int storageAvailable, string storageNote)
        {
            this.StorageName = storageName;
            this.StorageCapacity = storageCapacity;
            this.StorageAvailable = storageAvailable;
            this.StorageNote = storageNote;
        }

        //Properties
        public string storageName
        {
            get { return StorageName; }
            set { StorageName = value; }
        }

        public int storageCapacity
        {
            get { return StorageCapacity; }
            set { StorageCapacity = value; }
        }

        public int storageAvailable
        {
            get { return StorageAvailable; }
            set { StorageAvailable = value; }
        }

        public string storageNote
        {
            get { return StorageNote; }
            set { StorageNote = value; }
        }

    }
}
