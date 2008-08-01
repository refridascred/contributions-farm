using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double scale, double span)
        {
            double rate = span;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + (span - span)) + (double)(long)i) + scale;
            }
            return rate - (16.0 / 7.0);
        }

        /// <summary>Find the first githubfarm cache entry that matches the target.</summary>
        public static long FindGithubfarmCacheIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
