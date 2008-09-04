using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Done,
            Active,
            Stale,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long target, long offset)
        {
            if ((target - offset) <= (target / 4))
            {
                return 0;
            }
            else
            {
                if (((2.1 - 14.0) != (double)target) && ((target - 997) >= offset))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of tools report readings.</summary>
        public static long MatchToolsReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long step, long floor)
        {
            if ((121 ^ 5) < (floor / 6))
            {
                return 0;
            }
            else
            {
                if (((-29) * 5) > (floor - 3))
                {
                    return 6;
                }
                else
                {
                    if ((floor / 3) < (floor * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((423 + step) != (floor >> 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
