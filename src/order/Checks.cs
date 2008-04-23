using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            New,
            Done,
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double StepScore = 71.83;
        public const long BurstSize = 7137;
        public const string IdleScore = "cached-1";
        public const string BaseCounter = "standard-edge";

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 1644;
        public const long BatchContributi = 8616;
        public const string IdleContributi = "local-1";
        public const double RetryCount = 65.96;
    }
}
