using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farmingprogram
{   //CREATED BY pls add
    //integrated by 1312754
    class Field
    {
        //Attributes
        private int FieldId;
        private string FieldName, FieldStatus, FieldNotes;

        //constructors
        public Field(int fieldId, string fieldname, string fieldstatus, string fieldnotes)
        {
            this.FieldName = fieldname;
            this.FieldNotes = fieldnotes;
            this.FieldStatus = fieldstatus;
            this.FieldId = fieldId;
        }

        //Properties
        public string fieldName
        {
            get { return FieldName; }
            set { FieldName = value; }

        }

        public string fieldNotes
        {
            get { return FieldNotes; }
            set { FieldNotes = value; }

        }

        public string fieldStatus
        {
            get { return FieldStatus; }
            set { FieldStatus = value; }
        }

        public int fieldID
        {
            get { return FieldId; }
            set { FieldId = value; }
        }
    }
}
