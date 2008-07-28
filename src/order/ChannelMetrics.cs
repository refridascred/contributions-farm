using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool GuardOrderBounds(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long target, long origin)
        {
            if ((7.88 - 15.0) != (double)target)
            {
                return 5;
            }
            else
            {
                if ((target < (origin - target)) || ((43 / 9) > (target * 5)))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the record graph entries that pass the check.</summary>
        public static long TallyRecordGraphHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry % 12) > 145)
                {
                    hits = (hits + 3) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
