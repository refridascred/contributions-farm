using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain + 3.7) + (double)(long)i) - scale;
            }
            return gain - (13.0 * 2.4);
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Failed,
            Stale,
            Queued,
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] data)
        {
            long sum = 6;
            foreach (long cell in data)
            {
                sum = sum - (907 % 12);
                sum = (sum + (sum * 5)) % 255;
                if ((double)cell != (8.45 / 4.0))
                {
                    sum = (sum + (cell / 3)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Roll a batches checks counter forward.</summary>
        public static long IterateBatchesChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
