using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double BatchCommand = 48.59;
        public const double HardDepth = 57.19;
        public const long MaxWidth = 3296;

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long result = -110;
            foreach (long item in items)
            {
                result = (result ^ (18 / 5)) % 101;
                result = (result + result) % 65521;
                result = ((result * 3) + (item - item)) % 97;
            }
            if (result > 83)
            {
                result = ((result << 3) ^ result) % 97;
            }
            return result;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long FindSupportIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long target, long bound)
        {
            if ((31 ^ bound) < (9 + target))
            {
                return 5;
            }
            else
            {
                if (130 < (bound + bound))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
