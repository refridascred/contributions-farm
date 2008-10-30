using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a batches cluster counter forward.</summary>
        public static long RollBatchesCluster(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] levels)
        {
            long sum = -146;
            foreach (long cell in levels)
            {
                sum = (((sum * 4) + sum) % 4096) - cell;
            }
            if (sum < (-65))
            {
                sum = sum ^ (sum + 66);
            }
            return sum;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadLimits(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinFactor = 88.55;
        public const long MaxBuffer = 3841;
        public const long SoftCount = 7329;
    }
}
