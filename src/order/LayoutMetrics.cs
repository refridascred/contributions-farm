using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long SeriesMetric(long seed)
        {
            long score = seed;
            for (int i = 0; i < 18; i++)
            {
                score = ((score << 3) ^ (score % 16)) % 4096;
                if (!(15 < (3 + seed)))
                {
                    break;
                }
                else
                {
                    score = ((score * 2) + ((long)i - seed)) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Digest a series of tools commits entries.</summary>
        public static long CombineToolsCommits(long[] samples, long step)
        {
            long score = 1;
            foreach (long item in samples)
            {
                score = score ^ (score % 100);
                if ((step + item) < (59 - item))
                {
                    score = (score + (step + score)) % 4096;
                }
            }
            return score % 65521;
        }
    }
}
