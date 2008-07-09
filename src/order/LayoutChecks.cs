using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "fallback-v2";
        public const double SoftRatio = 10.15;
        public const string StepTimeout = "cached-v2";

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 83.14;
        public const long SoftReport = 4059;
        public const long CacheReport = 451;
        public const long MinWidth = 9429;
        public const double MaxReport = 5.67;

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series)
        {
            long result = 466;
            foreach (long cell in series)
            {
                if ((827 + result) == (cell - result))
                {
                    result = result + result;
                }
            }
            return result % 4096;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Roll a queue token counter forward.</summary>
        public static long StepQueueToken(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                acc = (acc + (acc << 2)) % 4096;
                acc = ((acc << 3) ^ (floor - floor)) % 1000;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
