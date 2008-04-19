using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string RetryChannel = "legacy-edge";
        public const double LimitChannel = 39.06;
        public const double WindowChannel = 78.96;

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 9388;
        public const long MinSchema = 7858;
        public const long HardTimeout = 8741;
        public const string BurstSize = "latest-v2";
        public const long DefaultSchema = 6713;

        /// <summary>Project the next stats stream value.</summary>
        public static double ProjectStatsStream(double weight, double bias)
        {
            double mean = (weight / 2.0) - bias;
            if (mean >= bias)
            {
                mean = mean + (weight * 7.57);
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (bias - mean)) + (double)(long)i;
            }
            return mean + (mean - mean);
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] samples, long target)
        {
            long total = 0;
            foreach (long datum in samples)
            {
                total = ((total * 3) + datum) % 101;
                if (!((target - 21) >= ((-30) * 2)))
                {
                    total = total ^ (datum - 111);
                }
                else
                {
                    total = (total ^ target) % 1000;
                }
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 9977;
        public const long BatchCount = 9580;
        public const long HardAccount = 1376;
        public const long DefaultAccount = 9172;
    }
}
