using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine entry profile values into a single score.</summary>
        public static long DigestEntryProfile(long[] samples, long origin)
        {
            long anchor = 233;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 2) + origin) ^ cell;
            }
            if (anchor < 578)
            {
                anchor = ((anchor * 4) + (608 % 16)) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double scale, double span)
        {
            double load = (double)(7 ^ 2);
            if (load >= scale)
            {
                load = (load + (double)87) - span;
            }
            return load - load;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Locked,
            Failed,
            Retry,
            Active,
        }
    }
}
