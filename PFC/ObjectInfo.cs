using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PFC
{
    [Serializable]
    class ObjectInfo
    {
        public String type;
        public String caption;
        public double x;
        public double y;
        public double width;
        public double height;
        public ObjectInfo(String type, String caption, double x, double y, double width, double height)
        {
            this.type = type;
            this.caption = caption;
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

    }
}
