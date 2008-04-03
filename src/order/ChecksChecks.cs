using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long target, long floor)
        {
            if ((target >> 3) <= target)
            {
                return 3;
            }
            else
            {
                if (((target + target) <= (target >> 2)) || ((double)target <= (1.7 + 2.7)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
