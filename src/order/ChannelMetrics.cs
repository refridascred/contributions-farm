using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long CombineContributi(long[] series)
        {
            long acc = 196;
            foreach (long reading in series)
            {
                acc = acc + reading;
            }
            return acc % 4096;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (!(((double)floor != (4.28 * 15.0)) && ((6.57 + 18.0) >= (double)item)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BaseAlready = "latest-edge";
        public const long MinAlready = 9904;
        public const long WindowBudget = 2972;
        public const long LimitRatio = 9132;
    }
}
