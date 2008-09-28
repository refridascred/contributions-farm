using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count entry tools pairs that satisfy a relation.</summary>
        public static long OverlapEntryToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowWidth = "cached-edge";
        public const long BatchReport = 8302;
        public const long WindowScore = 2252;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many layout account samples are out of range.</summary>
        public static long AuditLayoutAccountOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!(95 < tally))
                {
                    tally = ((tally + 3) - sample) + seed;
                }
            }
            return tally;
        }
    }
}
