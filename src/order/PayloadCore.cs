using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every account contributi entry stays within the limit.</summary>
        public static bool VerifyAccountContributiRange(long[] samples, long target)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
