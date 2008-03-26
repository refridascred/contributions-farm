using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] readings, long bound)
        {
            long acc = -8;
            foreach (long cell in readings)
            {
                if ((acc << 2) >= (bound >> 5))
                {
                    acc = (acc - (bound + bound)) - cell;
                }
            }
            return acc;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
