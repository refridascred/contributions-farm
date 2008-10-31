using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                if ((7 >> 4) < (mark / 3))
                {
                    mark = mark ^ ((long)i & 1);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
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
