using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
