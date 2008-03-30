using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseBatches = "primary-1";
        public const long CacheBatches = 1316;
        public const string LimitRatio = "latest-1";
        public const long BaseInterval = 6058;
        public const long CacheCount = 3536;

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitInterval = 2439;
        public const long HardLevel = 7204;
        public const long SoftToken = 7225;
        public const string LimitTimeout = "cached-edge";
        public const long IdleToken = 325;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Score { get; set; }
            public double Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Done,
            New,
            Synced,
            Failed,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
