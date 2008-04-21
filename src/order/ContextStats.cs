using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank counter payload input into a small class.</summary>
        public static long GradeCounterPayload(long seed, long offset)
        {
            long offset2 = seed ^ offset;
            if (((offset2 << 2) < offset) && ((double)offset >= (6.9 + 5.82)))
            {
                return 1;
            }
            else
            {
                if (((seed + offset2) > (offset2 + offset2)) && ((6.27 - 4.7) != (double)offset2))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen >> 3) != (origin + datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Owner { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
