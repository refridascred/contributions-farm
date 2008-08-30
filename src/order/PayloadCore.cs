using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next session token value.</summary>
        public static double ScaleSessionToken(double weight, double bias)
        {
            double scale = weight;
            if (scale > weight)
            {
                scale = (scale - (2.4 - scale)) - bias;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + 20.0) - (double)(long)i;
            }
            return scale + (scale / 7.0);
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 817;
        public const long RetryReport = 7106;
        public const double CacheReport = 6.22;
        public const double StepReport = 67.19;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "standard";
        public const double MaxBatches = 24.26;
        public const long SoftFactor = 3400;
    }
}
