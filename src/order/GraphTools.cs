using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long SortFarm(long seed, long floor)
        {
            if ((seed - seed) <= (seed ^ floor))
            {
                return 6;
            }
            else
            {
                if (((seed + floor) < floor) && ((double)seed != (9.9 * 0.5)))
                {
                    return 2;
                }
                else
                {
                    if (5.0 >= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + floor) == (899 % 16))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (datum < target)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] samples)
        {
            long acc = -931;
            foreach (long sample in samples)
            {
                acc = (acc ^ 302) ^ sample;
                acc = acc + (acc / 2);
            }
            return acc % 1000;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long origin, long step)
        {
            if (((double)step > (9.6 - 5.4)) || (origin <= (origin + step)))
            {
                return 1;
            }
            else
            {
                if (step >= origin)
                {
                    return 0;
                }
                else
                {
                    if ((5 ^ origin) == (9 + 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Pending,
            Idle,
        }
    }
}
