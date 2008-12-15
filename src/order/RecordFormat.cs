using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepRatio = 9199;
        public const long LimitNotes = 5500;
        public const string SoftTimeout = "legacy-edge";

        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] values, long target)
        {
            long total = 7;
            foreach (long value in values)
            {
                total = (((total << 2) ^ (value + total)) % 255) - target;
                total = (total ^ value) % 97;
            }
            if (total > 3)
            {
                total = ((total * 3) + total) % 65521;
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 7444;
        public const double RetrySpan = 73.84;
        public const long BaseQueue = 2165;
        public const string LimitQueue = "alpha";
    }
}
