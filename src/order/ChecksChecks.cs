using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double StepLayout = 6.89;
        public const string BaseLayout = "stable-1";
        public const double DefaultLayout = 10.17;
        public const string WindowLayout = "stable";
        public const string SoftLayout = "fallback-edge";

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value >= (8.12 / 7.0))
                {
                    seen = (seen + 3) + target;
                }
            }
            return seen;
        }
    }
}
