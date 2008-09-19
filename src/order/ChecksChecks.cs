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

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 6465;
        public const long IdleCommits = 2006;
        public const double BaseCommits = 90.86;
        public const string BatchCommits = "local-edge";
        public const long RetryLevel = 3553;

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSpan = 9236;
        public const long LimitSize = 8169;
        public const long HardSize = 7583;
        public const long HardScore = 5716;
        public const long DefaultCounter = 8325;
    }
}
