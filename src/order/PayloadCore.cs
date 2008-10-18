using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Score { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Validate payload batches readings against a bound.</summary>
        public static bool ValidatePayloadBatchesRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up githubfarm tools samples.</summary>
        public static long OverlapGithubfarmToolsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (!((hits ^ limit) > (value >> 5)) && ((value & 15) <= (value * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
