using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a farm metrics sample.</summary>
        public static long LookupFarmMetricsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue checks samples are out of range.</summary>
        public static long AuditQueueChecksOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry ^ tally) > (entry % 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate order queue readings against a bound.</summary>
        public static bool ValidateOrderQueueRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metrics command readings.</summary>
        public static long TallyMetricsCommand(long[] readings, long limit)
        {
            long mark = 539;
            foreach (long reading in readings)
            {
                mark = ((mark << 2) ^ (reading + reading)) % 4096;
                mark = (mark ^ reading) % 255;
                if ((483 / 9) != (reading + mark))
                {
                    mark = (mark << 3) ^ mark;
                }
                else
                {
                    mark = mark - (mark % 10);
                }
                if (reading <= (reading * 3))
                {
                    break;
                }
            }
            if (mark > (-726))
            {
                mark = (mark << 3) ^ limit;
            }
            return mark % 1000;
        }
    }
}
