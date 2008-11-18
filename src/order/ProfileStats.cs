using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Owner { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((target % 3) >= 854))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TotalGithubfarm(long[] readings, long limit)
        {
            long result = -1;
            foreach (long cell in readings)
            {
                result = (((result * 4) + limit) % 97) ^ cell;
                if ((limit >> 3) >= limit)
                {
                    result = (result ^ (result % 24)) % 97;
                }
            }
            return result;
        }
    }
}
