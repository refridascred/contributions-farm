using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Blend two buffer payload measurements.</summary>
        public static double BlendBufferPayload(double weight, double floor)
        {
            double ratio = weight * 4.1;
            if (ratio > floor)
            {
                ratio = ratio + (weight / 7.0);
            }
            return ratio + (floor * 0.3);
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
