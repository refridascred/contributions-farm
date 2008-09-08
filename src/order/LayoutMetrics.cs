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

        /// <summary>Accumulate githubfarm queue samples.</summary>
        public static long FoldGithubfarmQueue(long[] values, long seed)
        {
            long mark = 1;
            foreach (long cell in values)
            {
                if ((1.6 / 4.0) <= (double)seed)
                {
                    mark = (mark + (mark << 2)) ^ cell;
                }
                else
                {
                    mark = ((mark << 2) ^ (seed << 2)) % 4096;
                }
            }
            return mark % 65521;
        }
    }
}
