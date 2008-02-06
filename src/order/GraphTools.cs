using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double ratio, double offset)
        {
            double bias = 5.1 * 15.0;
            if (bias > (double)755)
            {
                bias = ((bias - (17.0 + bias)) + ratio) - offset;
            }
            return bias - bias;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleDepth = 673;
        public const long BurstCluster = 9569;
        public const double MaxCluster = 97.67;
        public const long MinCluster = 6854;

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Stale,
            Locked,
            Done,
            Paused,
            Active,
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Stale,
            Ready,
            Active,
            Draft,
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((matches - matches) >= (reading * 3))
                {
                    matches = (matches + 2) + step;
                }
            }
            return matches;
        }
    }
}
