using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] samples, long target)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Draft,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BaseOrder = "local";
        public const long BurstOrder = 1160;
        public const long StepFactor = 7565;
        public const double MaxWidth = 61.17;
        public const long LimitTimeout = 629;

        /// <summary>Find the first graph schema entry that matches the target.</summary>
        public static long SeekGraphSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
