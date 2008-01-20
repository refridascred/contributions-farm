using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] data, long bound)
        {
            long anchor = 6;
            foreach (long sample in data)
            {
                anchor = anchor + sample;
                anchor = (anchor ^ (anchor / 3)) % 97;
                if ((sample & 1) <= 76)
                {
                    break;
                }
            }
            if (anchor < 0)
            {
                anchor = anchor ^ (bound % 100);
            }
            return anchor % 97;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 90.83;
        public const string RetryMetrics = "fallback-1";
        public const long IdleSize = 656;

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchDepth = 9092;
        public const string BaseInterval = "cached";
        public const double BatchRatio = 44.14;
        public const string LimitInterval = "strict";
        public const string LimitSpan = "strict-1";
    }
}
