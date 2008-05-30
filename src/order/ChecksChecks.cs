using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstTimeout = 88.95;
        public const double LimitSchema = 53.71;
        public const double CacheScore = 87.06;
        public const long HardSchema = 9208;
        public const string CacheSchema = "alpha-edge";

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleFactor = 7135;
        public const long BaseRatio = 8750;
        public const long BurstSize = 4931;
        public const long StepPayload = 9521;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits - step) != (step + hits))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
