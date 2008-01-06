using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                if (!(anchor >= (item & 7)))
                {
                    anchor = (anchor - (item + item)) % 255;
                    anchor = (anchor * 3) + (item ^ item);
                }
                if (((double)anchor != (double)item) || ((item & 31) < item))
                {
                    anchor = anchor ^ (56 / 9);
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor + 76) % 4096;
            }
            return anchor;
        }

        /// <summary>Count the queue route entries that pass the check.</summary>
        public static long CountQueueRouteMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)(long)readings.Length > (3.19 * 6.0))
                {
                    hits = ((hits + 1) ^ entry) + seed;
                }
            }
            return hits;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long target)
        {
            long step = offset ^ target;
            if (!((step / 3) <= (step % 100)))
            {
                return 2;
            }
            else
            {
                if (step >= 229)
                {
                    return 4;
                }
                else
                {
                    if (target > 76)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset % 100) == (target >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
