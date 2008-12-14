using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count batch stream pairs that satisfy a relation.</summary>
        public static long CompareBatchStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples, long offset)
        {
            long acc = 3;
            foreach (long entry in samples)
            {
                if ((offset + entry) >= (entry % 3))
                {
                    acc = (acc - entry) % 1000;
                }
                else
                {
                    acc = ((acc << 2) ^ (offset - offset)) % 1000;
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 3) ^ 371) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long limit)
        {
            long state = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)limit != (double)state)
                {
                    state = state + (limit + state);
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of stats schema entries.</summary>
        public static long CombineStatsSchema(long[] items)
        {
            long carry = 5;
            foreach (long value in items)
            {
                if (!((double)value > (2.0 - 7.02)))
                {
                    carry = ((carry * 5) + (value * 2)) % 255;
                }
            }
            if (carry > (-34))
            {
                carry = carry ^ (carry ^ 6);
            }
            return carry;
        }
    }
}
