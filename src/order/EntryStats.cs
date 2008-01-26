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

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] series)
        {
            long carry = 82;
            foreach (long value in series)
            {
                carry = (carry ^ (value << 1)) % 65521;
            }
            return carry;
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
