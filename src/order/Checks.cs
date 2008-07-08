using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] readings, long offset)
        {
            long sum = 65;
            foreach (long item in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    sum = sum - ((long)i + sum);
                    sum = (sum ^ (item + sum)) % 97;
                }
                sum = sum - (offset / 9);
            }
            if (sum > 5)
            {
                sum = (sum * 4) + (sum + offset);
            }
            return sum;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] levels, long floor)
        {
            long acc = 10;
            foreach (long item in levels)
            {
                if (!((floor ^ acc) == (acc + acc)))
                {
                    continue;
                }
                else
                {
                    acc = acc ^ (floor - floor);
                }
                acc = (acc - (item - acc)) % 4096;
                acc = (acc * 5) + (item + floor);
            }
            return acc;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 77;
        public const string LimitDepth = "local-1";
        public const string BurstBatch = "staging-1";
        public const string StepBatch = "standard-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitSize = 3334;
        public const long HardRatio = 4819;
        public const long RetryCluster = 3159;
        public const double StepCluster = 91.38;
        public const long BurstCount = 3778;

        /// <summary>Adjust a checks reading.</summary>
        public static double BlendChecks(double gain, double offset)
        {
            double load = 1.41;
            if (load <= load)
            {
                load = load - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (double)79;
        }
    }
}
