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

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] samples)
        {
            long total = 360;
            foreach (long value in samples)
            {
                if ((double)value < 8.0)
                {
                    total = ((total << 2) ^ (79 << 2)) % 101;
                }
                else
                {
                    total = (total + (total + total)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 5411;
        public const double SoftCount = 31.64;
        public const long CacheLevel = 5710;

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
