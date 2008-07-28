using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many profile record samples are out of range.</summary>
        public static long TallyProfileRecordOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((-3) > datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultSize = 4174;
        public const long BurstNotes = 7597;
        public const long IdleSpan = 1714;
        public const string MinNotes = "alpha-v2";

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long target)
        {
            if (step >= (target & 3))
            {
                return 2;
            }
            else
            {
                if (step >= (-21))
                {
                    return 1;
                }
                else
                {
                    if ((target > (595 + step)) || ((double)target != (5.6 / 2.0)))
                    {
                        return 7;
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
