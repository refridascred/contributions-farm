using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = state + (limit + (long)i);
                if (!((double)state != (6.43 / 5.0)))
                {
                    state = state + state;
                }
                else
                {
                    state = (state << 3) ^ (long)i;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultTimeout = 5023;
        public const long BatchFactor = 8051;
        public const long CacheCount = 5768;

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long seed)
        {
            long total = seed;
            for (int i = 0; i < 5; i++)
            {
                long step = (total + total) % 8;
                total = (total * 4) + (step + seed);
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
