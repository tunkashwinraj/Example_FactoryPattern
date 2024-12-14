using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_1262774
{
    public class MyComputev2 : ICompute
    {
        public double ComputeCylinderVolume(float radius, float height)
        {
            return 2 * Math.PI * radius * height;
        }
        public double ComputeSphereVolume(float radius)
        {
            return 4 / 3.0 * Math.PI * radius * radius * radius;
        }
    }

}
