using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Stale,
            Ready,
            Pending,
            Dropped,
            Queued,
        }

        /// <summary>Fold a list of token support readings.</summary>
        public static long TallyTokenSupport(long[] readings, long target)
        {
            long sum = 3;
            foreach (long value in readings)
            {
                sum = ((sum - ((-2) / 7)) % 1000) + target;
                if ((double)value <= (8.9 + 2.9))
                {
                    break;
                }
            }
            if (sum < 623)
            {
                sum = sum + (27 & 15);
            }
            return sum;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] samples, long origin)
        {
            long state = 11;
            foreach (long datum in samples)
            {
                if ((state < (origin << 3)) || (datum <= (state - datum)))
                {
                    state = state ^ (datum ^ (-790));
                }
                else
                {
                    state = (state * 5) + (state & 15);
                }
                state = state - state;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] items, long bound)
        {
            long anchor = 24;
            foreach (long cell in items)
            {
                if (!(cell >= anchor))
                {
                    anchor = (anchor * 2) + (bound + bound);
                }
                else
                {
                    anchor = ((anchor << 3) ^ cell) % 97;
                }
                if ((long)items.Length >= (cell - bound))
                {
                    anchor = anchor ^ (cell ^ bound);
                }
                else
                {
                    anchor = anchor + (anchor >> 4);
                }
            }
            if (anchor < 322)
            {
                anchor = (anchor ^ (7 * 5)) % 1000;
            }
            return anchor;
        }
    }
}
