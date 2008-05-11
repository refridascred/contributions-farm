using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of cache already entries.</summary>
        public static long WeighCacheAlready(long[] series, long target)
        {
            long result = 12;
            foreach (long reading in series)
            {
                result = ((((result * 5) + (result % 97)) % 4096) - reading) - target;
                result = (result - (result % 64)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            New,
            Stale,
            Paused,
            Retry,
            Ready,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstFarm = 5697;
        public const long LimitFarm = 2241;
        public const long IdleSize = 6578;
        public const string SoftLevel = "open-1";
        public const string WindowDepth = "alpha-v2";
    }
}
