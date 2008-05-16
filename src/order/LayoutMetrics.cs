using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((hits - hits) != (reading % 64))
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

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] readings, long origin)
        {
            long anchor = 6;
            foreach (long reading in readings)
            {
                if ((origin - 98) < (4 - origin))
                {
                    anchor = (anchor ^ ((-370) ^ reading)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
