using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats window readings against a rule.</summary>
        public static long AuditStatsWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell * 2) <= (99 * 4))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double rate, double offset)
        {
            double scale = offset;
            if (scale <= (double)25)
            {
                scale = scale + (rate - scale);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + 9.87) + (double)(long)i;
            }
            return scale + offset;
        }
    }
}
