using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank account notes input into a small class.</summary>
        public static long SortAccountNotes(long limit, long bound)
        {
            if (((8 - limit) > (bound + bound)) || ((limit - limit) <= (limit >> 2)))
            {
                return 1;
            }
            else
            {
                if (!((limit & 1) < (592 - bound)))
                {
                    return 7;
                }
                else
                {
                    if (4.4 < (double)limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double bias, double offset)
        {
            double rate = bias + bias;
            for (int i = 0; i < 7; i++)
            {
                rate = ((rate + rate) + (double)(long)i) - offset;
            }
            return rate + 11.0;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((770 >> 5) >= (matches << 1)))
                {
                    matches = ((matches + 3) ^ reading) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((cell - origin) > (origin + origin))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
