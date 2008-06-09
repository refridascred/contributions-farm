using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first batch channel entry that matches the target.</summary>
        public static long LocateBatchChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already profile readings against a rule.</summary>
        public static long AuditAlreadyProfileHits(long[] series, long step)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell >> 3) < (step << 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 2282;
        public const string SoftSpan = "primary-1";
        public const double DefaultRoute = 49.95;
        public const double RetryDepth = 47.04;
        public const long IdleRoute = 4566;
    }
}
