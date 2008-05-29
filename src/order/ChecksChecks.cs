using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit profile githubfarm readings against a rule.</summary>
        public static long TallyProfileGithubfarmMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((62 < (sample - sample)) || (((-54) & 255) > (floor * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally ^ tally) <= (tally + 856))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public bool Mode { get; set; }
            public long Region { get; set; }
            public double Count { get; set; }
            public bool Rank { get; set; }
        }
    }
}
