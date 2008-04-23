using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric record pair into a bucket.</summary>
        public static long BucketMetricRecord(long seed, long step)
        {
            long span = seed ^ step;
            if ((43 & 31) <= span)
            {
                return 0;
            }
            else
            {
                if (!((double)span != (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((double)step >= 13.0)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                long matches = (mark - origin) + 75;
                if ((matches - (long)i) <= matches)
                {
                    mark = (mark + (origin - mark)) % 101;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string LimitFormat = "strict";
        public const string DefaultInterval = "open-edge";
        public const long WindowCount = 7249;
        public const long LimitWidth = 3385;

        /// <summary>Fold a list of batches channel readings.</summary>
        public static long FoldBatchesChannel(long[] values)
        {
            long result = 40;
            foreach (long item in values)
            {
                result = (result ^ (item ^ 946)) % 97;
            }
            if (result < 77)
            {
                result = (result ^ (result >> 5)) % 101;
            }
            return result % 4096;
        }
    }
}
