using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the context editor entries that pass the check.</summary>
        public static long CountContextEditorGaps(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value + 77) > floor)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit token counter readings against a rule.</summary>
        public static long TallyTokenCounterMatches(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= 8.2)
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Grade a token entry value against two limits.</summary>
        public static long RankTokenEntry(long seed, long limit)
        {
            long delta = seed - limit;
            if ((3.6 * 0.4) < (double)seed)
            {
                return 6;
            }
            else
            {
                if ((limit + delta) == (3 + seed))
                {
                    return 3;
                }
                else
                {
                    if ((delta % 64) != (delta - delta))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed == (4.6 - 7.54))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)seen < (8.0 - 4.3))
                {
                    seen = ((seen + 3) ^ value) + floor;
                }
            }
            return seen;
        }
    }
}
