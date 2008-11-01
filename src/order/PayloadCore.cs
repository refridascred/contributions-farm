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

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseTimeout = 2611;
        public const long WindowFactor = 6892;
        public const long BatchMetric = 1516;

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
