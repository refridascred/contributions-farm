using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long floor, long target)
        {
            long lane = floor - target;
            if (((floor / 7) < (5 & 3)) && (lane <= (floor << 3)))
            {
                return 5;
            }
            else
            {
                if ((double)lane > (19.0 / 2.0))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate stats editor readings against a bound.</summary>
        public static bool ValidateStatsEditorBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((step * 4) > (entry & 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Paused,
            Stale,
            Closed,
        }
    }
}
