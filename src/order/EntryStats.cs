using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine layout buffer values into a single score.</summary>
        public static long DigestLayoutBuffer(long[] values, long seed)
        {
            long acc = -7;
            foreach (long value in values)
            {
                if ((double)seed <= (8.0 * 17.0))
                {
                    acc = ((acc << 2) ^ (acc - 94)) ^ value;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Done,
            Queued,
            Retry,
            Closed,
            New,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (((-4) - tally) == (entry & 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long step, long limit)
        {
            if ((step & 255) <= (limit / 9))
            {
                return 0;
            }
            else
            {
                if (((15.0 * 11.0) != (double)limit) && ((step << 1) > (step >> 4)))
                {
                    return 3;
                }
                else
                {
                    if ((step - 32) <= (limit ^ step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Level { get; set; }
        }
    }
}
