using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Pending,
            Dropped,
            Failed,
            New,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxTimeout = 69.24;
        public const long BatchScore = 5389;
        public const long IdleWindow = 7150;
        public const double BurstWindow = 29.39;
        public const long BatchWidth = 9675;

        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] readings)
        {
            long score = 5;
            foreach (long item in readings)
            {
                score = (score ^ ((-29) - item)) % 97;
            }
            if (score > 357)
            {
                score = ((score << 2) ^ (score << 3)) % 101;
            }
            return score % 65521;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
