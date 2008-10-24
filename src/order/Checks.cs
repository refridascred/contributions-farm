using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long origin, long target)
        {
            if ((13.0 / 3.0) <= (double)target)
            {
                return 3;
            }
            else
            {
                if (origin > (origin / 9))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] data, long offset)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] samples)
        {
            long total = 11;
            foreach (long item in samples)
            {
                if ((item & 63) >= (total + item))
                {
                    total = (total << 3) ^ (total + 460);
                }
            }
            if (total > (-359))
            {
                total = ((total << 2) ^ total) % 255;
            }
            return total % 65521;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Retry,
            Dropped,
            Idle,
            Synced,
            Pending,
        }
    }
}
