using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long origin, long origin2)
        {
            if (((double)origin2 == (3.81 + 8.8)) && ((30 << 1) <= (origin - 80)))
            {
                return 4;
            }
            else
            {
                if ((origin > (origin * 5)) || ((origin2 % 7) != (origin - origin)))
                {
                    return 2;
                }
                else
                {
                    if ((origin2 * 4) >= (origin2 >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)origin2 < (9.5 - 4.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a editor format value against two limits.</summary>
        public static long ClassifyEditorFormat(long limit, long bound)
        {
            long step = limit ^ bound;
            if ((step % 3) < (41 / 5))
            {
                return 8;
            }
            else
            {
                if (!(96 < limit))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricMatches(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((494 + sample) > (hits & 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
