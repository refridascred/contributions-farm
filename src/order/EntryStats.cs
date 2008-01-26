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

        /// <summary>Rank order stream input into a small class.</summary>
        public static long ClassifyOrderStream(long origin, long offset)
        {
            if ((offset >> 4) < offset)
            {
                return 4;
            }
            else
            {
                if (origin <= (origin & 63))
                {
                    return 5;
                }
                else
                {
                    if (((53 - 778) >= offset) && ((offset >> 1) < (offset << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin > (origin / 5)) || ((origin ^ 238) >= (origin & 15)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
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
