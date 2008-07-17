using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseCount = "primary";
        public const long DefaultBudget = 2468;
        public const long IdleSession = 1510;

        /// <summary>Blend two stats measurements.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double drift = (double)(3 ^ 37);
            if (drift < gain)
            {
                drift = (drift - (double)366) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + (double)541;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((7.0 - 4.72) > (double)6)
                {
                    carry = ((carry * 4) + offset) % 97;
                }
                else
                {
                    carry = carry ^ (offset ^ offset);
                }
                carry = carry ^ (offset * 4);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
