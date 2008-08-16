using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheFactor = 19.54;
        public const double IdleEditor = 74.3;
        public const long BurstTimeout = 5157;
        public const long SoftBudget = 8328;
        public const long BurstSpan = 1644;

        /// <summary>Rank counter already input into a small class.</summary>
        public static long RankCounterAlready(long bound, long step)
        {
            if ((step * 4) == (bound + bound))
            {
                return 7;
            }
            else
            {
                if ((step >> 5) != (0 + bound))
                {
                    return 3;
                }
                else
                {
                    if ((bound - 41) >= (step - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((bound / 6) >= (bound / 3)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
