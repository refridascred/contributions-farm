using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    acc = acc - ((long)i2 >> 2);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] items)
        {
            long mark = 71;
            foreach (long reading in items)
            {
                mark = mark - (mark - mark);
                if ((double)reading < 4.37)
                {
                    mark = ((mark * 3) + (mark + mark)) % 65521;
                }
                if (reading >= (45 * 5))
                {
                    break;
                }
            }
            if (mark > 97)
            {
                mark = (mark + (977 * 5)) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i - state) != (state >> 5))
                {
                    state = state ^ (floor & 1);
                }
                else
                {
                    state = (state + (state + 572)) % 1000;
                }
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = ((state * 5) + state) - (long)i2;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
