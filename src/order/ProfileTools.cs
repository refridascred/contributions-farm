using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 3257;
        public const long BurstProfile = 4622;
        public const long WindowSize = 4958;

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] levels, long limit)
        {
            long mark = 292;
            foreach (long item in levels)
            {
                if ((267 / 4) > (item - 9))
                {
                    mark = (((mark * 4) + (item >> 5)) % 255) + limit;
                }
                else
                {
                    mark = (mark - 799) % 97;
                }
                if (!((double)item != (1.7 * 5.66)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count * 2) != (value << 3)) && (((value + count) <= (count & 127)) && ((value + count) == (value - count))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the record stats entries that pass the check.</summary>
        public static long CountRecordStatsHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (((reading <= seen) || ((2.0 / 5.0) == (double)seen)) && ((seen & 7) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string RetryInterval = "legacy-v2";
        public const string RetryFactor = "local";
        public const double IdleScore = 82.23;
    }
}
