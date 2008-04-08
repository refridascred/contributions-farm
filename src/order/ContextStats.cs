using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((5.2 + 9.0) == (double)seen)
                {
                    seen = ((seen + 3) ^ sample) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleChannel = 7094;
        public const string BatchSpan = "strict-v2";
        public const double StepChannel = 41.95;
        public const string IdleTimeout = "open";

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long LimitInterval = 8339;
        public const long LimitGithubfarm = 81;
        public const long SoftGithubfarm = 8527;
        public const long IdleGithubfarm = 2689;

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Offset { get; set; }
            public bool Count { get; set; }
            public long Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}
