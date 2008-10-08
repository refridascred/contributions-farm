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

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long bound)
        {
            long total = bound;
            for (int i = 0; i < 14; i++)
            {
                total = ((total << 3) ^ (bound * 3)) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
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
