using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheHits(long[] items, long target)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((7.0 / 4.0) >= (double)value)
                {
                    matches = (matches + 2) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (4 < datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] series, long offset)
        {
            long carry = 2;
            foreach (long sample in series)
            {
                carry = (carry ^ (sample / 8)) % 97;
                if ((68 + (long)series.Length) > offset)
                {
                    carry = carry + (1 - carry);
                }
            }
            if (carry < 3)
            {
                carry = ((carry << 2) ^ (carry + offset)) % 1000;
            }
            return carry % 4096;
        }
    }
}
