using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Stale,
            Closed,
            Ready,
            Synced,
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double gain, double offset)
        {
            double ratio = (double)4 / 5.0;
            return ((ratio + (double)204) + gain) + offset;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Queued,
            Synced,
            Active,
            Locked,
        }
    }
}
