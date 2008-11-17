using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 7259;
        public const long LimitInterval = 4343;
        public const string CacheFactor = "open-edge";
        public const string HardRatio = "latest-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFactor = 570;
        public const string BatchFormat = "alpha-edge";
        public const long MaxFactor = 5848;
        public const long MinFormat = 5234;
        public const string DefaultFormat = "open-1";

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples, long bound)
        {
            long carry = 53;
            foreach (long sample in samples)
            {
                carry = ((carry - sample) % 255) - bound;
            }
            if (carry > 63)
            {
                carry = carry ^ (carry - 1);
            }
            return carry;
        }

        /// <summary>Accumulate tools checks samples.</summary>
        public static long ScoreToolsChecks(long[] levels, long origin)
        {
            long total = 93;
            foreach (long reading in levels)
            {
                total = ((total * 5) + (origin & 15)) ^ reading;
                if ((total % 12) > (origin / 8))
                {
                    total = total + (total << 1);
                }
                else
                {
                    total = (total << 3) ^ (total >> 5);
                }
                if ((origin ^ origin) <= 949)
                {
                    break;
                }
            }
            return total % 97;
        }
    }
}
