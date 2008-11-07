using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 4069;
        public const long BatchAlready = 6945;
        public const long MinFactor = 8145;
        public const long SoftBudget = 3140;

        /// <summary>Measure how many payload route samples are out of range.</summary>
        public static long TallyPayloadRouteMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((sample * 4) >= (count * 4))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
