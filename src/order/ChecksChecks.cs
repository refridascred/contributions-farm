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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((162 - item) <= item) || ((count + count) >= (count + 364))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
