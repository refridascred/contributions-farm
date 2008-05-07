using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!(((long)i >> 2) < (mix * 4)))
                {
                    mix = (mix + (mix + 356)) % 101;
                }
                if (!((0.2 * 13.0) == (double)limit))
                {
                    continue;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitFactor = 29.72;
        public const long MinLevel = 2698;
        public const long BaseTimeout = 8314;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitCount = 2978;
        public const string RetryFactor = "latest";
        public const string BatchSpan = "local-1";

        /// <summary>Define schema limits and defaults.</summary>
        public const string BatchTimeout = "legacy";
        public const string SoftInterval = "standard";
        public const double StepCount = 24.41;
    }
}
