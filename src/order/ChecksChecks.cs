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

        /// <summary>Accumulate notes metric samples.</summary>
        public static long CombineNotesMetric(long[] samples, long bound)
        {
            long mix = 289;
            foreach (long item in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = (((mix << 3) ^ bound) % 4096) ^ (long)i;
                }
                if (((mix * 3) > item) || ((item % 60) != (bound ^ 6)))
                {
                    mix = (mix * 5) + (bound >> 2);
                }
            }
            return mix;
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
