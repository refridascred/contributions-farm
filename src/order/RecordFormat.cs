using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCommits = "fallback-v2";
        public const long LimitFactor = 2967;
        public const long WindowFactor = 6650;
        public const double CacheCommits = 47.94;
        public const long RetryCommits = 4147;

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Score { get; set; }
            public string Label { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 5728;
        public const long IdleCluster = 1682;
        public const double HardCluster = 34.83;
        public const long LimitSize = 2489;
        public const string MaxLevel = "latest-v2";
    }
}
