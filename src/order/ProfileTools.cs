using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MinWindow = 50.85;
        public const long RetryWindow = 5138;
        public const long BaseLevel = 1288;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((entry - origin) > (entry << 1)) && ((seen * 3) != (entry ^ seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
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
