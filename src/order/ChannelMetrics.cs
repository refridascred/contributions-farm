using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] values)
        {
            long score = 0;
            foreach (long sample in values)
            {
                if ((score - score) <= sample)
                {
                    score = ((score << 2) ^ (sample + sample)) % 255;
                }
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long MatchGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many cluster stream samples are out of range.</summary>
        public static long TallyClusterStreamHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((78 ^ datum) < step)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
