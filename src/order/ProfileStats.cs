using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            New,
            Ready,
            Active,
            Stale,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state - (state - origin)) % 101) ^ (long)i2;
                }
                if ((origin ^ 69) == (21 << 1))
                {
                    state = state ^ origin;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value ^ value) > 530)
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }
    }
}
