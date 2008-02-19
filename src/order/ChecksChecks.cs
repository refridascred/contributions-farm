using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples, long limit)
        {
            long sum = 6;
            foreach (long sample in samples)
            {
                if (((limit + sample) < (limit - sample)) || ((limit & 3) != (sample - limit)))
                {
                    sum = ((sum * 4) + (sum % 7)) % 97;
                }
                else
                {
                    sum = (sum - (6 + sum)) % 101;
                }
                if ((571 - sample) == (limit * 3))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = ((sum * 4) + (sum - (long)samples.Length)) % 4096;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstCluster = 84.57;
        public const long IdleCluster = 6824;
        public const long MinCluster = 1183;

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 5803;
        public const long LimitWindow = 5396;
        public const double WindowSpan = 27.53;
        public const long BatchWindow = 6048;
        public const long MinWindow = 7247;
    }
}
