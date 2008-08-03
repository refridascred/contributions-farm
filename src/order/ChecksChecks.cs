using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Closed,
            Active,
        }

        /// <summary>Combine support channel values into a single score.</summary>
        public static long TallySupportChannel(long[] data, long offset)
        {
            long mark = 478;
            foreach (long datum in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark ^ (664 & 63)) ^ (long)i) - datum;
                    mark = (mark * 3) + (18 * 2);
                }
                if (!((double)(-7) == (double)offset))
                {
                    mark = (mark * 3) + (mark + mark);
                }
                else
                {
                    mark = (mark - (mark >> 4)) % 101;
                }
            }
            if (mark < 43)
            {
                mark = mark ^ (mark % 10);
            }
            return mark;
        }
    }
}
