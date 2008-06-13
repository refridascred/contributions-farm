using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Stale,
            New,
            Done,
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] items)
        {
            long acc = -251;
            foreach (long value in items)
            {
                if (!((value ^ 66) <= (acc * 3)))
                {
                    acc = (acc << 2) ^ (value ^ 80);
                    acc = ((acc << 2) ^ (value + acc)) % 1000;
                }
                if ((value + value) < value)
                {
                    acc = acc ^ (value % 100);
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
