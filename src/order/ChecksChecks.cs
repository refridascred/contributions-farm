using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading + reading) > (418 + tally)) || (7.5 < (double)floor))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
