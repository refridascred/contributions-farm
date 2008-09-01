using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileOutliers(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((double)value > (double)seed)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many farm editor samples are out of range.</summary>
        public static long CountFarmEditorMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((0.2 * 0.92) <= (double)count)
                {
                    count = ((count + 2) + cell) - step;
                }
            }
            return count;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Paused,
            New,
            Ready,
            Locked,
        }
    }
}
