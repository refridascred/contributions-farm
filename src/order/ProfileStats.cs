using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Stale,
            Closed,
            Failed,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 62.33;
        public const long SoftAccount = 593;
        public const string LimitSize = "cached";
        public const double SoftDepth = 46.88;
        public const long LimitSpan = 457;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] levels)
        {
            long state = 89;
            foreach (long entry in levels)
            {
                if (!((double)entry >= 4.67))
                {
                    state = (state << 3) ^ (6 & 127);
                }
            }
            return state;
        }
    }
}
