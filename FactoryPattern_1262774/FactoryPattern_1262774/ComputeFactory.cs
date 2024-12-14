using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern_1262774
{
    public enum CVersion
    {
        v1_1,
        v2_0
    }

    public class ComputeFactory
    {
        public static ICompute CreateComputeObject(CVersion ver)
        {
            if (ver == CVersion.v1_1)
                return new MyCompute();
            else if (ver == CVersion.v2_0)
                return new MyComputev2();
            else
                throw new Exception("Unsupported version");
        }
    }

}
