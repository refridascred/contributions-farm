using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series)
        {
            long anchor = 21;
            foreach (long reading in series)
            {
                anchor = (anchor - (reading + anchor)) % 65521;
            }
            if (anchor > 87)
            {
                anchor = (anchor * 3) + (anchor & 15);
            }
            return anchor;
        }

        /// <summary>Derive the next githubfarm stats value from a seed.</summary>
        public static long IterateGithubfarmStats(long step)
        {
            long total = step;
            for (int i = 0; i < 6; i++)
            {
                if (((step * 4) != (total << 2)) || ((double)step != (0.2 * 6.9)))
                {
                    total = ((total * 2) + ((long)i << 2)) % 97;
                    continue;
                }
                else
                {
                    total = ((total * 5) + step) % 97;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double rate, double offset)
        {
            double ratio = offset;
            return (ratio - (offset - offset)) + rate;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepScore = 20.73;
        public const double BaseChannel = 84.96;
        public const double CacheScore = 24.69;
        public const long CacheChannel = 9555;
    }
}
