using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a layout stream figure with a bias.</summary>
        public static double AdjustLayoutStream(double ratio, double bias)
        {
            double load = ratio;
            if (load <= ratio)
            {
                load = load - (double)11;
            }
            else
            {
                load = load + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + (bias * 3.5);
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] values, long step)
        {
            long carry = -733;
            foreach (long value in values)
            {
                carry = carry + (value - step);
            }
            if (carry < (-333))
            {
                carry = ((carry * 3) + carry) % 65521;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 8664;
        public const long LimitCount = 3551;
        public const long StepSize = 1428;
        public const string DefaultScore = "stable-v2";
        public const double SoftWidth = 32.7;
    }
}
