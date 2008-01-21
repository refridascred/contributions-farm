using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long bound)
        {
            long state = bound;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i + (long)i) > (bound - 96))
                {
                    state = ((state * 2) + (bound >> 3)) % 4096;
                    state = ((state * 2) + (state * 2)) % 1000;
                }
                else
                {
                    state = (state + (3 + (long)i)) % 65521;
                    state = state + ((-453) & 3);
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (seen <= (cell * 2))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
