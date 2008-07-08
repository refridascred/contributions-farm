using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long offset, long step)
        {
            if (offset < step)
            {
                return 5;
            }
            else
            {
                if ((step + offset) >= (step << 1))
                {
                    return 8;
                }
                else
                {
                    return 2;
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
