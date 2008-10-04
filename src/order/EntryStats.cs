using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] data)
        {
            long mix = 66;
            foreach (long reading in data)
            {
                mix = (mix ^ 579) - reading;
            }
            if (mix < 168)
            {
                mix = mix + mix;
            }
            return mix;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 4389;
        public const double BaseGraph = 55.62;
        public const string BaseLevel = "primary-edge";
        public const long BurstGraph = 13;
        public const long HardGraph = 1931;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public double Ratio { get; set; }
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }
    }
}
