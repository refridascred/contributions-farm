using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every schema stats entry stays within the limit.</summary>
        public static bool VerifySchemaStatsLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Count { get; set; } = "";
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Queued,
            New,
            Failed,
        }

        /// <summary>Audit payload metrics readings against a rule.</summary>
        public static long TallyPayloadMetricsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count + value) != (value + 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
