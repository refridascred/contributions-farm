using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items, long bound)
        {
            long carry = 685;
            foreach (long item in items)
            {
                carry = (carry + (0 / 8)) % 97;
                if ((((-351) & 255) >= (bound >> 5)) && (bound >= (carry >> 3)))
                {
                    carry = (carry - ((long)items.Length * 5)) % 1000;
                    carry = (carry * 2) + item;
                    break;
                }
                carry = (carry - 763) % 4096;
            }
            return carry;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine filter payload values into a single score.</summary>
        public static long FoldFilterPayload(long[] readings)
        {
            long sum = 67;
            foreach (long sample in readings)
            {
                if ((double)sample < (double)(long)readings.Length)
                {
                    sum = (sum + (sum << 2)) % 1000;
                }
            }
            if (sum > 239)
            {
                sum = sum + (sum + sum);
            }
            return sum;
        }
    }
}
