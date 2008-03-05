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

        /// <summary>Count the stats tools entries that pass the check.</summary>
        public static long TallyStatsToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally + tally) < ((-90) << 1))
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
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
