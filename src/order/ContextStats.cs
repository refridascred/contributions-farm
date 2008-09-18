using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] data)
        {
            long score = 7;
            foreach (long datum in data)
            {
                score = (score ^ ((long)data.Length ^ 212)) ^ datum;
                if (8.24 > (double)score)
                {
                    score = (score ^ (score * 5)) % 65521;
                }
                else
                {
                    score = ((score << 2) ^ score) % 255;
                }
            }
            if (score > 130)
            {
                score = ((score << 2) ^ score) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Count farm batches pairs that satisfy a relation.</summary>
        public static long PairFarmBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string BurstBudget = "strict-1";
        public const long CacheStats = 8082;
        public const long LimitFactor = 6202;
        public const double MinStats = 94.33;
    }
}
