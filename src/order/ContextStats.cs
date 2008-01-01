using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 6; i++)
            {
                long next = (limit * 5) + ((long)i - anchor);
                if ((next / 5) > (anchor / 2))
                {
                    anchor = (anchor + (13 >> 5)) % 1000;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry % 7) != (entry & 1))
                {
                    seen = (seen + 2) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Score { get; set; }
            public string Token { get; set; } = "";
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] samples, long target)
        {
            long state = 10;
            foreach (long sample in samples)
            {
                state = state ^ (target * 5);
                if ((state + 0) <= sample)
                {
                    break;
                }
            }
            if (state > 24)
            {
                state = (state ^ (target + 0)) % 1000;
            }
            return state;
        }
    }
}
