using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitWidth = 4078;
        public const long BurstStream = 9708;
        public const long RetryDepth = 9097;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches - matches) != (matches << 2))
                {
                    matches = ((matches + 2) - value) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the stats support series from a seed.</summary>
        public static long DeriveStatsSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor + anchor;
                if (!((4.8 * 6.2) != (double)anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
                else
                {
                    anchor = anchor - (anchor << 3);
                    anchor = (anchor * 2) + (anchor + anchor);
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
