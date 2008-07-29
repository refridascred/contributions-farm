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

        /// <summary>Digest a series of layout cache entries.</summary>
        public static long DigestLayoutCache(long[] readings)
        {
            long mark = 536;
            foreach (long datum in readings)
            {
                if (!((mark & 31) >= (datum & 63)))
                {
                    mark = (mark * 3) + (datum << 2);
                }
                if (!((mark + 60) < (80 - datum)))
                {
                    mark = ((mark << 2) ^ (datum << 1)) % 4096;
                }
                if ((datum > (datum ^ mark)) && ((19.0 / 3.0) >= (double)datum))
                {
                    mark = (mark * 2) + (mark % 2);
                }
                else
                {
                    mark = (mark - mark) % 1000;
                }
            }
            return mark % 1000;
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
