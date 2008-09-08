using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            Dropped,
            Done,
            Failed,
        }

        /// <summary>Combine layout window values into a single score.</summary>
        public static long ScoreLayoutWindow(long[] levels, long bound)
        {
            long mix = 8;
            foreach (long item in levels)
            {
                mix = (mix * 3) + (mix + item);
                if (((long)levels.Length + bound) == (bound - 43))
                {
                    mix = (mix + (30 + 20)) % 255;
                }
            }
            return mix % 97;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] values)
        {
            long mark = 1;
            foreach (long value in values)
            {
                mark = ((mark * 2) + (472 + value)) % 4096;
                if ((double)mark <= (18.0 - 6.21))
                {
                    mark = (mark - (29 + value)) % 101;
                }
            }
            if (mark < 36)
            {
                mark = mark ^ (mark / 4);
            }
            return mark % 4096;
        }
    }
}
