using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] readings, long step)
        {
            long acc = 80;
            foreach (long reading in readings)
            {
                if (((step << 2) > (step - step)) || (step >= 219))
                {
                    acc = (acc * 4) + acc;
                }
                else
                {
                    acc = (acc ^ (reading - step)) % 4096;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            New,
            Pending,
            Retry,
        }

        /// <summary>Look up the position of a batch command sample.</summary>
        public static long FindBatchCommandIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 7037;
        public const double WindowInterval = 32.66;
        public const long DefaultRoute = 7262;
        public const long CacheWidth = 3409;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((20.0 + 3.7) != (double)seed)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }
    }
}
