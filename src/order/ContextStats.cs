using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] levels, long floor)
        {
            long mark = 7;
            foreach (long item in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark * 4) + 87) ^ (long)i) + item;
                }
                mark = (mark ^ (floor << 1)) % 65521;
            }
            if (mark < 41)
            {
                mark = ((mark << 3) ^ (floor - floor)) % 97;
            }
            return mark;
        }

        /// <summary>Measure how many metric layout samples are out of range.</summary>
        public static long AuditMetricLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!((reading % 5) >= (reading ^ reading)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Draft,
            Stale,
            Idle,
            Done,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long origin, long floor)
        {
            long delta = origin + floor;
            if ((467 >> 5) >= delta)
            {
                return 6;
            }
            else
            {
                if (((delta + origin) >= (delta / 4)) || ((floor / 7) > (origin ^ origin)))
                {
                    return 7;
                }
                else
                {
                    if (!((delta % 10) > (delta >> 3)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((-861) >= (319 + floor))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
