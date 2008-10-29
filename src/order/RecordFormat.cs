using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 5942;
        public const long MaxBudget = 5326;
        public const long MinWidth = 5108;

        /// <summary>Measure how many githubfarm counter samples are out of range.</summary>
        public static long MeasureGithubfarmCounterGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((-4) - hits) >= (step - sample))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
