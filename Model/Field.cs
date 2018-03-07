using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public struct Field
    {

       public Field(int roow, int collumn) { Row = roow;Column = collumn; }


        public readonly int Row;
        public readonly int Column;

    }
}
