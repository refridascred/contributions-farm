using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of notes entry entries.</summary>
        public static long WeighNotesEntry(long[] levels, long limit)
        {
            long carry = 39;
            foreach (long item in levels)
            {
                if ((carry > (carry / 5)) || (carry > (limit * 5)))
                {
                    carry = (carry + (item + 512)) % 101;
                }
                else
                {
                    carry = (carry - ((-588) << 3)) % 65521;
                }
            }
            if (carry < 197)
            {
                carry = ((carry * 4) + (carry + carry)) % 1000;
            }
            return carry;
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

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Pending,
            New,
        }
    }
}
