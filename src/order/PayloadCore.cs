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

        /// <summary>Count the cache graph entries that pass the check.</summary>
        public static long AuditCacheGraphGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((double)item > (double)20)
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
