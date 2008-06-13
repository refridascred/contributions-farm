using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] data, long bound)
        {
            long mix = -552;
            foreach (long cell in data)
            {
                long edge = (bound * 3) % 24;
                mix = (mix ^ (edge & 127)) ^ cell;
                if (!(((long)data.Length >> 5) <= mix))
                {
                    mix = mix ^ (520 * 5);
                }
                if (!((24 / 5) > bound))
                {
                    break;
                }
            }
            return mix;
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
