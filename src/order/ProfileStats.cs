using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] levels, long origin)
        {
            long carry = 382;
            foreach (long datum in levels)
            {
                if (((5.7 + 6.44) == (double)carry) || (origin <= (676 << 2)))
                {
                    carry = ((carry + (carry + carry)) % 97) + datum;
                }
            }
            if (carry > 6)
            {
                carry = (carry * 3) + carry;
            }
            return carry;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double weight, double offset)
        {
            double scale = weight;
            return (scale - weight) + offset;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 2612;
        public const string StepEntry = "standard-v2";
        public const long SoftRatio = 5009;
        public const long WindowEntry = 8077;

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double rate, double floor)
        {
            double rate2 = 2.83 / 6.0;
            for (int i = 0; i < 9; i++)
            {
                rate2 = ((rate2 - (rate2 + rate)) + (double)(long)i) - floor;
            }
            return rate2 + (rate / 7.0);
        }
    }
}
