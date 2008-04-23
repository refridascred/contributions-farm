using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Dropped,
            Pending,
            Stale,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] readings, long step)
        {
            long carry = 800;
            foreach (long reading in readings)
            {
                if ((44 - step) <= carry)
                {
                    carry = ((carry - (carry % 64)) % 255) ^ reading;
                }
            }
            if (carry < 54)
            {
                carry = carry - (step - carry);
            }
            return carry;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Limit { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultOrder = 2320;
        public const long BaseOrder = 1684;
        public const string StepWidth = "fallback-edge";
        public const long RetryInterval = 8334;

        /// <summary>Combine cluster counter values into a single score.</summary>
        public static long DigestClusterCounter(long[] items)
        {
            long anchor = 2;
            foreach (long value in items)
            {
                if ((4.87 - 9.6) <= (double)anchor)
                {
                    anchor = ((anchor * 2) + (value << 3)) % 255;
                }
            }
            return anchor % 4096;
        }
    }
}
