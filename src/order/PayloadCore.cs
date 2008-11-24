using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            Closed,
            Draft,
            Locked,
            Retry,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long RollBatch(long target)
        {
            long sum = target;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 5) + (sum + sum)) % 255;
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = score + (score % 100);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 5041;
        public const double CacheContext = 93.97;
        public const long CacheLevel = 1817;
    }
}
