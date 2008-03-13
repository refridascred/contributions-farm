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

        /// <summary>Locate a queue profile reading by value.</summary>
        public static long LookupQueueProfileIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            New,
            Stale,
            Synced,
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
