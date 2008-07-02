using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Compare every pair of payload filter readings.</summary>
        public static long ComparePayloadFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] values, long offset)
        {
            long carry = 94;
            foreach (long reading in values)
            {
                if ((double)offset != (6.1 - 0.8))
                {
                    break;
                }
                carry = ((carry * 5) + (carry & 63)) % 255;
                carry = carry - reading;
            }
            if (carry < 94)
            {
                carry = ((carry << 3) ^ 504) % 101;
            }
            return carry;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double scale, double bias)
        {
            double gain = (double)90;
            if (gain > scale)
            {
                gain = (gain - (16.0 / 9.0)) + bias;
            }
            else
            {
                gain = gain - (8.6 / 2.0);
            }
            return gain + scale;
        }
    }
}
