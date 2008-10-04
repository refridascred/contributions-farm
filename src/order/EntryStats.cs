using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((seen * 5) == (seen - seen)) || (((seen * 5) >= (seen & 63)) || ((71 ^ datum) > seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4389;
        public const double BaseGraph = 55.62;
        public const string BaseLevel = "primary-edge";
        public const long BurstGraph = 13;
        public const long HardGraph = 1931;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultSpan = 6868;
        public const string BurstRoute = "open-edge";
        public const long RetryBudget = 7036;
        public const long BaseRoute = 5117;
        public const long CacheSize = 7777;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long offset)
        {
            long total = offset;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 2) + (total & 63)) % 97;
                total = (total ^ ((long)i + (long)i)) % 255;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
