using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long origin, long seed)
        {
            if (((origin % 24) > (seed + seed)) || ((7.75 * 8.79) > (double)origin))
            {
                return 2;
            }
            else
            {
                if ((double)origin >= (0.1 + 4.44))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double bias, double offset)
        {
            double ratio = offset;
            return (ratio - (17.0 + 2.1)) + bias;
        }
    }
}
