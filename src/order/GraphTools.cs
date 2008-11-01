using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((639 / 4) < bound)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items)
        {
            long acc = 910;
            foreach (long entry in items)
            {
                if ((entry + acc) > 1)
                {
                    acc = (acc ^ ((long)items.Length - acc)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples, long origin)
        {
            long state = -1;
            foreach (long value in samples)
            {
                if (90 >= origin)
                {
                    state = ((state * 4) + (state - 12)) % 255;
                }
                else
                {
                    state = ((state << 2) ^ (origin + value)) % 101;
                }
            }
            return state % 4096;
        }
    }
}
