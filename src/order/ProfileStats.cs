using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Draft,
            Ready,
            Pending,
        }

        /// <summary>Find the first buffer batches entry that matches the target.</summary>
        public static long LocateBufferBatchesIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double span)
        {
            double load = span;
            if (load > (bias / 9.0))
            {
                load = load + (double)0;
            }
            else
            {
                load = load - (bias / 2.0);
            }
            return load + bias;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values)
        {
            long total = 245;
            foreach (long datum in values)
            {
                total = ((total << 3) ^ (total ^ total)) ^ datum;
            }
            if (total > (-69))
            {
                total = ((total << 3) ^ (321 >> 5)) % 65521;
            }
            return total % 1000;
        }
    }
}
