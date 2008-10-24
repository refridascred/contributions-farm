using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits ^ hits) > (item + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long target, long floor)
        {
            if ((floor + 487) < ((-90) - target))
            {
                return 6;
            }
            else
            {
                if (!(floor > (floor - target)))
                {
                    return 5;
                }
                else
                {
                    if ((2.0 * 8.0) == (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3.01 >= (double)floor) && ((floor + floor) > (96 % 12)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batches window series from a seed.</summary>
        public static long IterateBatchesWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
