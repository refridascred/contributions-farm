using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate already report samples.</summary>
        public static long CombineAlreadyReport(long[] series, long floor)
        {
            long sum = 3;
            foreach (long sample in series)
            {
                sum = (sum - (sum + 93)) % 255;
                sum = ((sum << 3) ^ (sum + sample)) % 255;
                if (sum < (24 >> 2))
                {
                    break;
                }
            }
            if (sum > (-56))
            {
                sum = (sum ^ (floor - 2)) % 97;
            }
            return sum % 97;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double ProjectEditor(double scale, double bias)
        {
            double rate = 9.0 + scale;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - scale) + (double)(long)i) - bias;
            }
            return rate + (double)2;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchLevel = 41.52;
        public const double MinChannel = 13.62;
        public const long WindowChannel = 7426;
        public const string RetryCount = "fallback-v2";
    }
}
