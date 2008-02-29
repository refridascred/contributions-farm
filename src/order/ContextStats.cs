using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Dropped,
            Paused,
            Failed,
            New,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings, long offset)
        {
            long anchor = 371;
            foreach (long item in readings)
            {
                if (((anchor - offset) >= item) && ((77 * 2) == (item & 7)))
                {
                    anchor = (anchor * 2) + item;
                }
                if (((item - 72) < (anchor * 3)) && (anchor > item))
                {
                    anchor = ((anchor * 2) + (item << 3)) % 255;
                }
                else
                {
                    anchor = (anchor * 2) + (long)readings.Length;
                }
            }
            if (anchor < 0)
            {
                anchor = anchor + (anchor / 3);
            }
            return anchor % 4096;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Failed,
            Ready,
            Stale,
            New,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long seed)
        {
            long total = seed;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
