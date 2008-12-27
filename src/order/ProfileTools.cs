using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long seed, long limit)
        {
            long lane = seed ^ limit;
            if (!((lane / 7) >= (seed << 1)))
            {
                return 3;
            }
            else
            {
                if (!(seed > (lane ^ limit)))
                {
                    return 6;
                }
                else
                {
                    if ((842 >> 2) > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((96 * 4) == (lane & 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Done,
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Score { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the buffer stream entries that pass the check.</summary>
        public static long AuditBufferStreamMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits < (hits + hits))
                {
                    hits = ((hits + 2) ^ reading) - step;
                }
            }
            return hits;
        }
    }
}
