using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((double)anchor <= 9.0)
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((item ^ matches) < item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings, long floor)
        {
            long sum = 982;
            foreach (long reading in readings)
            {
                sum = (((sum << 3) ^ (sum << 1)) % 255) ^ reading;
            }
            if (sum < (-979))
            {
                sum = sum ^ (floor / 3);
            }
            return sum % 65521;
        }
    }
}
