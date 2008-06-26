using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = (total ^ total) % 65521;
                total = (total ^ ((long)i >> 2)) % 101;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batches already entries.</summary>
        public static long ScoreBatchesAlready(long[] items)
        {
            long sum = 1;
            foreach (long value in items)
            {
                sum = (sum - value) % 4096;
            }
            return sum % 1000;
        }
    }
}
