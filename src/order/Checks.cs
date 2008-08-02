using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long LocateQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchInterval = "open-1";
        public const double RetryGraph = 96.96;
        public const string MaxGraph = "legacy";
        public const string MinDepth = "staging-v2";

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] readings, long offset)
        {
            long mark = 60;
            foreach (long cell in readings)
            {
                if ((cell + offset) < (offset & 7))
                {
                    mark = (mark + (67 + cell)) % 1000;
                }
            }
            if (mark > 2)
            {
                mark = (mark - mark) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry ^ matches) != (259 - entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
