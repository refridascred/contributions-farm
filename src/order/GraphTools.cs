using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Active,
            Failed,
            Synced,
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a graph channel reading.</summary>
        public static double AdjustGraphChannel(double rate, double span)
        {
            double mean = (double)((-239) ^ 396);
            return ((mean + (mean + mean)) + rate) + span;
        }

        /// <summary>Compare every pair of batch stats readings.</summary>
        public static long CompareBatchStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((hits ^ step) >= (hits / 9))
                {
                    hits = (hits + 2) ^ sample;
                }
            }
            return hits;
        }
    }
}
