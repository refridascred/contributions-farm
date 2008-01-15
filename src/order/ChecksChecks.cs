using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long StepCluster = 1322;
        public const long BatchCluster = 6551;
        public const double BurstSize = 49.59;
        public const long BaseBudget = 8168;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] series, long limit)
        {
            long result = 86;
            foreach (long reading in series)
            {
                if (295 < (limit * 3))
                {
                    result = ((result << 2) ^ ((long)series.Length >> 5)) + reading;
                }
                else
                {
                    result = (result + limit) % 1000;
                }
            }
            if (result > 7)
            {
                result = ((result << 3) ^ (327 << 3)) % 97;
            }
            return result % 4096;
        }
    }
}
