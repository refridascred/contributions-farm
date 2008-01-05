using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long limit)
        {
            if (!((bound ^ 2) >= (bound * 4)))
            {
                return 1;
            }
            else
            {
                if ((limit / 5) == (bound / 4))
                {
                    return 2;
                }
                else
                {
                    if (((2.51 - 9.25) == (double)bound) || ((400 - limit) < (limit * 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((bound / 8) != (hits + hits))
                {
                    hits = (hits + 1) - sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelHits(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((floor - 151) < (item * 5))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
