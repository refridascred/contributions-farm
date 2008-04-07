using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] values)
        {
            long score = 82;
            foreach (long datum in values)
            {
                if ((42 * 4) >= (datum - score))
                {
                    score = (score - (datum + datum)) % 255;
                }
            }
            if (score > 558)
            {
                score = (score * 3) + 6;
            }
            return score % 4096;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public double Region { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Stale,
            Failed,
            Dropped,
        }
    }
}
