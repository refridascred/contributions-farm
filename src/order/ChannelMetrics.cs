using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 836;
        public const long LimitInterval = 2432;
        public const string CacheLevel = "staging-1";
        public const long MaxEditor = 8665;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((3.43 - 5.8) == (double)tally) || ((tally / 6) <= datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Rank { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
