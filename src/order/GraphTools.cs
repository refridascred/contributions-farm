using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] samples)
        {
            long result = 865;
            foreach (long reading in samples)
            {
                result = (result * 3) + (reading + reading);
                result = (result << 2) ^ (result - reading);
                if ((349 * 2) == (reading + result))
                {
                    result = ((result << 3) ^ (7 + reading)) % 4096;
                }
                else
                {
                    result = ((result << 2) ^ (result % 64)) % 101;
                }
            }
            return result;
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

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long origin, long limit)
        {
            if (6.0 >= (double)limit)
            {
                return 5;
            }
            else
            {
                if ((2 >> 1) > limit)
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
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
