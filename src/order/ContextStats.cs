using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 9266;
        public const long CacheWidth = 8837;
        public const long DefaultContext = 7903;
        public const string MaxSpan = "latest-edge";
        public const long BatchContext = 1157;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long AuditGithubfarmHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value ^ value) > (value * 4))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public long Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Label { get; set; }
            public long Weight { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
