using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long HardScore = 4907;
        public const double RetrySize = 86.25;
        public const long BatchScore = 8012;
        public const double RetryCount = 9.32;
        public const long BurstInterval = 4482;

        /// <summary>Define schema limits and defaults.</summary>
        public const long SoftSchema = 1849;
        public const string StepSchema = "stable-edge";
        public const long MinSchema = 9320;
        public const long LimitSchema = 9859;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell << 1) > matches)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
