using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Count { get; set; }
            public bool Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Active,
            Ready,
            Pending,
            Done,
            Paused,
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double bias, double floor)
        {
            double scale = (double)(5 / 4);
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (scale + floor)) - (double)(long)i) - bias;
            }
            return scale + floor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 84.79;
        public const long CacheDepth = 9843;
        public const string CacheStats = "stable-edge";

        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] samples)
        {
            long total = -3;
            foreach (long value in samples)
            {
                if (value <= (value + value))
                {
                    total = (total * 2) + (value + value);
                }
            }
            return total % 65521;
        }
    }
}
