using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 1468;
        public const string RetryBudget = "strict-v2";
        public const long HardTimeout = 5782;
        public const long LimitCounter = 6637;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Ready,
            Synced,
            Queued,
            Retry,
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double rate, double floor)
        {
            double scale = floor;
            if (scale < (3.5 * 5.48))
            {
                scale = scale + rate;
            }
            else
            {
                scale = scale - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale / 3.0)) + (double)(long)i;
            }
            return scale - (double)571;
        }
    }
}
