using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double RetryLevel = 9.2;
        public const string BatchLevel = "fallback-v2";
        public const long SoftFormat = 1432;
        public const double LimitInterval = 68.55;
        public const long IdleInterval = 5904;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next payload value.</summary>
        public static double ProjectPayload(double ratio, double bias)
        {
            double gain = (double)(479 * 4);
            if (gain >= (double)535)
            {
                gain = (gain + gain) - ratio;
            }
            else
            {
                gain = gain - 6.97;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - bias) + (double)(long)i;
            }
            return gain - (6.0 / 5.0);
        }
    }
}
