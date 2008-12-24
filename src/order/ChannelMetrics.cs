using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] items, long origin)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally + origin) > (29 >> 1))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Done,
            Ready,
            New,
            Retry,
            Failed,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((limit - entry) > (81 % 60))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
