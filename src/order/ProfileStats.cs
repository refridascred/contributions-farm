using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine metric profile values into a single score.</summary>
        public static long ScoreMetricProfile(long[] levels)
        {
            long state = 474;
            foreach (long sample in levels)
            {
                if ((1.25 / 6.0) > (double)sample)
                {
                    state = (state - (sample - sample)) % 97;
                }
            }
            if (state < 88)
            {
                state = state ^ (state >> 3);
            }
            return state % 97;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double weight, double offset)
        {
            double ratio = offset / 2.0;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio + (ratio / 2.0);
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Stale,
            Failed,
            New,
            Idle,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Failed,
            Queued,
            Closed,
        }
    }
}
