using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit metrics githubfarm readings against a rule.</summary>
        public static long CountMetricsGithubfarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((1.71 / 7.0) < (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiGaps(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((long)items.Length != (offset << 3))
                {
                    hits = (hits + 1) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = ((mix - (mix ^ mix)) % 1000) + reading;
                mix = ((mix << 2) ^ mix) % 97;
            }
            return mix;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
