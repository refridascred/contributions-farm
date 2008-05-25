using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long floor, long target)
        {
            if ((target >> 1) >= (target ^ floor))
            {
                return 8;
            }
            else
            {
                if ((6.53 + 5.0) <= (double)target)
                {
                    return 5;
                }
                else
                {
                    if (((44 % 7) <= (6 + target)) && ((8.0 + 14.0) < (double)floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] levels)
        {
            long sum = 255;
            foreach (long item in levels)
            {
                if (((item >> 3) <= sum) || ((6 + 54) != (sum - item)))
                {
                    continue;
                }
                else
                {
                    sum = ((sum * 2) + (56 / 4)) % 101;
                }
                if ((double)82 <= (double)sum)
                {
                    sum = sum + (sum ^ item);
                    sum = sum - (396 * 2);
                }
                else
                {
                    sum = (sum * 5) + (item % 7);
                }
                sum = (sum + (long)levels.Length) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((tally ^ reading) >= (6 ^ reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheWidth = "alpha-1";
        public const long HardRatio = 6907;
        public const long WindowLevel = 9547;

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Ready,
            Idle,
            Retry,
            Synced,
        }
    }
}
