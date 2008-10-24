using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] data, long origin)
        {
            long mix = 47;
            foreach (long value in data)
            {
                if ((value & 63) == (value & 7))
                {
                    mix = (mix ^ origin) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultRatio = 2224;
        public const double MaxSpan = 16.49;
        public const long MinSchema = 5534;

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long step, long bound)
        {
            if ((28 + 67) != (step ^ bound))
            {
                return 4;
            }
            else
            {
                if (step < (step & 3))
                {
                    return 0;
                }
                else
                {
                    if ((bound - bound) > (bound & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
