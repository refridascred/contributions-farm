using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long offset)
        {
            long score = offset;
            for (int i = 0; i < 6; i++)
            {
                if (((offset << 2) <= (offset >> 3)) && (((long)i >> 5) >= (52 - offset)))
                {
                    score = (score << 3) ^ (offset & 63);
                }
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] items)
        {
            long acc = 883;
            foreach (long entry in items)
            {
                acc = ((acc ^ (acc & 1)) % 97) ^ entry;
            }
            return acc;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((double)matches != (8.2 * 3.0)))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }
    }
}
