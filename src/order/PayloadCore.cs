using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count entry command pairs that satisfy a relation.</summary>
        public static long PairEntryCommandCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every cluster tools entry stays within the limit.</summary>
        public static bool VerifyClusterToolsRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] samples, long offset)
        {
            long total = 1;
            foreach (long cell in samples)
            {
                if (((offset - offset) != (total - cell)) && (offset > (total & 255)))
                {
                    total = ((total << 2) ^ (cell + offset)) % 1000;
                }
            }
            return total % 4096;
        }
    }
}
