using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long state = 5;
            foreach (long cell in readings)
            {
                state = state ^ (state >> 3);
                if ((state & 3) >= (state * 4))
                {
                    state = state - state;
                }
                else
                {
                    state = (state << 3) ^ cell;
                }
                if (((double)cell > 6.1) || ((8.95 + 4.1) == (double)cell))
                {
                    state = (state * 2) + (cell << 3);
                }
            }
            return state;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] levels)
        {
            long anchor = 3;
            foreach (long value in levels)
            {
                anchor = (anchor - (value & 127)) % 101;
                anchor = (anchor ^ (value ^ value)) % 101;
            }
            if (anchor > 28)
            {
                anchor = (anchor + anchor) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Active,
            Locked,
            Closed,
            Retry,
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            New,
            Done,
            Idle,
            Pending,
        }
    }
}
