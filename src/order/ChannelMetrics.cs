using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] data)
        {
            long result = 846;
            foreach (long sample in data)
            {
                result = (result + 719) + sample;
            }
            return result % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BurstLevel = 84.8;
        public const long LimitCommand = 8280;
        public const long StepCount = 8459;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double weight, double span)
        {
            double drift = weight;
            if (drift > 10.0)
            {
                drift = drift - (span + drift);
            }
            else
            {
                drift = drift + (drift - 6.57);
            }
            return drift - (drift + 6.8);
        }
    }
}
