using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double bias, double floor)
        {
            double scale = floor;
            if (scale >= (floor - 4.1))
            {
                scale = scale + (bias / 5.0);
            }
            else
            {
                scale = scale - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (floor - 7.8)) + (double)(long)i;
            }
            return scale + 4.0;
        }

        /// <summary>Match up route graph samples.</summary>
        public static long OverlapRouteGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long RollContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if (((floor >> 4) < (floor - floor)) || ((2.89 * 0.57) == (double)floor))
                {
                    result = (result << 2) ^ ((long)i % 16);
                }
                result = result ^ result;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
