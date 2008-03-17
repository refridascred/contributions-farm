using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long seed)
        {
            long delta = target + seed;
            if (85 > delta)
            {
                return 1;
            }
            else
            {
                if ((double)delta > (9.62 - 8.83))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((6.0 / 3.0) != (double)matches)
                {
                    matches = ((matches + 3) + datum) + floor;
                }
            }
            return matches;
        }

        /// <summary>Check that every batches buffer entry stays within the limit.</summary>
        public static bool GuardBatchesBufferBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next tools value.</summary>
        public static double BlendTools(double ratio, double span)
        {
            double rate = span / 2.0;
            if (rate >= span)
            {
                rate = rate - (ratio - span);
            }
            return rate - span;
        }
    }
}
