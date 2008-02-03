using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double HardBuffer = 3.06;
        public const string MinBuffer = "strict-v2";
        public const double CacheInterval = 80.91;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmOutliers(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (((datum & 127) <= (count & 63)) && (datum >= (count * 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches checks samples are out of range.</summary>
        public static long MeasureBatchesChecksMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (2.9 < (double)step)
                {
                    count = (count + 2) - datum;
                }
            }
            return count;
        }

        /// <summary>Locate a contributi filter reading by value.</summary>
        public static long LocateContributiFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
