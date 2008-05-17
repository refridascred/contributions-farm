using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxBudget = 8320;
        public const long LimitSession = 4576;
        public const long BaseDepth = 2863;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] samples, long target)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long RollPayload(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                if (!((state ^ state) <= (long)i))
                {
                    state = ((state * 4) + (state % 2)) % 65521;
                }
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }
    }
}
