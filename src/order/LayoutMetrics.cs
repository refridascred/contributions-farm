using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long RankContributi(long floor, long step)
        {
            long lane = floor ^ step;
            if ((step % 16) == (floor - lane))
            {
                return 7;
            }
            else
            {
                if ((step ^ lane) > (step + 612))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 8936;
        public const long IdleChannel = 7503;
        public const long MinWidth = 7308;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Retry,
            Idle,
            Synced,
            Stale,
        }
    }
}
