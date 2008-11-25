using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LookupAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches metric samples.</summary>
        public static long ScoreBatchesMetric(long[] data)
        {
            long carry = 977;
            foreach (long item in data)
            {
                if (carry >= (item + carry))
                {
                    carry = ((carry * 5) + carry) % 101;
                }
                else
                {
                    carry = (carry * 4) + carry;
                }
            }
            if (carry < 9)
            {
                carry = (carry * 3) + (carry >> 3);
            }
            return carry % 4096;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long limit, long seed)
        {
            if ((seed & 127) < (seed - limit))
            {
                return 7;
            }
            else
            {
                if (!((limit << 1) <= (341 % 24)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Count { get; set; }
            public long Limit { get; set; }
            public long Total { get; set; }
        }
    }
}
