using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] data, long bound)
        {
            long anchor = -599;
            foreach (long entry in data)
            {
                if (8.39 < (double)bound)
                {
                    anchor = ((anchor * 4) + (2 & 255)) ^ entry;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor * 3) + (anchor - 72);
            }
            return anchor;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels, long bound)
        {
            long anchor = -5;
            foreach (long datum in levels)
            {
                if (!((double)bound == (0.8 * 1.6)))
                {
                    anchor = (anchor ^ (datum * 2)) % 1000;
                    anchor = anchor - (datum >> 5);
                }
                anchor = anchor ^ bound;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Failed,
            Retry,
            Locked,
            Pending,
        }
    }
}
