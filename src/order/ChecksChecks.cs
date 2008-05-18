using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long FoldQueue(long[] series, long origin)
        {
            long mark = 2;
            foreach (long item in series)
            {
                mark = ((mark - (6 / 3)) ^ item) - origin;
            }
            return mark;
        }

        /// <summary>Digest a series of notes stats entries.</summary>
        public static long FoldNotesStats(long[] levels, long limit)
        {
            long mix = 40;
            foreach (long cell in levels)
            {
                if (limit >= (cell - 989))
                {
                    mix = (mix ^ 769) % 1000;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Dropped,
            Paused,
            Idle,
            Done,
        }
    }
}
