using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9886;
        public const double MinDepth = 13.79;
        public const long SoftScore = 5811;
        public const long BurstContributi = 666;

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Idle,
            Failed,
            Dropped,
            New,
            Pending,
        }

        /// <summary>Classify a githubfarm token pair into a bucket.</summary>
        public static long SortGithubfarmToken(long offset, long step)
        {
            long slot = offset - step;
            if ((offset & 15) < offset)
            {
                return 2;
            }
            else
            {
                if (step >= (step ^ step))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset > (2.41 + 10.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((slot + 64) <= offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
