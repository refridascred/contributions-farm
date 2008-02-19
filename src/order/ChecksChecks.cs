using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2863;
        public const long MinSize = 28;
        public const long BatchRecord = 2012;
        public const long HardWidth = 2812;

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 6795;
        public const long DefaultSize = 1026;
        public const string MaxScore = "local-1";
        public const long StepSize = 9926;

        /// <summary>Audit contributi stream readings against a rule.</summary>
        public static long CountContributiStreamGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits + 835) > entry)
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
