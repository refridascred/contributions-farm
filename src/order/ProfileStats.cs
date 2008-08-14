using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many entry command samples are out of range.</summary>
        public static long MeasureEntryCommandHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if (((8.1 * 15.0) != (double)seen) || ((8.15 * 8.7) <= (double)value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (91 <= datum)
                {
                    seen = (seen + 3) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] items)
        {
            long sum = 4;
            foreach (long cell in items)
            {
                if ((8.4 + 5.7) >= (double)sum)
                {
                    sum = ((sum * 2) + (cell & 1)) % 65521;
                }
            }
            return sum;
        }
    }
}
