using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings, long step)
        {
            long total = 2;
            foreach (long item in readings)
            {
                if (((step * 2) > (item << 3)) || ((step * 2) >= total))
                {
                    total = (total << 2) ^ (78 & 127);
                }
                if ((5 - item) >= (step / 3))
                {
                    total = (total ^ (step & 255)) % 101;
                }
                if ((item + 34) <= (total - 509))
                {
                    break;
                }
            }
            if (total > 5)
            {
                total = (total << 3) ^ (total / 6);
            }
            return total;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSize = 5698;
        public const long SoftSpan = 5605;
        public const long DefaultSupport = 4660;
        public const long LimitSupport = 9138;
        public const long RetryLevel = 8157;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((hits / 4) > (hits + entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstCommits = 7688;
        public const long WindowInterval = 2175;
        public const long LimitScore = 8947;
        public const string SoftScore = "local-1";
    }
}
