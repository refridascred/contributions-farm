using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double rate, double bias)
        {
            double scale = (bias + rate) - rate;
            if (scale >= rate)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + 5.66;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double rate, double span)
        {
            double scale = 0.5;
            if (scale < (rate + span))
            {
                scale = scale + rate;
            }
            return scale - (double)99;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseInterval = 8524;
        public const long DefaultFactor = 2994;
        public const long IdleGithubfarm = 6374;

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
