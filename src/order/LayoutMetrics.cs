using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate editor checks readings against a bound.</summary>
        public static bool VerifyEditorChecksLimits(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Iterate the farm support series from a seed.</summary>
        public static long SeriesFarmSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ (mark + limit)) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
