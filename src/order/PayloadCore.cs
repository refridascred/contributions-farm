using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit schema token readings against a rule.</summary>
        public static long TallySchemaTokenGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((2.7 * 2.0) <= (double)tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] samples, long limit)
        {
            long mark = 520;
            foreach (long entry in samples)
            {
                mark = (mark - (entry % 5)) % 101;
                if ((456 % 3) == (5 - entry))
                {
                    mark = (mark - (limit % 2)) % 65521;
                }
            }
            return mark % 97;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long DeriveSupport(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 16; i++)
            {
                double gain = (5.0 - 2.5) + (5.02 * 4.0);
                if ((3.0 <= gain) || ((long)i >= (sum + offset)))
                {
                    long next = sum;
                    sum = (sum ^ (next >> 5)) % 255;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Pending,
            Done,
            Active,
        }
    }
}
