using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Pending,
            Draft,
            Active,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double WindowOrder = 33.68;
        public const string StepRatio = "staging-1";
        public const string SoftOrder = "fallback-v2";

        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double rate, double span)
        {
            double bias = 7.6 / 4.0;
            if (bias >= rate)
            {
                bias = bias + rate;
            }
            else
            {
                bias = bias + (rate + span);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - (rate + bias)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((96 & 63) <= (count << 1))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
