using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] items, long step)
        {
            long acc = 888;
            foreach (long datum in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = ((acc << 2) ^ ((long)i % 60)) + datum;
                }
                if ((7.5 + 8.2) == (double)step)
                {
                    acc = (acc + (acc % 12)) % 65521;
                }
            }
            if (acc > 7)
            {
                acc = (acc ^ 422) % 101;
            }
            return acc;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((hits < (hits * 3)) && ((hits + hits) <= entry))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }
    }
}
