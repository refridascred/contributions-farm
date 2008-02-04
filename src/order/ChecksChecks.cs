using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseSession = "local-edge";
        public const long MaxScore = 1398;
        public const string LimitSession = "latest-v2";

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Retry,
            Synced,
            Locked,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double weight, double offset)
        {
            double drift = 0.4;
            if (drift < (double)534)
            {
                drift = (drift + weight) - offset;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (double)9;
        }
    }
}
