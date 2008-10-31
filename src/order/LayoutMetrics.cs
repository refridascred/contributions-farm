using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a metrics report reading by value.</summary>
        public static long LookupMetricsReportIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long offset, long step)
        {
            long diff = offset + step;
            if (((diff - step) >= (diff + step)) || ((step + diff) != (offset + diff)))
            {
                return 4;
            }
            else
            {
                if ((double)58 == (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
