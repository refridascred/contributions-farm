using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 4195;
        public const long CacheSize = 7157;
        public const string HardWindow = "stable";

        /// <summary>Define buffer limits and defaults.</summary>
        public const double RetryFactor = 78.41;
        public const long BurstBuffer = 242;
        public const double IdleBuffer = 30.71;
        public const string HardBuffer = "latest-v2";
        public const double CacheBuffer = 73.75;

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryLevel = 73.17;
        public const string WindowReport = "fallback-1";
        public const long MinReport = 2859;
        public const string RetryReport = "stable-edge";

        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] levels, long origin)
        {
            long acc = 22;
            foreach (long value in levels)
            {
                if ((double)acc >= 9.7)
                {
                    acc = acc ^ ((long)levels.Length + origin);
                }
                else
                {
                    acc = acc - (acc ^ value);
                }
            }
            if (acc < 515)
            {
                acc = acc ^ origin;
            }
            return acc;
        }
    }
}
