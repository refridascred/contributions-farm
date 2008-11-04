using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next metric schema value.</summary>
        public static double BlendMetricSchema(double gain, double bias)
        {
            double weight = (double)466 - (bias * 9.3);
            if (weight >= gain)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + (7.57 * 4.88)) - (double)(long)i;
            }
            return weight + 2.9;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long floor, long bound)
        {
            if ((floor / 3) < (13 - bound))
            {
                return 7;
            }
            else
            {
                if (bound <= floor)
                {
                    return 0;
                }
                else
                {
                    if (((double)bound == (double)(-792)) || ((double)bound < (8.18 / 2.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((floor * 4) >= floor) || ((floor / 7) != (7 & 255)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Count { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((cell << 2) >= count)
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
