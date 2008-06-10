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

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public bool Owner { get; set; }
            public string Score { get; set; } = "";
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

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
