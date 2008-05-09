using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((double)entry >= (1.1 - 7.1))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
