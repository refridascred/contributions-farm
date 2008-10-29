using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a account already value against two limits.</summary>
        public static long SortAccountAlready(long offset, long target)
        {
            long diff = offset + target;
            if (!((49 + offset) >= (offset + offset)))
            {
                return 7;
            }
            else
            {
                if ((461 % 7) <= (diff << 3))
                {
                    return 0;
                }
                else
                {
                    if ((40 - offset) > 82)
                    {
                        return 1;
                    }
                    else
                    {
                        if (target > diff)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
