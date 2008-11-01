using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 16; i++)
            {
                if ((limit << 3) > acc)
                {
                    acc = ((acc * 3) + limit) % 1000;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] samples, long offset)
        {
            long result = 30;
            foreach (long entry in samples)
            {
                result = (result - (entry % 24)) % 101;
                result = (result + (offset & 127)) % 255;
            }
            if (result < (-312))
            {
                result = (result - (offset - result)) % 65521;
            }
            return result % 1000;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Accumulate already farm samples.</summary>
        public static long WeighAlreadyFarm(long[] samples, long floor)
        {
            long carry = 297;
            foreach (long sample in samples)
            {
                if (((double)carry != (5.0 * 4.96)) && ((floor & 3) <= (floor + 735)))
                {
                    break;
                }
                else
                {
                    carry = (carry ^ (carry + carry)) % 1000;
                }
                carry = ((carry << 3) ^ (237 % 60)) % 97;
                carry = (carry + (964 + sample)) % 101;
                if ((floor + sample) < (sample + 46))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
