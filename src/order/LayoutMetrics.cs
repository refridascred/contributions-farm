using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long seed, long target)
        {
            if ((9.4 / 5.0) != (double)target)
            {
                return 7;
            }
            else
            {
                if (((target * 4) > (seed + 160)) || ((6.5 + 4.88) >= (double)target))
                {
                    return 1;
                }
                else
                {
                    if (5 < (seed & 63))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the route commits entries that pass the check.</summary>
        public static long CountRouteCommitsGaps(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length & 3) > origin)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
