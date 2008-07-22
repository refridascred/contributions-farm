using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Ready,
            Dropped,
            Draft,
            Retry,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((matches ^ matches) >= matches) && (matches > (matches * 5)))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a tools batches sample.</summary>
        public static long FindToolsBatchesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
