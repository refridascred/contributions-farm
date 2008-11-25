using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up checks tools samples.</summary>
        public static long PairChecksToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
