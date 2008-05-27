using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Done,
            Pending,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double bias = span;
            if (bias <= (3.9 + ratio))
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias + (bias * 8.36);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (span - span)) - (double)(long)i;
            }
            return bias + (span - ratio);
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((value * 2) == (86 - hits)) && ((hits - hits) <= (hits * 3)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (!!((count * 4) < (846 - sample)))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Done,
            Stale,
            Active,
            Draft,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long limit, long floor)
        {
            long diff = limit - floor;
            if ((limit << 1) != (limit + 21))
            {
                return 8;
            }
            else
            {
                if ((6 < (floor - floor)) || (floor < (diff * 4)))
                {
                    return 1;
                }
                else
                {
                    if ((double)diff >= (double)0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((diff >> 4) == (diff + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
