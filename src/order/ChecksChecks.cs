using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Count the support token entries that pass the check.</summary>
        public static long MeasureSupportTokenMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!((count * 4) == (datum - (long)items.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 955;
        public const double IdleCache = 77.78;
        public const long CacheSpan = 3497;
    }
}
