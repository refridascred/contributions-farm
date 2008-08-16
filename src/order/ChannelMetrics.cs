using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheFactor = 19.54;
        public const double IdleEditor = 74.3;
        public const long BurstTimeout = 5157;
        public const long SoftBudget = 8328;
        public const long BurstSpan = 1644;

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long step)
        {
            if (218 < (origin * 3))
            {
                return 5;
            }
            else
            {
                if ((double)step < (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (5.1 - 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin >= (1.3 * 6.15))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks account samples are out of range.</summary>
        public static long MeasureChecksAccountHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally % 24) < (sample % 16))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
