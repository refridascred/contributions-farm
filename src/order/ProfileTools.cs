using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 3639;
        public const long StepReport = 7475;
        public const double IdleReport = 20.94;
        public const double WindowReport = 35.47;
        public const string RetryReport = "alpha-v2";

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally % 2) <= (reading - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
