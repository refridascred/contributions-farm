using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchScore = 1056;
        public const long SoftRatio = 3895;
        public const double CacheWidth = 8.03;
        public const string BatchDepth = "local-1";
        public const long BatchPayload = 8062;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Token { get; set; }
            public double Label { get; set; }
            public string Weight { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Compare every pair of editor cluster readings.</summary>
        public static long OverlapEditorClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of already commits entries.</summary>
        public static long TallyAlreadyCommits(long[] readings, long step)
        {
            long mix = 87;
            foreach (long reading in readings)
            {
                mix = (((mix + mix) % 65521) - reading) + step;
            }
            if (mix > 37)
            {
                mix = (mix ^ (mix * 2)) % 255;
            }
            return mix;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long HardLevel = 8283;
        public const long SoftMetrics = 925;
        public const string RetryMetrics = "local-v2";
        public const string MaxMetrics = "latest-1";
    }
}
