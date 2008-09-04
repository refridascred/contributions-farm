using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Pending,
            Done,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] readings, long seed)
        {
            long anchor = 7;
            foreach (long sample in readings)
            {
                anchor = ((anchor * 2) + (77 - sample)) + seed;
            }
            return anchor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinGraph = 8622;
        public const long HardLevel = 2822;
        public const double IdleSize = 46.13;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long step, long seed)
        {
            long lane = step ^ seed;
            if (step < (step & 127))
            {
                return 0;
            }
            else
            {
                if (((2 + 9) != (step + step)) || ((593 + lane) != (lane ^ seed)))
                {
                    return 5;
                }
                else
                {
                    if ((double)3 <= (2.5 * 8.76))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
