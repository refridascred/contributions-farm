using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long step, long limit)
        {
            if ((19.0 * 9.93) == (double)limit)
            {
                return 2;
            }
            else
            {
                if ((step / 3) > (step - step))
                {
                    return 6;
                }
                else
                {
                    if ((limit ^ 3) >= (-852))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long GradeFilter(long floor, long bound)
        {
            if ((bound - 597) >= (bound * 5))
            {
                return 4;
            }
            else
            {
                if ((floor - floor) <= floor)
                {
                    return 2;
                }
                else
                {
                    if ((bound ^ bound) < (floor / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((floor * 3) < 547))
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

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] data, long target)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry & 127) <= 745)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((entry % 100) < (entry % 60)) || ((entry > (entry & 63)) && (seen < entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long StepFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }
    }
}
