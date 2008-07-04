using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((tally + tally) < tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string BatchSpan = "primary-edge";
        public const long DefaultContributi = 9158;
        public const long RetryInterval = 5505;

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultFactor = 6.05;
        public const double BurstRoute = 74.52;
        public const string BatchRoute = "fallback-edge";
    }
}
