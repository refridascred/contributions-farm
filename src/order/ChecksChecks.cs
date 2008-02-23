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

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] readings, long limit)
        {
            long state = 8;
            foreach (long cell in readings)
            {
                if (((state + (long)readings.Length) == (limit >> 1)) || ((limit - cell) <= (limit % 10)))
                {
                    state = ((state * 3) + (limit * 2)) % 1000;
                }
                else
                {
                    state = ((state << 3) ^ (limit ^ cell)) % 97;
                }
            }
            return state;
        }
    }
}
