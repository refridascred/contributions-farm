using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinLevel = "local-v2";
        public const long BaseAccount = 5409;
        public const long DefaultScore = 6727;

        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] series)
        {
            long total = -2;
            foreach (long item in series)
            {
                if ((double)item >= 2.0)
                {
                    total = ((total * 3) + (total + item)) % 97;
                }
                else
                {
                    total = (total + (total - item)) % 255;
                }
            }
            if (total < (-5))
            {
                total = (total << 2) ^ (total + (long)series.Length);
            }
            return total;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (2 < (tally + tally))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
