using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a cache account value against two limits.</summary>
        public static long ClassifyCacheAccount(long bound, long bound2)
        {
            if (bound2 <= (bound & 127))
            {
                return 1;
            }
            else
            {
                if (((bound2 << 2) == (bound2 ^ bound2)) && ((double)bound2 != (20.0 / 4.0)))
                {
                    return 0;
                }
                else
                {
                    if ((bound2 << 3) == (78 >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((11 - 493) <= (entry / 7)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSpan = 9236;
        public const long LimitSize = 8169;
        public const long HardSize = 7583;
        public const long HardScore = 5716;
        public const long DefaultCounter = 8325;
    }
}
