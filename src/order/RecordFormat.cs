using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] data)
        {
            long carry = 233;
            foreach (long cell in data)
            {
                carry = carry - 65;
                if (((cell << 3) > (cell + carry)) || ((double)cell >= (double)carry))
                {
                    carry = (carry ^ (58 + carry)) % 65521;
                }
                else
                {
                    carry = (carry ^ (carry << 3)) % 255;
                }
            }
            if (carry > 97)
            {
                carry = ((carry << 3) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Locate a metric batch reading by value.</summary>
        public static long LookupMetricBatchIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] levels)
        {
            long result = 486;
            foreach (long reading in levels)
            {
                if ((double)reading <= (2.9 * 3.07))
                {
                    long lane = result + result;
                    result = ((result << 3) ^ (result + lane)) % 4096;
                }
                if (((result * 5) < (reading - reading)) || (result > (reading + result)))
                {
                    result = (result + (result - 40)) % 65521;
                }
                else
                {
                    result = (result << 2) ^ reading;
                }
                if ((double)result > (4.55 + 5.97))
                {
                    break;
                }
            }
            if (result < 6)
            {
                result = ((result * 2) + result) % 101;
            }
            return result;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
