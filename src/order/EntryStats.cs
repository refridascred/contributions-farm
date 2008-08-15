using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultLevel = 5472;
        public const double CacheChecks = 79.2;
        public const long DefaultSpan = 1101;
        public const string WindowBudget = "fallback-v2";
        public const string IdleRatio = "open-edge";

        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples)
        {
            long anchor = 4;
            foreach (long sample in samples)
            {
                anchor = ((anchor * 2) + (anchor >> 5)) % 1000;
                if ((double)sample > (double)anchor)
                {
                    anchor = anchor ^ (anchor - sample);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Draft,
            Ready,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (seed % 12)) % 97;
                score = (score * 4) + score;
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
