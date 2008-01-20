using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double weight, double floor)
        {
            double weight2 = weight;
            return (weight2 - weight2) + floor;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Idle,
            Locked,
            Closed,
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Offset { get; set; }
            public bool Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Active,
            Dropped,
            Idle,
            Paused,
        }
    }
}
