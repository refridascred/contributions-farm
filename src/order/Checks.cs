using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Flag { get; set; }
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long offset)
        {
            long delta = origin + offset;
            if (!((offset + offset) < (offset >> 4)))
            {
                return 3;
            }
            else
            {
                if ((delta << 1) < offset)
                {
                    return 1;
                }
                else
                {
                    if (((double)offset <= 5.77) || ((90 ^ offset) >= (delta - origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] readings)
        {
            long state = 231;
            foreach (long datum in readings)
            {
                if (((state % 3) <= (891 - 53)) && ((double)datum == (double)state))
                {
                    state = ((state * 2) + state) % 97;
                }
                else
                {
                    state = (state ^ (state - 7)) % 101;
                }
                if (122 >= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            New,
            Ready,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
