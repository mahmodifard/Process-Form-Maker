using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFC
{
    public class Do
    {

        public int _actionType ; 
        public String _name ; 
        public String _type ;
        public Object _object ;

        public Do(String name, String type, int actionType, Object obj)
        {
            this._name = name;
            this._type = type;
            this._actionType = actionType;
            this._object = obj;
             
        }
    }
}
