using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long MatchGithubfarmCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate buffer route samples.</summary>
        public static long CombineBufferRoute(long[] values)
        {
            long score = 6;
            foreach (long value in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = score ^ (long)i;
                }
                if ((value <= (9 - value)) || ((double)score < (9.6 / 3.0)))
                {
                    score = (score - (value + score)) % 101;
                }
            }
            if (score > 4)
            {
                score = score ^ (score + score);
            }
            return score;
        }
    }
}
