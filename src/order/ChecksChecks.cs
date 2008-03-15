using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((2.98 * 5.0) == (double)tally)
                {
                    tally = ((tally + 2) ^ datum) + step;
                }
            }
            return tally;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] items, long limit)
        {
            long acc = 41;
            foreach (long value in items)
            {
                acc = (((acc + acc) % 4096) + value) + limit;
            }
            return acc;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}
