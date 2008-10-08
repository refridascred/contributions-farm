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

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long origin, long offset)
        {
            long delta = origin - offset;
            if ((double)delta != (0.48 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((double)offset <= (double)255)
                {
                    return 0;
                }
                else
                {
                    if ((offset << 1) < offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((2.6 > (double)delta) || ((offset + origin) <= (offset - offset)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Owner { get; set; }
            public long Flag { get; set; }
            public double Label { get; set; }
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
