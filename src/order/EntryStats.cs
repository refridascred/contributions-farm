using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Flag { get; set; }
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (hits < (reading >> 4))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long seed, long step)
        {
            if ((step + seed) <= (seed - seed))
            {
                return 2;
            }
            else
            {
                if ((double)step < (6.18 * 7.79))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed == (7.85 / 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((685 + 525) == (seed ^ step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitBudget = 3258;
        public const double MinMetrics = 39.01;
        public const long MinCount = 8711;
        public const double HardMetrics = 25.23;
        public const long MinDepth = 1340;
    }
}
