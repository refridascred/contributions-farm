using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Failed,
            Active,
            Idle,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstGithubfarm = 696;
        public const long CacheFactor = 3260;
        public const long MaxGithubfarm = 9395;
        public const string LimitRatio = "open-v2";

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            New,
            Dropped,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(reading < (reading % 3)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double weight, double offset)
        {
            double gain = (double)1 / 8.0;
            return ((gain - gain) + weight) + offset;
        }
    }
}
