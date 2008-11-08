using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long ClassifyFarm(long bound, long seed)
        {
            if ((seed >> 1) == (47 << 1))
            {
                return 0;
            }
            else
            {
                if ((2.29 + 18.0) < (double)seed)
                {
                    return 4;
                }
                else
                {
                    if (bound <= (seed << 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (bound >= (bound + bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double bias, double offset)
        {
            double ratio = bias / 4.0;
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (offset * 6.8)) + (double)(long)i;
            }
            return ratio + (2.37 * 3.83);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Pending,
            Stale,
            New,
            Draft,
        }
    }
}
