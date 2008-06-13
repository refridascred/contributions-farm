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

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Token { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public bool Owner { get; set; }
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
