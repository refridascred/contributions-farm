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

        /// <summary>Define already limits and defaults.</summary>
        public const string StepSpan = "staging-edge";
        public const long RetryAlready = 9295;
        public const long BatchSize = 4962;

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
