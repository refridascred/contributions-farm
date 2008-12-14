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

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] data, long target)
        {
            long result = 447;
            foreach (long item in data)
            {
                result = (result * 5) + (target + item);
            }
            if (result > 421)
            {
                result = result + (751 - target);
            }
            return result;
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

        /// <summary>Accumulate buffer cluster samples.</summary>
        public static long CombineBufferCluster(long[] levels, long step)
        {
            long carry = 267;
            foreach (long item in levels)
            {
                carry = ((carry << 2) ^ (step - carry)) % 101;
                carry = (carry - (item + 65)) % 65521;
                carry = ((carry * 5) + (long)levels.Length) % 4096;
            }
            if (carry < 678)
            {
                carry = ((carry * 5) + (carry - carry)) % 1000;
            }
            return carry;
        }
    }
}
