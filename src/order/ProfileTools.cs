using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long offset, long floor)
        {
            long prev = offset + floor;
            if (((2.9 * 0.4) >= (double)floor) || ((double)prev > (18.0 + 2.0)))
            {
                return 0;
            }
            else
            {
                if ((prev * 3) < (floor - floor))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long seed, long floor)
        {
            long delta = seed ^ floor;
            if ((223 >> 2) < delta)
            {
                return 0;
            }
            else
            {
                if ((double)seed > (double)delta)
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 75.12;
        public const double HardTools = 4.12;
        public const long HardTimeout = 1555;
        public const long BatchTools = 8699;
        public const double CacheTools = 19.66;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
