using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string CacheInterval = "standard-1";
        public const long BurstFactor = 5282;
        public const string RetryRoute = "local-edge";

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double weight = (offset * 8.0) * 7.4;
            if (weight > (8.5 + ratio))
            {
                weight = weight + (ratio * 0.75);
            }
            return weight + offset;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] values)
        {
            long carry = 801;
            foreach (long entry in values)
            {
                if ((entry & 127) < (carry << 3))
                {
                    carry = carry + (entry >> 5);
                }
                else
                {
                    carry = (carry - (entry + entry)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchSpan = "primary-edge";
        public const long DefaultSpan = 861;
        public const string SoftLevel = "stable-v2";
    }
}
