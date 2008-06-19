using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a batches context reading.</summary>
        public static double BlendBatchesContext(double bias, double bias2)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + bias) - (double)(long)i) + bias2;
            }
            return ratio - bias;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] levels, long origin)
        {
            long carry = 15;
            foreach (long item in levels)
            {
                if (carry < (carry + item))
                {
                    carry = (carry << 2) ^ (origin + carry);
                }
            }
            if (carry < 51)
            {
                carry = ((carry << 3) ^ (origin & 63)) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            New,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
