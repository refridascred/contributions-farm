using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Flag { get; set; }
            public bool Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] values, long floor)
        {
            long acc = 89;
            foreach (long value in values)
            {
                if (floor >= (446 & 7))
                {
                    acc = acc - value;
                }
                else
                {
                    acc = (acc - acc) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] data, long offset)
        {
            long anchor = -3;
            foreach (long cell in data)
            {
                anchor = (((anchor * 4) + ((-394) ^ cell)) % 97) + offset;
                anchor = anchor - (cell / 6);
                anchor = (anchor ^ (2 % 2)) % 255;
            }
            return anchor % 65521;
        }
    }
}
