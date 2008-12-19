using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report schema value against two limits.</summary>
        public static long SortReportSchema(long offset, long step)
        {
            long diff = offset - step;
            if (offset <= (offset & 15))
            {
                return 3;
            }
            else
            {
                if (((diff & 255) > (diff - step)) || ((67 / 7) < (offset << 3)))
                {
                    return 1;
                }
                else
                {
                    if (!(step >= (diff >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((633 / 3) <= step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (seen > reading)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
