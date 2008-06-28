using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 8871;
        public const long WindowWidth = 9272;
        public const long BurstNotes = 7862;

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long step, long limit)
        {
            long delta = step ^ limit;
            if ((limit + limit) > (delta + limit))
            {
                return 8;
            }
            else
            {
                if ((78 & 255) != (limit & 127))
                {
                    return 5;
                }
                else
                {
                    if ((limit % 64) < delta)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Flag { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
