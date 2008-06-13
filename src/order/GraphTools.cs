using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Scale a layout figure with a bias.</summary>
        public static double SmoothLayout(double scale, double bias)
        {
            double ratio = scale / 6.0;
            if (ratio < (double)4)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio + (scale + scale);
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((seen * 4) == (bound + reading))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 4780;
        public const double BurstGithubfarm = 27.61;
        public const long IdleGithubfarm = 6014;
        public const long BaseWidth = 4568;

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Queued,
            Paused,
            Closed,
        }
    }
}
