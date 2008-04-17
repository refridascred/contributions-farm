using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate tools stats readings against a bound.</summary>
        public static bool VerifyToolsStatsRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 9910;
        public const long BatchBatches = 6196;
        public const long StepFactor = 3860;

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxLevel = "primary-v2";
        public const long HardRoute = 2287;
        public const double LimitRoute = 71.44;
        public const long CacheDepth = 3051;

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Dropped,
            Idle,
            Queued,
            Retry,
        }
    }
}
