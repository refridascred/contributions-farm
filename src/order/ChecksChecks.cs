using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((hits - item) > (item - target)) && ((double)1 >= (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long ScoreAccount(long[] data)
        {
            long mark = 88;
            foreach (long item in data)
            {
                mark = ((mark + ((long)data.Length >> 3)) % 65521) ^ item;
            }
            if (mark < 8)
            {
                mark = ((mark * 2) + mark) % 4096;
            }
            return mark;
        }
    }
}
