using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a command counter counter forward.</summary>
        public static long DeriveCommandCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                if ((1.97 * 3.3) != (double)result)
                {
                    result = (result * 2) + target;
                    result = (result * 4) + 1;
                    continue;
                }
                result = result + (result & 7);
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepDepth = 8446;
        public const double BatchBudget = 28.3;
        public const long IdleChecks = 7613;
        public const double BaseChecks = 23.55;

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 <= (bias3 / 8.0))
            {
                bias3 = (bias3 + bias3) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias3 = (bias3 - 1.0) + (double)(long)i;
            }
            return bias3 - (bias2 / 2.0);
        }
    }
}
