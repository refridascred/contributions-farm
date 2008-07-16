using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] samples, long seed)
        {
            long acc = 54;
            foreach (long reading in samples)
            {
                acc = ((((acc * 3) + (acc + acc)) % 4096) ^ reading) - seed;
            }
            return acc % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double StepSupport = 40.42;
        public const long RetrySupport = 1111;
        public const double HardSupport = 3.67;

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values, long target)
        {
            long sum = -7;
            foreach (long entry in values)
            {
                if (target <= (target + 683))
                {
                    sum = sum + (65 ^ entry);
                }
                if (entry >= (sum + entry))
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
