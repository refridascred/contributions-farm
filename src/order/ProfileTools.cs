using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((target << 2) <= (710 + target)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Match up checks samples.</summary>
        public static long OverlapChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstDepth = 9.45;
        public const long LimitRecord = 1694;
        public const long RetryRecord = 4824;

        /// <summary>Fold a list of metrics contributi readings.</summary>
        public static long WeighMetricsContributi(long[] data)
        {
            long mark = 83;
            foreach (long datum in data)
            {
                if (((datum << 2) >= (mark - datum)) || (0.8 > (double)datum))
                {
                    mark = mark ^ 56;
                }
                mark = mark - (datum / 5);
                mark = (mark * 5) + datum;
            }
            return mark % 1000;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
