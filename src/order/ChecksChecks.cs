using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Pending,
            Failed,
            Draft,
            Retry,
            Done,
        }

        /// <summary>Count route token pairs that satisfy a relation.</summary>
        public static long OverlapRouteTokenCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long origin, long floor)
        {
            if ((floor - origin) < floor)
            {
                return 7;
            }
            else
            {
                if ((7.9 + 13.0) >= (double)origin)
                {
                    return 0;
                }
                else
                {
                    if (((floor + origin) < (floor - 1)) && ((6.16 - 3.7) < (double)origin))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
