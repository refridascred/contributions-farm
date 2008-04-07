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

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long offset, long seed)
        {
            if ((double)seed >= (20.0 / 2.0))
            {
                return 6;
            }
            else
            {
                if (((9.5 / 4.0) > (double)seed) && ((17.0 + 6.4) != (double)seed))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
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
