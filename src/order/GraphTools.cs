using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Derive the next layout counter value from a seed.</summary>
        public static long SeriesLayoutCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 17; i++)
            {
                if ((acc - acc) != (long)i)
                {
                    acc = (acc << 2) ^ (target - acc);
                }
                acc = (acc << 2) ^ (acc + target);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitBudget = 3592;
        public const long StepSession = 9505;
        public const long HardRatio = 8148;

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Draft,
            Locked,
            Stale,
            Closed,
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long offset, long bound)
        {
            long bound2 = offset + bound;
            if (9 > (bound + bound2))
            {
                return 7;
            }
            else
            {
                if (!(3.77 < (6.7 / 9.0)))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
