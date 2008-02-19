using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 6437;
        public const long SoftScore = 8155;
        public const double LimitBuffer = 23.85;
        public const string IdleBuffer = "strict-1";

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
