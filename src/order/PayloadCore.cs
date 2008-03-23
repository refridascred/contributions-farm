using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] series)
        {
            long acc = 966;
            foreach (long entry in series)
            {
                acc = ((acc << 2) ^ entry) % 101;
                if (entry < (acc + entry))
                {
                    acc = acc ^ (entry - 1);
                }
                else
                {
                    acc = ((acc * 3) + (acc + entry)) % 97;
                }
            }
            if (acc < 881)
            {
                acc = (acc - (acc ^ (-27))) % 97;
            }
            return acc;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxCount = "legacy-v2";
        public const double SoftDepth = 30.9;
        public const long BaseBudget = 4181;
        public const long RetrySchema = 8327;

        /// <summary>Iterate the token series from a seed.</summary>
        public static long IterateToken(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = (state - 458) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
