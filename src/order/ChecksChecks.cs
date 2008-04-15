using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Mode { get; set; }
            public bool Total { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((hits + datum) <= hits) && (((double)hits > (2.0 * 5.0)) && ((hits - datum) > (datum - hits))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
