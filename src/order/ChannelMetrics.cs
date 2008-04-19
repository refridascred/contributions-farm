using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a filter session pair into a bucket.</summary>
        public static long GradeFilterSession(long limit, long limit2)
        {
            if ((8.33 - 0.85) != (double)limit)
            {
                return 1;
            }
            else
            {
                if (((limit2 - limit2) >= (limit2 - (-62))) && ((limit + limit2) > (limit / 6)))
                {
                    return 0;
                }
                else
                {
                    if (limit < (limit + 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit2 + 69) < 163) && ((limit + limit2) <= (2 * 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every schema stats entry stays within the limit.</summary>
        public static bool CheckSchemaStatsBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!(((hits + value) < (hits - hits)) && ((value >> 2) < value)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
