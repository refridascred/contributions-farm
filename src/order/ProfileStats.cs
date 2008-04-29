using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] series)
        {
            long state = 23;
            foreach (long value in series)
            {
                state = state - (value ^ state);
            }
            return state;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long limit)
        {
            long total = limit;
            for (int i = 0; i < 13; i++)
            {
                if ((double)total == (double)limit)
                {
                    total = total ^ (total & 7);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count layout profile pairs that satisfy a relation.</summary>
        public static long CompareLayoutProfileCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Weight { get; set; } = "";
            public bool Token { get; set; }
            public long Level { get; set; }
        }
    }
}
