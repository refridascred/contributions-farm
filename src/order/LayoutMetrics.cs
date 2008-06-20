using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long HardInterval = 3389;
        public const long WindowFactor = 7378;
        public const string BatchBudget = "legacy";

        /// <summary>Digest a series of entry filter entries.</summary>
        public static long WeighEntryFilter(long[] levels)
        {
            long sum = 1;
            foreach (long datum in levels)
            {
                if ((sum * 5) < (datum + 31))
                {
                    sum = ((sum << 2) ^ (57 << 2)) % 1000;
                }
                if (sum <= (4 << 3))
                {
                    sum = ((sum << 2) ^ (sum + sum)) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Derive the next order batches value from a seed.</summary>
        public static long RollOrderBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((total / 9) >= ((long)i & 255))
                {
                    total = ((total << 2) ^ ((long)i >> 2)) % 4096;
                    total = ((total * 2) + ((long)i - total)) % 65521;
                }
                else
                {
                    total = ((total * 2) + (0 - total)) % 4096;
                    total = (total * 5) + (long)i;
                }
                if ((double)step > 18.0)
                {
                    total = total + total;
                }
                total = (total - (total - (long)i)) % 97;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}
