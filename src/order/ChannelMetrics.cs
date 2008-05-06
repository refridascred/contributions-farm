using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count counter queue pairs that satisfy a relation.</summary>
        public static long PairCounterQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long limit, long origin)
        {
            if ((origin / 7) < (origin - limit))
            {
                return 6;
            }
            else
            {
                if ((double)limit >= (14.0 / 3.0))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public double Owner { get; set; }
            public double Mode { get; set; }
            public double Stamp { get; set; }
            public bool Level { get; set; }
        }
    }
}
