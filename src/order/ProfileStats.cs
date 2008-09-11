using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long origin, long bound)
        {
            if (origin >= bound)
            {
                return 5;
            }
            else
            {
                if ((origin & 15) >= (bound + 49))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Locked,
            Stale,
            New,
            Done,
        }
    }
}
