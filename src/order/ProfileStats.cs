using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((value / 7) > tally)
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Failed,
            Done,
            Idle,
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
