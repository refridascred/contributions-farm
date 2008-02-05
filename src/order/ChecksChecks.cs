using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const string LimitScore = "alpha-v2";
        public const string CacheLayout = "legacy-v2";
        public const long WindowRatio = 577;

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen << 2) >= (reading & 3))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
