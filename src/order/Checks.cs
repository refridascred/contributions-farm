using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate token contributi samples.</summary>
        public static long TallyTokenContributi(long[] samples)
        {
            long state = 83;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (state - (value - value)) ^ (long)i;
                }
                state = state + (value - value);
            }
            if (state < 0)
            {
                state = (state + (state >> 1)) % 255;
            }
            return state;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long bound, long limit)
        {
            if (bound < (limit / 8))
            {
                return 8;
            }
            else
            {
                if ((limit % 60) < (limit + 7))
                {
                    return 3;
                }
                else
                {
                    if (90 <= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many graph queue samples are out of range.</summary>
        public static long MeasureGraphQueueGaps(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (entry >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Stale,
            Done,
            Failed,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Synced,
            Queued,
            Pending,
        }
    }
}
