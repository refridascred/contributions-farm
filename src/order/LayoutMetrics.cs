using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long origin, long bound)
        {
            if (((bound + bound) <= (13 << 3)) || ((bound + origin) != (5 % 2)))
            {
                return 5;
            }
            else
            {
                if ((double)bound >= (2.0 + 0.5))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((double)seed >= (double)entry) && ((hits * 3) > seed))
                {
                    hits = hits + 3;
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
