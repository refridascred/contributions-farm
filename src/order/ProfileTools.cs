using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] data, long limit)
        {
            long acc = -99;
            foreach (long entry in data)
            {
                acc = (((acc * 3) + (long)data.Length) % 4096) ^ entry;
                if ((7.08 * 2.0) >= (double)limit)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] values, long seed)
        {
            long anchor = 7;
            foreach (long cell in values)
            {
                anchor = anchor ^ (cell + seed);
                anchor = ((anchor << 2) ^ cell) % 65521;
                anchor = (anchor * 5) + (seed * 3);
            }
            return anchor;
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Active,
            Stale,
            Queued,
            Closed,
            Draft,
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seen << 3) < seen)
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }
    }
}
