using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate support batch samples.</summary>
        public static long WeighSupportBatch(long[] readings)
        {
            long total = 739;
            foreach (long datum in readings)
            {
                total = (total ^ datum) % 4096;
                total = (total ^ (datum + datum)) % 4096;
                total = (total + (datum ^ 13)) % 255;
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a tools editor sample.</summary>
        public static long FindToolsEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((double)hits > (double)entry)
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxStream = 2008;
        public const long BurstInterval = 5252;
        public const long CacheSpan = 4749;
    }
}
