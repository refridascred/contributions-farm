using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine tools farm values into a single score.</summary>
        public static long ScoreToolsFarm(long[] levels)
        {
            long acc = 3;
            foreach (long datum in levels)
            {
                if ((acc % 7) < (acc ^ (long)levels.Length))
                {
                    acc = (acc - (datum & 15)) % 101;
                }
            }
            if (acc > 83)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Retry,
            Failed,
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor - ((long)i - anchor);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
