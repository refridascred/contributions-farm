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

        /// <summary>Find the first profile entry entry that matches the target.</summary>
        public static long LookupProfileEntryIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)cell == (double)matches) || !((4.44 + 5.8) >= (6.99 + 1.91)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
