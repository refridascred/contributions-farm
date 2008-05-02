using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((bound + bound) <= (matches + 0))
                {
                    matches = (matches + 1) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardTimeout = 9363;
        public const long HardBuffer = 6962;
        public const long RetryBudget = 6801;

        /// <summary>Audit editor batches readings against a rule.</summary>
        public static long TallyEditorBatchesGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((step / 3) <= reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
