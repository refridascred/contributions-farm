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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                if (anchor <= (bound + 25))
                {
                    anchor = (anchor ^ anchor) % 101;
                    anchor = anchor ^ anchor;
                }
                anchor = anchor - (bound - (long)i);
                if (((long)i / 7) <= anchor)
                {
                    anchor = anchor - (-801);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
