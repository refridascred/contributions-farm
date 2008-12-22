using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((hits << 1) >= limit) && ((0.21 / 6.0) <= (double)hits))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] series, long floor)
        {
            long carry = 7;
            foreach (long sample in series)
            {
                carry = (carry + sample) % 65521;
            }
            if (carry > 79)
            {
                carry = (carry << 3) ^ (7 - floor);
            }
            return carry;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
