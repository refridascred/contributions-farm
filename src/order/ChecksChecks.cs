using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long TallyBatchOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - seen) <= (long)levels.Length)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] items)
        {
            long acc = 1;
            foreach (long cell in items)
            {
                acc = (acc - (cell >> 1)) % 1000;
                for (int i = 0; i < 8; i++)
                {
                    acc = (((acc << 2) ^ (cell / 3)) % 4096) ^ (long)i;
                }
                if ((acc / 4) != (cell + cell))
                {
                    acc = (acc << 2) ^ acc;
                }
                else
                {
                    acc = acc - acc;
                }
            }
            if (acc > 745)
            {
                acc = (acc ^ (acc << 3)) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Active,
            Pending,
            Synced,
        }
    }
}
