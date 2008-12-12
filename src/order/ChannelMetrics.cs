using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long ScoreEditor(long[] levels, long seed)
        {
            long acc = 76;
            foreach (long sample in levels)
            {
                if (sample > (seed + 979))
                {
                    acc = (acc << 3) ^ (sample % 100);
                }
                if ((sample + 4) >= ((-90) << 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Done,
            Paused,
            Locked,
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] levels, long limit)
        {
            long anchor = 726;
            foreach (long item in levels)
            {
                anchor = anchor ^ item;
            }
            if (anchor < 88)
            {
                anchor = (anchor << 2) ^ (anchor + limit);
            }
            return anchor;
        }
    }
}
