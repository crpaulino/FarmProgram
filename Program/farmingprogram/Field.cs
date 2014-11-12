//Coded by SID 13352132
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldsProgram
{
    class Fields
    {
        //Attributes
        public int FieldID;
        private string FieldName;
        private string FieldNotes;
        private string FieldStatus;

        //declaring properties
        public Fields(int fieldID, string fieldname, string fieldnotes,string Fieldstatus)

    {
        //constructors
        this.FieldID = fieldID;
        this.FieldName = fieldname;
        this.FieldNotes = fieldnotes;
        this.FieldStatus = Fieldstatus;

        //properties
    }
        public int fieldID
    {
        get { return FieldID; }
        set { fieldID = value;}

    }
        public string fieldName
        {
            get { return FieldName; }
            set { fieldName = value; }

        }

        public string fieldnotes
        {
            get { return FieldNotes; }
            set { fieldnotes = value; }

        }

        public string fieldstatus
        {
            get { return FieldStatus; }
            set { fieldstatus = value; }

        }
    }
}
