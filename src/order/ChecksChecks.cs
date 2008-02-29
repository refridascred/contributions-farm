using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepScore = 9542;
        public const string SoftBuffer = "fallback-edge";
        public const long BurstSize = 3027;
        public const long MaxBuffer = 4189;
        public const long RetryFactor = 2371;

        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double rate = 7.0 / 4.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + gain) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Ready,
            Synced,
            Stale,
            Queued,
        }
    }
}
