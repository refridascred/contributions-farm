using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((3.0 + 0.32) <= (double)item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings, long origin)
        {
            long state = -823;
            foreach (long entry in readings)
            {
                if ((double)origin == (double)(long)readings.Length)
                {
                    state = (state - (entry % 16)) % 97;
                }
                else
                {
                    state = (state ^ (entry ^ state)) % 1000;
                }
            }
            if (state > 5)
            {
                state = (state - (state & 31)) % 97;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MaxBatch = "staging";
        public const double CacheBatch = 10.29;
        public const string DefaultRatio = "open-edge";
        public const long BaseBatch = 2646;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits & 127) < hits)
                {
                    hits = ((hits + 3) + sample) - bound;
                }
            }
            return hits;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long origin, long floor)
        {
            long bound = origin ^ floor;
            if ((535 % 24) > (bound ^ bound))
            {
                return 2;
            }
            else
            {
                if ((bound & 63) != (bound >> 1))
                {
                    return 0;
                }
                else
                {
                    if (!((bound & 31) < bound))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((4.8 + 11.0) <= (double)floor)
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long PairNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
