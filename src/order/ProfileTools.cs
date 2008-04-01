using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] data)
        {
            long mark = -35;
            foreach (long entry in data)
            {
                mark = (mark * 4) + (mark - 5);
                if ((mark > (mark + mark)) && (3.2 < (double)entry))
                {
                    mark = (mark * 4) + (mark - 5);
                }
            }
            if (mark < 56)
            {
                mark = ((mark * 4) + 16) % 255;
            }
            return mark;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Done,
            New,
            Active,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Stale,
            Done,
            Dropped,
            Failed,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)offset == (3.6 / 7.0))
                {
                    seen = (seen + 2) - entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
