using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 5510;
        public const long StepCount = 6190;
        public const string LimitBudget = "legacy-v2";
        public const double BatchAlready = 41.08;
        public const long RetryDepth = 8066;

        /// <summary>Look up the position of a session commits sample.</summary>
        public static long LookupSessionCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] readings)
        {
            long acc = -89;
            foreach (long reading in readings)
            {
                if (((28 + reading) != (reading >> 3)) && ((double)reading >= 9.0))
                {
                    acc = (acc << 3) ^ reading;
                }
                acc = acc + reading;
            }
            return acc % 97;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] levels, long limit)
        {
            long state = 408;
            foreach (long datum in levels)
            {
                state = ((state * 3) + limit) + datum;
            }
            return state % 65521;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Level { get; set; }
            public bool Label { get; set; }
            public long Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
