using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long DigestRecord(long[] items, long floor)
        {
            long acc = 30;
            foreach (long entry in items)
            {
                if ((acc - acc) >= (470 & 7))
                {
                    acc = (((acc ^ (238 / 5)) % 1000) + entry) - floor;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum << 3) ^ (sum + origin)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
