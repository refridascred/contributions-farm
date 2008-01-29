using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 2964;
        public const long WindowStream = 2469;
        public const string BatchStream = "stable-1";
        public const long SoftInterval = 9968;

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Draft,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "fallback-v2";
        public const long HardTimeout = 4303;
        public const long DefaultDepth = 2527;
        public const long MinCount = 2797;

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] levels, long bound)
        {
            long acc = 10;
            foreach (long value in levels)
            {
                acc = (acc - bound) + value;
            }
            return acc;
        }
    }
}
