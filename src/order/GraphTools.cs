using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double scale, double span)
        {
            double mean = scale;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean + scale) + (double)(long)i) + span;
            }
            return mean + (mean - 17.0);
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesMatches(long[] values, long step)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((9.4 + 9.53) != (double)step)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long CompareAccountCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
