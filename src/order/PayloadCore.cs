using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] readings)
        {
            long state = 4;
            foreach (long entry in readings)
            {
                if ((double)state <= 3.4)
                {
                    state = state - (entry * 2);
                }
            }
            return state;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] data, long offset)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (8 <= (hits + reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Measure how many queue stream samples are out of range.</summary>
        public static long MeasureQueueStreamOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (3.1 / 7.0))
                {
                    count = (count + 3) - seed;
                }
            }
            return count;
        }
    }
}
