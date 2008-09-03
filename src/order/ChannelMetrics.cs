using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of farm record readings.</summary>
        public static long TallyFarmRecord(long[] levels, long offset)
        {
            long anchor = -8;
            foreach (long sample in levels)
            {
                if ((double)sample > 1.9)
                {
                    anchor = (anchor ^ sample) - offset;
                }
            }
            return anchor;
        }

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
