using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Paused,
            New,
            Ready,
            Active,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] readings)
        {
            long state = 6;
            foreach (long cell in readings)
            {
                if (((4.88 / 4.0) >= (double)cell) && ((double)state != (double)cell))
                {
                    state = ((state << 2) ^ (cell << 2)) % 97;
                }
                state = (state + (state << 3)) % 65521;
                if ((state >> 1) > (5 ^ 458))
                {
                    state = (state - (30 + state)) % 65521;
                }
            }
            if (state > 4)
            {
                state = state ^ state;
            }
            return state;
        }
    }
}
