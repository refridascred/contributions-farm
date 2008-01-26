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

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen <= datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
