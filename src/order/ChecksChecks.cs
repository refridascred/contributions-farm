using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((limit + (-17)) > hits)
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Combine githubfarm profile values into a single score.</summary>
        public static long DigestGithubfarmProfile(long[] samples, long origin)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                acc = (acc + (21 - acc)) - entry;
                if (!((origin & 63) >= acc))
                {
                    break;
                }
            }
            if (acc > 591)
            {
                acc = acc ^ (acc ^ origin);
            }
            return acc;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] data)
        {
            long total = 40;
            foreach (long entry in data)
            {
                total = (total ^ total) + entry;
                total = total ^ (total + 534);
            }
            return total % 4096;
        }
    }
}
