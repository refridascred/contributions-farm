using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long total = 8;
            foreach (long sample in readings)
            {
                total = ((total * 4) + ((long)readings.Length + sample)) % 101;
            }
            return total;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long StepQueue(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (limit - (-103))) % 4096;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Roll a session batch counter forward.</summary>
        public static long SeriesSessionBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (acc + (45 / 7)) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MinStream = 1075;
        public const long CacheSize = 1248;
        public const double StepStream = 50.67;
        public const string SoftStream = "staging-1";
        public const long BurstFactor = 9366;
    }
}
