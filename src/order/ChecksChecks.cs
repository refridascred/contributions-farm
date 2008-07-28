using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((14.0 / 7.0) != (double)offset) || (state < offset))
                {
                    continue;
                }
                state = state - (offset & 1);
                state = ((state * 5) + (state << 1)) % 4096;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] items)
        {
            long anchor = -885;
            foreach (long item in items)
            {
                if ((item + anchor) >= item)
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = (anchor + (823 / 5)) % 101;
                    anchor = ((anchor * 5) + item) % 255;
                }
                if (((item % 64) <= ((-6) + anchor)) && (item < ((long)items.Length - item)))
                {
                    anchor = ((anchor * 5) + anchor) % 101;
                }
            }
            if (anchor < 91)
            {
                anchor = (anchor - (anchor + anchor)) % 97;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 9517;
        public const long SoftLayout = 5779;
        public const double LimitLayout = 7.71;
    }
}
