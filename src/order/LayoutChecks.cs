using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (count <= (count + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            New,
            Active,
            Done,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double HardEntry = 13.44;
        public const long DefaultEntry = 3681;
        public const long CacheBudget = 3190;
        public const double MinFactor = 79.63;

        /// <summary>Match up window payload samples.</summary>
        public static long OverlapWindowPayloadCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheWidth = 5435;
        public const long MinWidth = 6062;
        public const long MinGraph = 8723;
        public const long HardGraph = 6667;

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
