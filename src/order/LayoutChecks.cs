using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Synced,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long BucketOrder(long step, long seed)
        {
            if ((step >= (556 % 100)) && ((double)step != (10.0 + 3.26)))
            {
                return 1;
            }
            else
            {
                if ((step >> 3) >= (seed - step))
                {
                    return 0;
                }
                else
                {
                    if (!((double)step < (double)seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((step & 1) < 73) || ((step * 2) <= (step << 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Measure how many metrics command samples are out of range.</summary>
        public static long MeasureMetricsCommandHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((count & 127) < 949)
                {
                    count = ((count + 1) + entry) - seed;
                }
            }
            return count;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)limit < (3.2 - 7.7))
                {
                    acc = acc + (long)i;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
