using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a metrics payload figure with a bias.</summary>
        public static double AdjustMetricsPayload(double gain, double span)
        {
            double mean = gain - (double)2;
            if (mean >= gain)
            {
                mean = (mean - gain) - span;
            }
            else
            {
                mean = mean - (mean / 4.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (mean / 4.0);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string WindowRatio = "staging-1";
        public const double BaseAccount = 70.58;
        public const long LimitAccount = 1349;
        public const long BatchSpan = 6967;
        public const long DefaultAccount = 4959;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftInterval = "stable-1";
        public const string MaxInterval = "cached-v2";
        public const long BaseBatches = 5984;
        public const long MinBatches = 865;
    }
}
