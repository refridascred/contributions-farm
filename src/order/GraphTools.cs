using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Locate a stream support reading by value.</summary>
        public static long FindStreamSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)offset == (8.0 / 4.0))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm checks entries.</summary>
        public static long TotalFarmChecks(long[] series, long offset)
        {
            long mix = 9;
            foreach (long reading in series)
            {
                mix = (mix + offset) - reading;
                mix = (mix + (mix / 2)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Active,
            Retry,
            Dropped,
            Paused,
            Idle,
        }
    }
}
