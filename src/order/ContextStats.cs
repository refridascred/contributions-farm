using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Failed,
            New,
            Draft,
            Idle,
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double bias)
        {
            double load = 6.3;
            if (load > (double)979)
            {
                load = (load - scale) - bias;
            }
            else
            {
                load = load + scale;
            }
            for (int i = 0; i < 9; i++)
            {
                load = load + (double)(long)i;
            }
            return load + 5.0;
        }

        /// <summary>Check that every layout buffer entry stays within the limit.</summary>
        public static bool VerifyLayoutBufferRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
