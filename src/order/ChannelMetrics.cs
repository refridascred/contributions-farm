using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long DeriveMetric(long step)
        {
            long sum = step;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Locked,
            Done,
            Ready,
        }
    }
}
