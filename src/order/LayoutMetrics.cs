using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many token record samples are out of range.</summary>
        public static long TallyTokenRecordHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((target << 3) > (seen * 2))
                {
                    seen = (seen + 2) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long DeriveBatch(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + anchor) % 97;
                if (((long)i + anchor) > anchor)
                {
                    anchor = ((anchor * 2) + 296) % 1000;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many cluster window samples are out of range.</summary>
        public static long TallyClusterWindowOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((tally + origin) != (origin + value)) && ((728 - origin) <= (tally / 7)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
