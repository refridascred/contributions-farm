using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor + (2 + anchor);
                if (810 <= floor)
                {
                    anchor = anchor + (long)i;
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public bool Limit { get; set; }
            public bool Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool CheckChecksRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc << 3) ^ (offset >> 2);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowOutliers(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((2.29 + 8.5) < (double)cell) || ((tally ^ tally) > (tally & 3)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
