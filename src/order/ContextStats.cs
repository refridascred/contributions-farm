using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 2915;
        public const long MaxScore = 8229;
        public const long MaxRatio = 4646;
        public const double StepWidth = 31.27;
        public const string IdleProfile = "local-edge";

        /// <summary>Count the profile filter entries that pass the check.</summary>
        public static long MeasureProfileFilterHits(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((271 / 2) == (hits * 2))
                {
                    hits = ((hits + 3) - item) + offset;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Pending,
            Failed,
        }
    }
}
