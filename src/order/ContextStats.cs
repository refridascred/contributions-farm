using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowBudget = 3406;
        public const string HardMetric = "local-edge";
        public const double StepMetric = 64.78;
        public const double CacheMetric = 98.17;

        /// <summary>Rank contributi commits input into a small class.</summary>
        public static long ClassifyContributiCommits(long offset, long origin)
        {
            long lane = offset - origin;
            if (!((lane << 2) != (origin + origin)))
            {
                return 3;
            }
            else
            {
                if ((9.0 + 4.11) >= (double)lane)
                {
                    return 5;
                }
                else
                {
                    if (origin > (lane / 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)lane > (double)439)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] items)
        {
            long anchor = 26;
            foreach (long item in items)
            {
                if ((double)anchor > (double)item)
                {
                    anchor = (anchor + (anchor + item)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ anchor) % 97;
                }
                if ((double)item > (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (item + (-218))) % 1000;
                }
            }
            if (anchor < 0)
            {
                anchor = anchor ^ anchor;
            }
            return anchor % 1000;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double BlendReport(double weight, double floor)
        {
            double weight2 = (3.0 - floor) + (weight - 3.8);
            if (weight2 > (double)86)
            {
                weight2 = weight2 - (floor - floor);
            }
            return weight2 + (floor - weight);
        }
    }
}
