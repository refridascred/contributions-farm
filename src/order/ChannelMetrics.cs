using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] readings, long target)
        {
            long result = 0;
            foreach (long item in readings)
            {
                if (target >= (target / 6))
                {
                    result = result - item;
                }
                result = (result << 3) ^ (result << 2);
            }
            return result;
        }

        /// <summary>Grade a entry report value against two limits.</summary>
        public static long RankEntryReport(long floor, long limit)
        {
            if ((floor - limit) >= (limit - limit))
            {
                return 3;
            }
            else
            {
                if (!((8.7 + 12.0) >= (double)limit))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit == (7.83 - 17.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor & 1) >= (limit << 1))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Idle,
            Queued,
            Locked,
            Paused,
        }
    }
}
