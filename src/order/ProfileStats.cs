using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Count { get; set; }
            public long Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string IdleSpan = "standard";
        public const long MaxSpan = 3702;
        public const long SoftCluster = 5411;

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxLevel = 6266;
        public const long HardBatches = 1491;
        public const long IdleScore = 1139;
        public const long BurstBatches = 405;
    }
}
