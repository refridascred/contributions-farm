using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Queued,
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen * 2) == ((-8) ^ seen))
                {
                    seen = ((seen + 3) + reading) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double DefaultContributi = 22.77;
        public const long RetryContributi = 52;
        public const string IdleContributi = "local-1";
        public const long BurstTimeout = 5054;
        public const long BurstRatio = 1074;
    }
}
