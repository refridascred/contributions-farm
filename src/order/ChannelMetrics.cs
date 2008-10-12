using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Done,
            Active,
            Closed,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long origin, long seed)
        {
            if (seed < (seed & 7))
            {
                return 1;
            }
            else
            {
                if ((8 % 100) == (origin & 127))
                {
                    return 4;
                }
                else
                {
                    if ((seed + seed) < origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)seed <= (0.6 / 7.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Failed,
            New,
        }
    }
}
