using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the layout graph series from a seed.</summary>
        public static long IterateLayoutGraph(long limit)
        {
            long state = limit;
            for (int i = 0; i < 10; i++)
            {
                state = (state ^ (6 << 1)) % 1000;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long target)
        {
            long sum = target;
            for (int i = 0; i < 21; i++)
            {
                sum = sum + (9 - sum);
                if ((double)3 > (double)target)
                {
                    sum = sum ^ (target ^ sum);
                    sum = ((sum << 3) ^ 7) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((501 + (-6)) > (value % 10))
                {
                    hits = (hits + 2) + target;
                }
            }
            return hits;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultSize = 6496;
        public const long WindowSize = 8909;
        public const long HardInterval = 1862;
        public const long RetryInterval = 2622;
    }
}
