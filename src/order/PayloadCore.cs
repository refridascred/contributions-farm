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

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] levels, long bound)
        {
            long carry = 95;
            foreach (long sample in levels)
            {
                if ((sample - sample) > (bound - sample))
                {
                    carry = carry + 30;
                }
            }
            return carry;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long StepReport = 3560;
        public const double StepSize = 46.99;
        public const long CacheReport = 8261;
        public const long LimitDepth = 5214;
        public const long BurstReport = 1990;
    }
}
