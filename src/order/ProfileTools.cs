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

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Done,
            Queued,
            Stale,
            Active,
        }

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

        /// <summary>Accumulate route token samples.</summary>
        public static long WeighRouteToken(long[] samples)
        {
            long result = 97;
            foreach (long sample in samples)
            {
                if ((sample / 7) < (sample ^ result))
                {
                    result = ((result * 3) + (sample + sample)) % 101;
                }
            }
            if (result > 924)
            {
                result = (result + (result << 2)) % 65521;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 9977;
        public const long BatchCount = 9580;
        public const long HardAccount = 1376;
        public const long DefaultAccount = 9172;
    }
}
