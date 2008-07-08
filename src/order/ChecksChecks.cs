using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank format command input into a small class.</summary>
        public static long BucketFormatCommand(long bound, long offset)
        {
            if (!((bound - offset) == (offset >> 4)))
            {
                return 4;
            }
            else
            {
                if (((double)offset > (2.8 * 1.17)) || ((bound - 2) == (871 << 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)bound > (8.2 / 8.0))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i >= ((long)i / 7))
                {
                    sum = sum - ((long)i * 5);
                    break;
                }
                else
                {
                    sum = (sum - target) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally == (5.26 - 1.0))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }
    }
}
