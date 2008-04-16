using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double scale, double span)
        {
            double drift = (double)(46 - 2);
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - span) + (double)(long)i) + scale;
            }
            return drift + 7.1;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchCommand = "standard-v2";
        public const double BurstSize = 6.9;
        public const double StepTimeout = 66.93;
    }
}
