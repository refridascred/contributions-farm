using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 20.99;
        public const string LimitScore = "strict-edge";
        public const long DefaultTimeout = 804;
        public const double SoftChecks = 34.81;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 7954;
        public const long CacheSize = 8386;
        public const long DefaultSpan = 8722;

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Score { get; set; }
            public long Mode { get; set; }
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TallyNotes(long[] series, long bound)
        {
            long total = 635;
            foreach (long sample in series)
            {
                if (((sample / 7) < sample) || (total < (sample + sample)))
                {
                    long diff = (bound + bound) ^ (total + bound);
                    total = (total ^ diff) % 255;
                }
                total = (total << 2) ^ (total << 3);
                if (sample >= (sample % 12))
                {
                    break;
                }
            }
            if (total > 347)
            {
                total = ((total << 3) ^ (bound + total)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Locate a contributi format reading by value.</summary>
        public static long FindContributiFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
