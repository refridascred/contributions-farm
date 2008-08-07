using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string RetrySpan = "staging";
        public const long LimitCommand = 26;
        public const string BurstLevel = "strict";

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long origin, long bound)
        {
            long lane = origin ^ bound;
            if ((lane + origin) >= origin)
            {
                return 1;
            }
            else
            {
                if ((lane - lane) <= (lane ^ bound))
                {
                    return 7;
                }
                else
                {
                    if (((29 - 17) >= bound) || ((double)lane <= 0.1))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin - bound) >= bound)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the metric graph series from a seed.</summary>
        public static long DeriveMetricGraph(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count + (-484)) <= (count + item))
                {
                    count = (count + 2) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
