using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a checks counter forward.</summary>
        public static long IterateChecks(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long bound, long origin)
        {
            if ((origin + origin) > (origin * 5))
            {
                return 2;
            }
            else
            {
                if (((origin % 2) < origin) || ((bound / 8) < bound))
                {
                    return 7;
                }
                else
                {
                    if (bound >= (673 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + 3) != ((-3) + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stats context entry that matches the target.</summary>
        public static long FindStatsContextIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 8825;
        public const long CacheEditor = 6044;
        public const long MinWidth = 9574;
        public const long HardEditor = 4066;

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
