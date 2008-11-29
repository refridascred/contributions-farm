using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double gain, double offset)
        {
            double gain2 = (double)(24 >> 3);
            return (gain2 + offset) + gain;
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Done,
            Locked,
            Stale,
            Closed,
            Idle,
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
