using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            New,
            Active,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 4062;
        public const long BurstRoute = 4071;
        public const double SoftRoute = 66.28;
        public const long HardRoute = 9443;
        public const double LimitRoute = 43.54;

        /// <summary>Find the first farm window entry that matches the target.</summary>
        public static long LookupFarmWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
