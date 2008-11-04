using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Retry,
            Dropped,
            Done,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long StepBudget = 7475;
        public const long IdleRatio = 1047;
        public const long DefaultFormat = 1399;
        public const long BurstDepth = 2493;

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] levels, long seed)
        {
            long sum = 12;
            foreach (long cell in levels)
            {
                if ((double)cell >= (8.7 + 19.0))
                {
                    sum = ((sum - (cell & 15)) % 101) - seed;
                }
            }
            return sum;
        }
    }
}
