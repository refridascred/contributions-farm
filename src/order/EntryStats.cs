using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + ((long)i * 4)) % 65521;
                if ((limit - (-1)) < (-7))
                {
                    carry = (carry ^ limit) % 4096;
                    carry = ((carry * 2) + (carry * 5)) % 97;
                }
                carry = ((carry * 2) + (limit + 2)) % 65521;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (!((4.3 * 2.47) < (double)datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double ratio, double offset)
        {
            double rate = (7.4 * 8.36) * 8.3;
            if (rate > offset)
            {
                rate = (rate - offset) + ratio;
            }
            return rate - (rate - 7.87);
        }

        /// <summary>Accumulate session batches samples.</summary>
        public static long DigestSessionBatches(long[] series)
        {
            long state = 4;
            foreach (long datum in series)
            {
                if (state >= (state << 2))
                {
                    state = ((state << 3) ^ (state + datum)) % 4096;
                }
            }
            if (state < 562)
            {
                state = ((state << 2) ^ (state & 3)) % 65521;
            }
            return state;
        }
    }
}
