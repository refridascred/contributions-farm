using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Region { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
            public double Stamp { get; set; }
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

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public string Mode { get; set; } = "";
            public long Total { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
