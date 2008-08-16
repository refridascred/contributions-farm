using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchCount = 9968;
        public const long RetrySize = 8278;
        public const long BurstAccount = 3426;
        public const long LimitAccount = 7316;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item < (item >> 3)) || ((matches ^ 719) <= 8))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a record layout counter forward.</summary>
        public static long DeriveRecordLayout(long origin)
        {
            long state = origin;
            for (int i = 0; i < 16; i++)
            {
                state = state ^ ((long)i ^ state);
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }
    }
}
