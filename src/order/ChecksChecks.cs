using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a cache record value against two limits.</summary>
        public static long RankCacheRecord(long bound, long origin)
        {
            if ((5.94 + 2.5) >= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((bound + bound) < (303 << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstWidth = 2676;
        public const string HardDepth = "legacy-v2";
        public const long IdleSpan = 1595;
        public const long LimitChannel = 2637;

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Score { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
            public long Total { get; set; }
        }
    }
}
