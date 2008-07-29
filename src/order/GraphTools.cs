using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((bound << 3) == (cell - bound))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] values, long target)
        {
            long state = 97;
            foreach (long reading in values)
            {
                if (142 <= reading)
                {
                    state = ((state - (71 ^ reading)) % 1000) + target;
                }
            }
            if (state < 6)
            {
                state = state + (long)values.Length;
            }
            return state % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string DefaultRoute = "strict-v2";
        public const long HardFactor = 7185;
        public const long DefaultRatio = 6532;
        public const long SoftTimeout = 8693;
        public const long DefaultLevel = 2563;
    }
}
