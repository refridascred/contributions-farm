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

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Paused,
            Idle,
            Done,
            Failed,
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

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
