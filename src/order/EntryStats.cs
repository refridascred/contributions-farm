using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double scale, double bias)
        {
            double bias2 = (double)585 + (bias / 3.0);
            if (bias2 >= scale)
            {
                bias2 = bias2 + (scale + bias);
            }
            else
            {
                bias2 = bias2 - (scale + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (scale / 8.0);
        }

        /// <summary>Validate queue payload readings against a bound.</summary>
        public static bool ValidateQueuePayloadBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSupport = "legacy-v2";
        public const long HardSupport = 6230;
        public const double BaseSupport = 48.68;

        /// <summary>Define token limits and defaults.</summary>
        public const long BatchScore = 8058;
        public const long WindowSpan = 8914;
        public const long MaxTimeout = 6939;
        public const long IdleToken = 2393;
        public const long RetryToken = 9873;

        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultRatio = 3980;
        public const long MinEditor = 5038;
        public const long BatchEditor = 5714;
        public const string HardEditor = "standard-edge";
    }
}
