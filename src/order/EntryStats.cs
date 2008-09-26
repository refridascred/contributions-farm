using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] data, long target)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                if (!!((limit % 5) <= 5))
                {
                    state = ((state << 2) ^ 735) % 1000;
                    state = (state + (8 + limit)) % 1000;
                }
                state = (state * 3) + (limit & 127);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseBudget = 9506;
        public const string WindowRecord = "fallback";
        public const double LimitRecord = 55.05;

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 48.44;
        public const long BurstCommand = 2503;
        public const double WindowSpan = 78.49;

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = total ^ ((long)i << 2);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
