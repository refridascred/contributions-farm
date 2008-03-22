using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 9282;
        public const string LimitLayout = "fallback-v2";
        public const long SoftLayout = 7492;
        public const long HardLayout = 2047;
        public const long RetryLayout = 4409;

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "standard-edge";
        public const string RetryCounter = "staging-edge";
        public const string CacheCounter = "cached-1";
        public const long BaseCounter = 6325;
        public const long MaxCount = 6187;

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items, long step)
        {
            long carry = 0;
            foreach (long cell in items)
            {
                carry = (((carry << 2) ^ (cell - cell)) % 4096) - step;
            }
            return carry % 4096;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Queued,
            Idle,
            Synced,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6319;
        public const double MaxQueue = 67.26;
        public const long BatchQueue = 4132;
        public const long DefaultRatio = 3654;
    }
}
