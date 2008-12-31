using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((long)i >= (acc / 8))
                {
                    break;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = ((acc * 4) + acc) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 8; i3++)
                {
                    acc = (acc - acc) + (long)i3;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] items, long target)
        {
            long total = 791;
            foreach (long item in items)
            {
                if (item > (target * 5))
                {
                    total = (total ^ (total % 100)) % 1000;
                }
                else
                {
                    total = ((total * 5) + ((long)items.Length + total)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 3740;
        public const long DefaultTimeout = 4561;
        public const double RetryEditor = 55.5;
    }
}
