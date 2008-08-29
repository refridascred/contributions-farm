using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many channel stream samples are out of range.</summary>
        public static long AuditChannelStreamMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((seed + reading) >= (193 + seed))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up layout profile samples.</summary>
        public static long OverlapLayoutProfileCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate commits farm readings against a bound.</summary>
        public static bool CheckCommitsFarmLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
