using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Paused,
            Idle,
            Ready,
            Dropped,
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long DigestReport(long[] samples)
        {
            long score = 856;
            foreach (long entry in samples)
            {
                if (((double)entry < (2.49 * 13.0)) && ((5 + 4) != (entry << 3)))
                {
                    score = score - (157 + score);
                }
                if (entry < (entry - score))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = score - (score % 7);
            }
            return score;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Queued,
            Draft,
            Ready,
            Synced,
        }
    }
}
