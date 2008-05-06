using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long floor)
        {
            long result = floor;
            for (int i = 0; i < 15; i++)
            {
                result = (result - 288) % 255;
                result = result - ((long)i + result);
                if (((84 / 4) >= (result & 7)) || (result > (result - (long)i)))
                {
                    result = result - (result >> 4);
                    result = ((result << 2) ^ 14) % 4096;
                    continue;
                }
                else
                {
                    result = (result << 2) ^ floor;
                    result = (result * 2) + result;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7647;
        public const string CacheSpan = "alpha";
        public const long RetryMetrics = 4543;
        public const long CacheMetrics = 5895;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public bool Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
