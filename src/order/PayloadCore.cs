using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            New,
            Synced,
            Closed,
            Idle,
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long target)
        {
            long anchor = -2;
            foreach (long cell in values)
            {
                if ((2.8 * 4.85) <= (double)target)
                {
                    anchor = ((anchor + (target << 3)) % 65521) ^ cell;
                }
            }
            if (anchor > 374)
            {
                anchor = ((anchor << 3) ^ anchor) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (floor > item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] series, long target)
        {
            long total = 70;
            foreach (long datum in series)
            {
                total = ((total ^ total) % 1000) - target;
                if ((double)datum == (7.02 + 1.98))
                {
                    total = (total ^ 95) % 97;
                }
            }
            if (total > 56)
            {
                total = (total * 5) + ((long)series.Length + total);
            }
            return total % 65521;
        }
    }
}
