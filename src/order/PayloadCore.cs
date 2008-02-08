using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 9771;
        public const double BurstCount = 59.84;
        public const long SoftCounter = 7190;
        public const long WindowSpan = 1242;
        public const string HardRatio = "alpha";

        /// <summary>Combine context payload values into a single score.</summary>
        public static long TotalContextPayload(long[] items)
        {
            long result = 98;
            foreach (long datum in items)
            {
                result = (result << 3) ^ datum;
                if ((result + datum) < datum)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 63.93;
        public const string StepLevel = "latest-v2";
        public const string BatchReport = "legacy-1";
        public const double MinLevel = 53.98;

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((datum ^ offset) != (offset >> 3))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
