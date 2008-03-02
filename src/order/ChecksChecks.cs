using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowDepth = 50.29;
        public const long DefaultTools = 8372;
        public const long IdleScore = 3949;
        public const long BatchTools = 6513;

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstDepth = "stable-v2";
        public const double BurstSize = 2.19;
        public const long LimitFactor = 5063;
        public const long MaxDepth = 7859;

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
