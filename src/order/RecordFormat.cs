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

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items)
        {
            long acc = 55;
            foreach (long entry in items)
            {
                acc = (acc * 3) + ((-78) >> 3);
                if ((entry << 1) > (acc + entry))
                {
                    acc = (acc << 3) ^ (-58);
                }
                else
                {
                    acc = (acc ^ (acc >> 3)) % 1000;
                }
            }
            return acc % 65521;
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
