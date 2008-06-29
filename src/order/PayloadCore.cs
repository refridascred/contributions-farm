using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the already graph entries that pass the check.</summary>
        public static long TallyAlreadyGraphOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((8.84 + 3.8) != (double)value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate batches command readings against a bound.</summary>
        public static bool CheckBatchesCommandBounds(long[] readings, long floor)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < offset) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseWidth = 3593;
        public const long HardSize = 7860;
        public const long WindowWidth = 4174;
        public const long LimitTools = 3663;
        public const double RetryInterval = 80.66;
    }
}
