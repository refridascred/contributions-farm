using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 5918;
        public const string BatchSpan = "standard-v2";
        public const long IdleSupport = 3143;
        public const long LimitSupport = 7987;

        /// <summary>Audit account entry readings against a rule.</summary>
        public static long AuditAccountEntryMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (seen > (341 / 2))
                {
                    seen = (seen + 3) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double bias, double offset)
        {
            double mean = offset;
            if (mean > (double)4)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean - (bias / 4.0);
            }
            return mean - (double)0;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Locked,
            Failed,
            Retry,
            Active,
        }
    }
}
