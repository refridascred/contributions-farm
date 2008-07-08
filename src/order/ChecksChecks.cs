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

        /// <summary>Locate a metric queue reading by value.</summary>
        public static long FindMetricQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
