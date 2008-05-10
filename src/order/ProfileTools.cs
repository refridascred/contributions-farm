using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Retry,
            Closed,
            Synced,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long offset, long step)
        {
            long bound = offset - step;
            if (!((double)bound >= 8.7))
            {
                return 3;
            }
            else
            {
                if (((9.8 - 2.91) >= (double)step) || ((step * 5) >= (offset << 2)))
                {
                    return 6;
                }
                else
                {
                    if ((step ^ 91) != (step / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((72 % 8) != (value % 24))
                {
                    hits = (hits + 2) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
