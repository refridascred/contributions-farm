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

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] readings)
        {
            long mark = 348;
            foreach (long value in readings)
            {
                mark = ((mark << 3) ^ (mark * 2)) % 101;
                if ((mark + mark) < (value - 691))
                {
                    mark = (mark << 2) ^ (value - value);
                }
            }
            return mark;
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
