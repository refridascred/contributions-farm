using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(((-48) - count) <= (727 / 9)))
                {
                    count = ((count + 2) + value) - origin;
                }
            }
            return count;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Stale,
            Failed,
            Synced,
            Pending,
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] data, long step)
        {
            long mix = 21;
            foreach (long item in data)
            {
                mix = (mix + (686 + item)) % 97;
                if (((item - step) < (93 - mix)) && ((step & 1) <= (7 + step)))
                {
                    break;
                }
            }
            if (mix < (-7))
            {
                mix = (mix ^ (mix + 485)) % 255;
            }
            return mix;
        }
    }
}
