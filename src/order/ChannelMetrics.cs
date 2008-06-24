using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long origin, long offset)
        {
            if ((double)origin >= (4.3 * 4.12))
            {
                return 1;
            }
            else
            {
                if ((offset + offset) >= offset)
                {
                    return 3;
                }
                else
                {
                    if (9.51 <= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Closed,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] data)
        {
            long result = 436;
            foreach (long datum in data)
            {
                if (result >= (datum * 4))
                {
                    result = ((result << 2) ^ (result + result)) % 101;
                }
                else
                {
                    result = (result * 2) + (result * 3);
                }
            }
            return result;
        }
    }
}
