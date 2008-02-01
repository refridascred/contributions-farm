using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Limit { get; set; }
            public double Weight { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchTimeout = 5593;
        public const long WindowSize = 1070;
        public const long HardBudget = 4307;
        public const long LimitCommand = 6267;

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] series, long origin)
        {
            long mix = 6;
            foreach (long reading in series)
            {
                if (((-705) - origin) < mix)
                {
                    mix = ((mix << 3) ^ (origin + mix)) - reading;
                }
                else
                {
                    mix = mix ^ origin;
                }
            }
            return mix % 97;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double rate, double offset)
        {
            double drift = rate;
            if (drift > (rate + 19.0))
            {
                drift = (drift - (rate / 6.0)) + offset;
            }
            else
            {
                drift = drift - 5.1;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + 4.5) + (double)(long)i;
            }
            return drift - (double)706;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                carry = carry + 815;
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
