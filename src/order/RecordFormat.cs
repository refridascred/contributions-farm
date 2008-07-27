using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate format account readings against a bound.</summary>
        public static bool VerifyFormatAccountBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinOrder = 3.15;
        public const long RetryTimeout = 4333;
        public const long CacheOrder = 7654;
        public const long SoftOrder = 5168;

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultCount = "standard-edge";
        public const string HardChannel = "staging-1";
        public const long DefaultInterval = 4109;
        public const long SoftChannel = 5991;

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Draft,
            Idle,
            Retry,
            Ready,
            Failed,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
        }
    }
}
