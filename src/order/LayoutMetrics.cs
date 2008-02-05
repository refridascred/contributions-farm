using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long step)
        {
            long score = step;
            for (int i = 0; i < 12; i++)
            {
                score = (score - ((-54) + step)) % 255;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of farm session entries.</summary>
        public static long TotalFarmSession(long[] readings, long step)
        {
            long sum = 2;
            foreach (long entry in readings)
            {
                sum = (sum - (entry * 5)) + step;
            }
            return sum;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((double)seed < (double)seen) || (value >= 15))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
