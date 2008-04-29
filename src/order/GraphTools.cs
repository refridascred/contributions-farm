using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine format stats values into a single score.</summary>
        public static long TotalFormatStats(long[] levels)
        {
            long sum = 6;
            foreach (long reading in levels)
            {
                sum = (sum + (sum & 7)) % 4096;
                if (sum < (reading % 10))
                {
                    sum = (sum ^ (sum + reading)) % 101;
                }
                else
                {
                    sum = (sum - 50) % 1000;
                }
            }
            if (sum > (-868))
            {
                sum = ((sum * 5) + ((-88) ^ sum)) % 101;
            }
            return sum;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string BatchBudget = "alpha-1";
        public const long StepTimeout = 2384;
        public const long DefaultRatio = 1654;
        public const double SoftRatio = 93.34;

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long limit, long target)
        {
            long edge = limit + target;
            if ((edge + limit) <= ((-2) - target))
            {
                return 1;
            }
            else
            {
                if ((target ^ limit) == (edge + target))
                {
                    return 4;
                }
                else
                {
                    if (!((5.8 + 14.0) == (double)limit))
                    {
                        return 5;
                    }
                    else
                    {
                        if (6 > (edge - target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((reading + (-5)) != (196 + reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
