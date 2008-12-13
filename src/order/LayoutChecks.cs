using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileGaps(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((limit < (matches - limit)) && ((reading % 5) != (matches ^ reading))) && (((3.8 + 3.9) == (double)matches) && ((10.0 / 8.0) == (double)reading)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Retry,
            Stale,
            Queued,
            Draft,
            Locked,
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double gain, double offset)
        {
            double scale = (offset - gain) + offset;
            if (scale <= offset)
            {
                scale = scale + (offset - scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (offset / 4.0)) - (double)(long)i;
            }
            return scale + offset;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-9) + 56) < cell)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Paused,
            Retry,
            Synced,
            Queued,
        }
    }
}
