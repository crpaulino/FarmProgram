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
        private string FieldName, FieldStatus, FieldNotes;

        //constructors
        public Field(string fieldname, string fieldstatus, string fieldnotes)

        {
        this.FieldName = fieldname;
        this.FieldNotes = fieldnotes;
        this.FieldStatus = fieldstatus;
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
    }
}
