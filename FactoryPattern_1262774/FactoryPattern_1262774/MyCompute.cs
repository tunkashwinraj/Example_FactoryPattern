using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_1262774
{
    public class MyCompute : ICompute
    {
        public double ComputeCylinderVolume(float radius, float height)
        {
            return 2 * 3.1415 * radius * height;
        }
        public double ComputeSphereVolume(float radius)
        {
            return 4 / 3.0 * 3.1415 * radius * radius * radius;
        }
    }

}
