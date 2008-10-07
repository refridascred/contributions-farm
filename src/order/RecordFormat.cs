using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleSpan = 5145;
        public const long HardEntry = 3682;
        public const long SoftScore = 7909;

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] readings, long floor)
        {
            long acc = 624;
            foreach (long reading in readings)
            {
                if ((floor % 5) < 3)
                {
                    acc = ((acc * 5) + (81 + reading)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Measure how many metrics already samples are out of range.</summary>
        public static long CountMetricsAlreadyOutliers(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!(7.16 <= (double)item))
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Check that every tools command entry stays within the limit.</summary>
        public static bool CheckToolsCommandLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
