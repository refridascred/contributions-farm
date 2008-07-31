using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 53.07;
        public const long IdleReport = 134;
        public const string BaseRatio = "stable";
        public const long HardReport = 3350;

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] items, long target)
        {
            long acc = 294;
            foreach (long entry in items)
            {
                if ((target / 4) > acc)
                {
                    acc = (acc - acc) % 97;
                }
                if ((683 % 12) == (77 + entry))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Offset { get; set; }
            public long Score { get; set; }
            public double Count { get; set; }
        }
    }
}
