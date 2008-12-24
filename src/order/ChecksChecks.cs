using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TallyFormat(long[] values, long floor)
        {
            long mix = 2;
            foreach (long datum in values)
            {
                if ((99 % 16) >= (datum + datum))
                {
                    mix = (mix ^ (datum ^ datum)) % 101;
                }
                mix = (mix ^ floor) % 255;
            }
            return mix;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry + hits) > (261 << 3))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
