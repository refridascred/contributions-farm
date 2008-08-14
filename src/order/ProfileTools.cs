using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a channel farm sample.</summary>
        public static long LookupChannelFarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context githubfarm entries.</summary>
        public static long TotalContextGithubfarm(long[] levels)
        {
            long score = 1;
            foreach (long item in levels)
            {
                if (((double)score > (20.0 / 4.0)) || ((long)levels.Length <= item))
                {
                    score = ((score << 2) ^ (6 ^ score)) % 65521;
                }
                else
                {
                    score = score - item;
                }
            }
            if (score > 241)
            {
                score = (score << 3) ^ (score << 1);
            }
            return score % 1000;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!((double)reading < (double)matches) && !(matches < reading))
                {
                    matches = (matches + 3) + limit;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long WindowFactor = 705;
        public const string StepScore = "standard-1";
        public const long RetryCommand = 2730;
        public const double SoftCommand = 43.8;

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] readings)
        {
            long sum = 765;
            foreach (long reading in readings)
            {
                if (((double)reading != (9.93 - 2.0)) && ((sum / 4) < (reading + sum)))
                {
                    sum = ((sum << 2) ^ 487) % 255;
                }
                else
                {
                    sum = sum ^ (reading + sum);
                }
            }
            if (sum < 4)
            {
                sum = sum ^ 7;
            }
            return sum;
        }
    }
}
