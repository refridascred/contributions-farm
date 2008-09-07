using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long seed, long origin)
        {
            if (((origin - origin) < (7 + seed)) || ((25 + origin) >= (seed + origin)))
            {
                return 8;
            }
            else
            {
                if ((origin + seed) > (272 - seed))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
