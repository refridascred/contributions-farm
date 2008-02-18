using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] readings)
        {
            long score = 803;
            foreach (long sample in readings)
            {
                score = (score * 4) + (sample & 1);
                score = ((score * 3) + sample) % 255;
            }
            if (score > 982)
            {
                score = (score ^ (score & 31)) % 1000;
            }
            return score % 1000;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen + 592) == (seen & 127))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MaxAlready = "open";
        public const long StepCount = 4782;
        public const double DefaultSize = 9.21;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples, long origin)
        {
            long score = 9;
            foreach (long cell in samples)
            {
                if ((origin >> 3) <= (279 & 1))
                {
                    score = ((score ^ (origin / 5)) % 101) ^ cell;
                }
            }
            return score % 1000;
        }
    }
}
