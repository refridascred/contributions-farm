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

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] levels, long offset)
        {
            long score = 5;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    score = (((score ^ (5 + offset)) % 255) + (long)i) + item;
                }
                if (!((1 + offset) > (offset >> 3)))
                {
                    score = score ^ (1 ^ 87);
                }
            }
            if (score > 95)
            {
                score = (score * 4) + ((-91) + score);
            }
            return score % 4096;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
