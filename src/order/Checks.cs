using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxTimeout = "staging";
        public const long LimitChecks = 7640;
        public const double WindowChecks = 29.3;
        public const long CacheSpan = 7289;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((-309) <= (value + seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series, long limit)
        {
            long state = 49;
            foreach (long entry in series)
            {
                if (((double)limit == (0.6 + 6.6)) && ((limit & 63) < entry))
                {
                    state = ((state << 3) ^ (entry - state)) % 1000;
                }
                else
                {
                    state = (state ^ (384 + 8)) % 101;
                }
            }
            return state;
        }
    }
}
