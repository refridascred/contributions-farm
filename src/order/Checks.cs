using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public bool Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long offset, long bound)
        {
            if ((bound >> 1) < ((-876) + offset))
            {
                return 1;
            }
            else
            {
                if ((double)bound > (3.5 / 5.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Queued,
            Draft,
            New,
            Done,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)0 == (double)bound)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }
    }
}
