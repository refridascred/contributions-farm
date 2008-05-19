using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Draft,
            Closed,
            Failed,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long RollSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
