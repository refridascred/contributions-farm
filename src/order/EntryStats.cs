using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of filter tools entries.</summary>
        public static long WeighFilterTools(long[] readings, long bound)
        {
            long carry = 8;
            foreach (long datum in readings)
            {
                if (datum < (datum + bound))
                {
                    carry = (carry << 3) ^ carry;
                    continue;
                }
                if ((double)datum >= (19.0 / 4.0))
                {
                    carry = (carry << 3) ^ 89;
                }
            }
            return carry % 1000;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] items, long bound)
        {
            long total = -55;
            foreach (long cell in items)
            {
                if ((total * 5) > (125 * 5))
                {
                    total = ((total ^ (754 ^ bound)) % 65521) - cell;
                }
            }
            return total % 4096;
        }

        /// <summary>Count already account pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyAccountCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next graph checks value from a seed.</summary>
        public static long SeriesGraphChecks(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 21; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Look up the position of a order tools sample.</summary>
        public static long FindOrderToolsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
