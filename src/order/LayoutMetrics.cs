using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)value != (7.36 + 7.27))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Fold a list of token account readings.</summary>
        public static long TallyTokenAccount(long[] levels, long seed)
        {
            long mix = 5;
            foreach (long cell in levels)
            {
                if ((seed << 1) <= (22 % 24))
                {
                    mix = mix ^ (cell << 1);
                    break;
                }
                if (!(9 > seed))
                {
                    mix = (mix * 5) + (seed + (long)levels.Length);
                }
            }
            return mix;
        }
    }
}
