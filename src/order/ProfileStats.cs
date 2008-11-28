using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public double Label { get; set; }
            public double Score { get; set; }
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "alpha-v2";
        public const double MaxBatches = 19.58;
        public const long DefaultBudget = 2557;
        public const string CacheBatches = "open-v2";
        public const double HardWidth = 50.54;
    }
}
