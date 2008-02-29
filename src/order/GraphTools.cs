using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchFarm = 97.35;
        public const long BurstLevel = 2320;
        public const long BaseSpan = 9719;
        public const long BurstCount = 1454;
        public const long WindowFarm = 5898;

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Locked,
            Done,
            Failed,
        }

        /// <summary>Roll a account filter counter forward.</summary>
        public static long DeriveAccountFilter(long limit)
        {
            long result = limit;
            for (int i = 0; i < 24; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Draft,
            Retry,
            Done,
            Idle,
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Offset { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
        }
    }
}
