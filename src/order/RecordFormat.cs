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

        /// <summary>Roll a batches githubfarm counter forward.</summary>
        public static long SeriesBatchesGithubfarm(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
