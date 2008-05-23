using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry & 15) == (entry % 100))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheScore = 84.31;
        public const long SoftSize = 3046;
        public const double DefaultDepth = 25.62;

        /// <summary>Adjust a buffer graph reading.</summary>
        public static double SmoothBufferGraph(double scale, double offset)
        {
            double drift = offset - (double)1;
            if (drift >= (drift + scale))
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - scale) + (double)(long)i;
            }
            return drift + (double)9;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Score { get; set; } = "";
            public double Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
