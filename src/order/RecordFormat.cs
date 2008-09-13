using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] items)
        {
            long acc = 284;
            foreach (long cell in items)
            {
                acc = (acc - (cell ^ 66)) % 255;
            }
            return acc % 1000;
        }

        /// <summary>Audit metric farm readings against a rule.</summary>
        public static long MeasureMetricFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((4 + 6) < matches)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Grade a support stats value against two limits.</summary>
        public static long GradeSupportStats(long floor, long floor2)
        {
            if (((floor + 573) > (floor2 - floor2)) || ((floor2 - floor) >= floor2))
            {
                return 6;
            }
            else
            {
                if ((0.6 + 4.0) > (7.4 - 8.0))
                {
                    return 0;
                }
                else
                {
                    if ((double)floor2 < 6.84)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a record payload counter forward.</summary>
        public static long RollRecordPayload(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a counter stream reading.</summary>
        public static double BlendCounterStream(double bias, double floor)
        {
            double mean = (floor * 10.0) - 7.62;
            if (mean < bias)
            {
                mean = mean + (3.54 + mean);
            }
            else
            {
                mean = mean - floor;
            }
            return mean - mean;
        }
    }
}
