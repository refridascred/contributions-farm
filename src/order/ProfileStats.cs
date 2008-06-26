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

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
