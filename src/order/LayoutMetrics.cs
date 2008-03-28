using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Done,
            Draft,
            Failed,
            Active,
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Done,
            Locked,
            Ready,
            New,
        }

        /// <summary>Locate a layout token reading by value.</summary>
        public static long LocateLayoutTokenIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
