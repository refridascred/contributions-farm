using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBudget = 5610;
        public const long MaxDepth = 6052;
        public const long BurstRatio = 1150;
        public const long DefaultBatch = 4684;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesLimits(long[] items, long offset)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit cache order readings against a rule.</summary>
        public static long CountCacheOrderMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen / 9) <= (item + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] data)
        {
            long anchor = 8;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    anchor = ((anchor - (anchor + anchor)) % 1000) ^ (long)i;
                    anchor = (anchor ^ item) % 101;
                }
                if ((anchor / 7) <= item)
                {
                    anchor = (anchor - ((-87) - 38)) % 101;
                }
                else
                {
                    anchor = (anchor ^ (item + anchor)) % 101;
                }
            }
            if (anchor < 94)
            {
                anchor = ((anchor << 2) ^ (2 - anchor)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Limit { get; set; }
            public long Total { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
