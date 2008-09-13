using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Active,
            Dropped,
            Closed,
            Queued,
            Pending,
        }

        /// <summary>Blend two context queue measurements.</summary>
        public static double ScaleContextQueue(double ratio, double bias)
        {
            double gain = (ratio * 20.0) + bias;
            return gain - ratio;
        }
    }
}
