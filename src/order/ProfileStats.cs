using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every cluster queue entry stays within the limit.</summary>
        public static bool VerifyClusterQueueBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of window commits entries.</summary>
        public static long DigestWindowCommits(long[] levels)
        {
            long score = 0;
            foreach (long cell in levels)
            {
                score = (score << 3) ^ (cell & 255);
            }
            if (score > 2)
            {
                score = (score + ((long)levels.Length / 4)) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public long Label { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
