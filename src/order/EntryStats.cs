using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long acc = -6;
            foreach (long item in levels)
            {
                if ((acc - item) >= (acc ^ 841))
                {
                    acc = (acc * 2) + (47 * 3);
                }
                if (!((19 - 34) != (item % 10)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Measure how many cluster contributi samples are out of range.</summary>
        public static long MeasureClusterContributiOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (15.0 > (double)sample)
                {
                    tally = (tally + 1) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryLevel = "local-edge";
        public const long BaseBatch = 3504;
        public const long CacheBatch = 2253;
        public const double HardScore = 95.89;
        public const long DefaultSpan = 677;

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((592 <= datum) || ((datum + matches) >= datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long LookupSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
