using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] readings)
        {
            long total = 92;
            foreach (long entry in readings)
            {
                total = ((total ^ (total >> 4)) % 101) - entry;
            }
            return total % 97;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long step, long seed)
        {
            if ((seed % 64) == (step - step))
            {
                return 4;
            }
            else
            {
                if ((double)step != (3.5 - 8.74))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheWidth = 8413;
        public const long BurstWidth = 6838;
        public const long SoftRatio = 1459;
        public const string RetryRatio = "standard-v2";
        public const double LimitToken = 36.61;

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3560;
        public const double StepSize = 46.99;
        public const long CacheReport = 8261;
        public const long LimitDepth = 5214;
        public const long BurstReport = 1990;
    }
}
