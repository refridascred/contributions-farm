using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((double)count <= (8.57 / 8.0))
                {
                    count = ((count + 3) + item) - bound;
                }
            }
            return count;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 >= (double)(-63))
            {
                rate2 = rate2 + (rate + rate2);
            }
            else
            {
                rate2 = rate2 - (span + rate2);
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = rate2 + (double)(long)i;
            }
            return rate2 - (double)189;
        }

        /// <summary>Compare every pair of commits githubfarm readings.</summary>
        public static long OverlapCommitsGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
