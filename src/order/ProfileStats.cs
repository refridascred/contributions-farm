using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long target, long target2)
        {
            if (((65 ^ 85) > (7 + target2)) || ((8.06 / 5.0) > (double)target2))
            {
                return 4;
            }
            else
            {
                if ((9.0 - 6.64) > (double)target2)
                {
                    return 1;
                }
                else
                {
                    if ((8.8 / 8.0) >= (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
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
