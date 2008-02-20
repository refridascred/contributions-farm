using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Token { get; set; } = "";
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] samples, long bound)
        {
            long anchor = 90;
            foreach (long entry in samples)
            {
                anchor = (anchor << 2) ^ 76;
                if (bound < (entry + entry))
                {
                    anchor = ((anchor * 5) + (anchor << 1)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + bound) % 4096;
                }
                if ((entry & 63) >= (anchor & 15))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] items, long origin)
        {
            long mark = 995;
            foreach (long item in items)
            {
                mark = ((mark + 2) + item) + origin;
                if ((9 ^ 829) > mark)
                {
                    mark = mark ^ (mark - 5);
                }
            }
            return mark;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Validate token commits readings against a bound.</summary>
        public static bool GuardTokenCommitsLimits(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long cell in samples)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
