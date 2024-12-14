using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_1262774
{
    public interface ICompute
    {
        double ComputeCylinderVolume(float radius, float height);
        double ComputeSphereVolume(float radius);
    }

}
