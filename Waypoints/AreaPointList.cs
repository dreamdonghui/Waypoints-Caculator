//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Waypoints
//{
//    class AreaPointList
//    {
//    }
//}
using System;
using System.Collections.Generic;
// Simple business object. A PartId is used to identify the type of part
// but the part name can change.
public class AreaPointList : IEquatable<AreaPointList>
{
    public int index;

    public float Lat { get; set; }

    public float Lon { get; set; }

    public override string ToString()
    {
        return "Index: " + index + "   Lon:" + Lon + "   Lat: " + Lat;
    }
    public override bool Equals(object obj)
    {
        if (obj == null) return false;
        AreaPointList objAsPart = obj as AreaPointList;
        if (objAsPart == null) return false;
        else return Equals(objAsPart);
    }
    public override int GetHashCode()
    {
        return index;
    }
    public bool Equals(AreaPointList other)
    {
        if (other == null) return false;
        return (this.index.Equals(other.index));
    }
    // Should also override == and != operators.
}
