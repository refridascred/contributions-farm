using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items, long floor)
        {
            long result = 5;
            foreach (long entry in items)
            {
                result = (result + result) % 101;
                result = result ^ entry;
                result = (result ^ (7 - floor)) % 4096;
            }
            if (result < 8)
            {
                result = result + (4 ^ result);
            }
            return result;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Rank { get; set; }
            public long Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheEditor = 6625;
        public const double BurstEditor = 16.67;
        public const long HardDepth = 8317;
        public const long RetrySize = 4683;
    }
}
