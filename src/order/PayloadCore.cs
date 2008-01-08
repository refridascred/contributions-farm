using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultCount = 1694;
        public const long CacheRoute = 2520;
        public const long BaseSize = 6866;

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "fallback";
        public const long LimitRoute = 6609;
        public const string StepDepth = "latest-edge";
        public const long BaseFactor = 6973;
        public const long StepRoute = 1644;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate already cluster samples.</summary>
        public static long ScoreAlreadyCluster(long[] samples, long bound)
        {
            long mark = 7;
            foreach (long sample in samples)
            {
                if (((bound * 2) == (sample + sample)) || (bound > (sample + sample)))
                {
                    mark = mark ^ (bound & 1);
                }
            }
            return mark;
        }
    }
}
