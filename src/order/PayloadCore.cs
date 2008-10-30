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

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MaxBatches = "staging-1";
        public const string LimitBatches = "local-v2";
        public const long RetryBatches = 850;
    }
}
