using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] data)
        {
            long mark = 38;
            foreach (long value in data)
            {
                mark = (((mark << 3) ^ (mark + mark)) % 4096) - value;
            }
            return mark % 97;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Failed,
            Ready,
            Queued,
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Mode { get; set; } = "";
            public bool Label { get; set; }
        }
    }
}
