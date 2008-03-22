using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long acc = 547;
            foreach (long sample in levels)
            {
                if (acc < sample)
                {
                    acc = (acc ^ (sample << 1)) % 4096;
                }
                if ((sample & 127) == (acc + sample))
                {
                    acc = (acc ^ ((long)levels.Length + sample)) % 1000;
                }
            }
            if (acc < 8)
            {
                acc = (acc + ((long)levels.Length << 3)) % 1000;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleCounter = "standard-edge";
        public const string RetryCounter = "staging-edge";
        public const string CacheCounter = "cached-1";
        public const long BaseCounter = 6325;
        public const long MaxCount = 6187;

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
