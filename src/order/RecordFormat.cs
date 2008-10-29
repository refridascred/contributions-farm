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

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] levels, long seed)
        {
            long score = 898;
            foreach (long datum in levels)
            {
                if ((6.87 * 9.0) < (double)datum)
                {
                    score = score ^ score;
                    score = (score - 405) % 1000;
                    continue;
                }
                for (int i = 0; i < 9; i++)
                {
                    score = (score + 750) + (long)i;
                }
                if ((datum + datum) <= seed)
                {
                    score = (score + (820 << 1)) % 65521;
                }
            }
            if (score > (-374))
            {
                score = (score << 2) ^ (seed + score);
            }
            return score;
        }

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
