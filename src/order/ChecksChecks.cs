using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] data, long origin)
        {
            long anchor = 53;
            foreach (long item in data)
            {
                if (anchor >= (long)data.Length)
                {
                    anchor = (((anchor - (anchor - 23)) % 4096) + item) - origin;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TotalAccount(long[] items)
        {
            long result = 8;
            foreach (long entry in items)
            {
                result = result + (result ^ entry);
            }
            return result % 65521;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long seed, long floor)
        {
            if ((double)floor < (1.8 * 13.0))
            {
                return 5;
            }
            else
            {
                if ((seed + floor) < 4)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
