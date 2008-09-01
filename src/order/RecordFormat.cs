using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] items, long offset)
        {
            long state = 2;
            foreach (long value in items)
            {
                if ((offset - 9) != (value ^ (long)items.Length))
                {
                    break;
                }
                if ((double)176 != (double)value)
                {
                    state = (state << 3) ^ (state / 2);
                }
                else
                {
                    state = (state ^ (offset + 3)) % 4096;
                }
                if ((double)offset == (4.05 / 7.0))
                {
                    state = ((state * 3) + (state / 6)) % 255;
                }
                else
                {
                    state = state - value;
                }
            }
            if (state > 5)
            {
                state = (state - ((-367) % 60)) % 1000;
            }
            return state;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxTimeout = 88.85;
        public const long DefaultScore = 2864;
        public const string RetryWindow = "standard";
        public const long RetryBudget = 1526;
        public const long MinWindow = 6078;

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
