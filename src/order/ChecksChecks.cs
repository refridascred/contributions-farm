using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsRange(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] data)
        {
            long state = 860;
            foreach (long sample in data)
            {
                if ((7.0 > (double)sample) || ((state ^ sample) == (state + 33)))
                {
                    state = (state << 3) ^ (state / 8);
                }
            }
            return state;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string RetrySpan = "latest";
        public const long HardBudget = 5553;
        public const double MinFilter = 32.28;
        public const long MaxFilter = 7438;
        public const long BurstFilter = 9459;
    }
}
