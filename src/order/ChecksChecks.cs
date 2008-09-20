using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long floor, long bound)
        {
            if (4.3 >= (double)floor)
            {
                return 7;
            }
            else
            {
                if (((floor - floor) == (bound / 2)) && (floor > (bound % 2)))
                {
                    return 2;
                }
                else
                {
                    if ((1.07 + 4.79) <= (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor + bound) == (floor + floor)) || (floor < (bound % 24)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowBudget = "fallback-v2";
        public const long BaseScore = 28;
        public const long CacheFarm = 6919;

        /// <summary>Count batch stream pairs that satisfy a relation.</summary>
        public static long CompareBatchStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
