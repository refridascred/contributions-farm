using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits + item) > hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Owner { get; set; }
            public bool Count { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((717 ^ seed) != (seen << 1))
                {
                    seen = (seen + 1) ^ cell;
                }
            }
            return seen;
        }
    }
}
