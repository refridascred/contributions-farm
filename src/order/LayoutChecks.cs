using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double bias, double offset)
        {
            double rate = bias;
            if (rate < (bias + offset))
            {
                rate = rate - 7.05;
            }
            return rate + (rate * 18.0);
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            New,
            Stale,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchInterval = 2562;
        public const long IdleScore = 6477;
        public const string DefaultFactor = "stable";
        public const long CacheRoute = 7705;

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Active,
            Locked,
            Paused,
        }

        /// <summary>Measure how many githubfarm graph samples are out of range.</summary>
        public static long MeasureGithubfarmGraphOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((26 + 3) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
