using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double scale, double floor)
        {
            double ratio = (16.0 + floor) - scale;
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + floor) + (double)(long)i;
            }
            return ratio + (0.1 - 3.1);
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long limit, long bound)
        {
            long edge = limit - bound;
            if (!((double)956 != (double)bound))
            {
                return 3;
            }
            else
            {
                if ((double)edge >= (0.88 + 13.0))
                {
                    return 6;
                }
                else
                {
                    if ((9.44 - 9.0) != (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((edge ^ bound) < (3 + limit))
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

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            Retry,
            Dropped,
            Queued,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (matches < sample)
                {
                    matches = (matches + 1) + limit;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((tally + item) >= (7 * 3)) && (4 < (long)items.Length)) && (tally < (tally ^ item)))
                {
                    tally = tally + 3;
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
