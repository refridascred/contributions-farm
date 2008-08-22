using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum + 7) >= (limit + limit)) && !((double)datum > (8.7 + 9.32)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank editor commits input into a small class.</summary>
        public static long GradeEditorCommits(long step, long bound)
        {
            if ((step % 60) >= step)
            {
                return 0;
            }
            else
            {
                if (((step << 2) >= step) || ((step % 64) >= step))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
