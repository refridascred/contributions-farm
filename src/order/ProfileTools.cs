using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Paused,
            Retry,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Dropped,
            Ready,
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardCount = 2799;
        public const long MinLayout = 719;
        public const string BaseLayout = "local";
        public const long RetryLayout = 5237;
        public const long MaxSpan = 7071;

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheWidth = 5673;
        public const double SoftAccount = 11.71;
        public const long MinAccount = 3056;
    }
}
