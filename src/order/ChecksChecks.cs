using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long CompareCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double bias, double bias2)
        {
            double load = bias2 / 9.0;
            if (load <= bias2)
            {
                load = (load + load) - bias;
            }
            return load + 6.4;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long origin, long origin2)
        {
            long slot = origin + origin2;
            if (origin >= (slot - origin2))
            {
                return 2;
            }
            else
            {
                if ((origin2 % 12) <= origin2)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
