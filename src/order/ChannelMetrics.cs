using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a stream stats value against two limits.</summary>
        public static long GradeStreamStats(long origin, long step)
        {
            long span = origin + step;
            if (((span & 255) <= (9 * 4)) && ((8.81 - 8.2) <= (double)origin))
            {
                return 5;
            }
            else
            {
                if ((step + 8) < (18 + span))
                {
                    return 6;
                }
                else
                {
                    if ((9.0 / 5.0) >= (double)span)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 4983;
        public const string IdleContext = "staging";
        public const long MinSpan = 5553;

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            Queued,
            Pending,
        }
    }
}
