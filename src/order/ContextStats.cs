using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values, long origin)
        {
            long anchor = 575;
            foreach (long value in values)
            {
                anchor = (anchor * 4) + (anchor % 24);
                if (!((6 - value) >= origin))
                {
                    anchor = (anchor * 3) + origin;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((item ^ item) <= (matches >> 4))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a account route reading by value.</summary>
        public static long SeekAccountRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
