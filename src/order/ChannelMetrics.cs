using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a stats queue pair into a bucket.</summary>
        public static long GradeStatsQueue(long origin, long limit)
        {
            long step = origin ^ limit;
            if (step >= (step << 1))
            {
                return 6;
            }
            else
            {
                if ((step * 2) >= (step / 9))
                {
                    return 7;
                }
                else
                {
                    if ((origin ^ origin) > 27)
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long ClassifyFormat(long bound, long offset)
        {
            long next = bound + offset;
            if ((262 * 5) == (next + next))
            {
                return 2;
            }
            else
            {
                if ((offset >> 5) <= (bound - offset))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
