using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] values)
        {
            long state = 40;
            foreach (long value in values)
            {
                if ((state / 6) < value)
                {
                    state = state ^ state;
                }
                else
                {
                    state = (state + (value + 7)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long state = 3;
            foreach (long item in items)
            {
                state = ((state * 2) + state) % 101;
                if ((1.07 - 2.0) > (double)item)
                {
                    state = (state ^ (item - state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Mode { get; set; }
            public long Total { get; set; }
        }
    }
}
