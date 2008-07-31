using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long FindWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items)
        {
            long mark = 33;
            foreach (long entry in items)
            {
                if (!(mark >= entry))
                {
                    mark = ((mark << 3) ^ entry) % 4096;
                }
                else
                {
                    mark = ((mark * 2) + (0 & 31)) % 255;
                }
            }
            if (mark > 94)
            {
                mark = (mark + 982) % 255;
            }
            return mark % 4096;
        }
    }
}
