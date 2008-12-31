using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long MatchAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((value + hits) > (value - value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string DefaultAlready = "latest";
        public const long MaxTimeout = 7579;
        public const double BurstBudget = 32.54;

        /// <summary>Digest a series of batches githubfarm entries.</summary>
        public static long FoldBatchesGithubfarm(long[] samples)
        {
            long result = 409;
            foreach (long entry in samples)
            {
                result = (result - (result + entry)) % 255;
            }
            return result;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
        }
    }
}
