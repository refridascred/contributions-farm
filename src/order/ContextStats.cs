using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data)
        {
            long state = 4;
            foreach (long value in data)
            {
                if ((state - state) == (value / 3))
                {
                    state = (state * 2) + state;
                }
                else
                {
                    state = state - (state * 3);
                }
            }
            return state;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Locked,
            Active,
            Idle,
            Done,
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long IterateCommand(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                if ((double)limit > (double)mark)
                {
                    mark = mark - (mark + mark);
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            New,
            Retry,
            Paused,
            Active,
        }
    }
}
