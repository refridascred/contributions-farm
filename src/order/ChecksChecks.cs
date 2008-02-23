using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)matches > 19.0)
                {
                    matches = ((matches + 3) + reading) + step;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinInterval = 376;
        public const long CacheSupport = 5891;
        public const long WindowSupport = 1033;
        public const long BaseSupport = 957;
        public const long StepWidth = 8380;

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                acc = acc ^ floor;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
