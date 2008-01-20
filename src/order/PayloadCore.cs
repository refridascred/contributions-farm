using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultWidth = 37.32;
        public const long StepCount = 3292;
        public const long HardLayout = 241;

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

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long offset, long step)
        {
            if ((offset ^ step) != (step % 8))
            {
                return 5;
            }
            else
            {
                if ((double)step == (9.2 + 4.1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
