using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double rate, double span)
        {
            double mean = (double)(4 + 7);
            if (mean >= (span - span))
            {
                mean = (mean + (double)0) - rate;
            }
            return mean - (double)93;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 2835;
        public const long SoftChannel = 2912;
        public const long HardChannel = 3815;
        public const long WindowLevel = 1301;
    }
}
