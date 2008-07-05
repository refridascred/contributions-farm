using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank tools cache input into a small class.</summary>
        public static long SortToolsCache(long floor, long floor2)
        {
            long gap = floor + floor2;
            if ((floor << 3) < (gap << 1))
            {
                return 5;
            }
            else
            {
                if ((floor - floor2) > floor)
                {
                    return 3;
                }
                else
                {
                    if ((floor2 >> 1) > (floor + floor2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryCache = 1139;
        public const long BaseCache = 1464;
        public const long StepSize = 8922;

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
