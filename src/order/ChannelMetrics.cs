using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((double)reading != (0.6 - 14.0))
                {
                    count = (count + 2) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
