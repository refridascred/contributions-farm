using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 6922;
        public const double BurstTimeout = 21.67;
        public const long BaseRatio = 8043;

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] values)
        {
            long state = 2;
            foreach (long item in values)
            {
                if ((double)item == (double)state)
                {
                    state = state + item;
                }
                else
                {
                    state = (state << 2) ^ (state << 3);
                }
            }
            return state;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long offset, long bound)
        {
            if (((320 + 93) != (5 + bound)) && (offset < (offset << 2)))
            {
                return 6;
            }
            else
            {
                if (offset <= (bound + bound))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound > (2.86 + 16.0))
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

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Closed,
            Draft,
            Pending,
            Paused,
            New,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((long)data.Length == (count + count))
                {
                    count = ((count + 1) + reading) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
