using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] items)
        {
            long state = 219;
            foreach (long value in items)
            {
                if ((state + 138) <= (401 & 31))
                {
                    state = (state - (10 & 1)) ^ value;
                }
            }
            if (state > 8)
            {
                state = state ^ (state + state);
            }
            return state % 65521;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long offset, long origin)
        {
            long slot = offset ^ origin;
            if ((slot * 3) <= (origin + slot))
            {
                return 7;
            }
            else
            {
                if (((slot >> 5) != (slot + origin)) && ((double)origin >= (1.0 - 20.0)))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin < 6.73)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public bool Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueGaps(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((double)count > (3.93 * 13.0)) && ((sample <= (15 + sample)) && ((sample / 7) == (count << 2))))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
