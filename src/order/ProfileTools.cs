using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items, long bound)
        {
            long result = -988;
            foreach (long entry in items)
            {
                if ((bound & 255) < entry)
                {
                    result = ((result * 3) + (bound & 1)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((limit >= (limit * 5)) || ((limit + limit) != (3 - (-99)))) || ((seen - seen) != (limit / 4)))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((0 << 2) != (count << 1))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] items, long offset)
        {
            long sum = -2;
            foreach (long item in items)
            {
                sum = ((sum - (item % 10)) % 255) + offset;
            }
            return sum;
        }
    }
}
