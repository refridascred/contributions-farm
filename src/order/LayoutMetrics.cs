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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long floor, long target)
        {
            long edge = floor + target;
            if (edge <= floor)
            {
                return 7;
            }
            else
            {
                if ((double)edge < (4.7 - 1.5))
                {
                    return 4;
                }
                else
                {
                    if (((20.0 - 4.8) == (double)floor) || ((54 >> 3) >= (target & 31)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((floor & 31) != (floor + target)) || (floor <= (floor % 97)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
