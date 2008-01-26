using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Retry,
            New,
            Pending,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] values, long bound)
        {
            long mark = 1;
            foreach (long sample in values)
            {
                mark = (mark + (bound + bound)) + sample;
            }
            return mark;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Dropped,
            Draft,
            Closed,
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TotalReport(long[] samples, long limit)
        {
            long sum = 55;
            foreach (long sample in samples)
            {
                if (limit > (limit >> 1))
                {
                    sum = ((sum - (sum % 3)) % 4096) + sample;
                }
            }
            return sum % 4096;
        }

        /// <summary>Fold a list of contributi stream readings.</summary>
        public static long CombineContributiStream(long[] values)
        {
            long mix = 7;
            foreach (long sample in values)
            {
                mix = (((mix * 4) + (mix >> 2)) % 1000) + sample;
            }
            return mix;
        }
    }
}
