using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Idle,
            Pending,
            Ready,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = (result * 2) + result;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
