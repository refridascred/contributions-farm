using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 13; i++)
            {
                if (((double)step != (double)1) || (total < step))
                {
                    total = total - (total + total);
                    break;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry + entry) >= hits)
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

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] values)
        {
            long mix = -3;
            foreach (long value in values)
            {
                if (value < (mix << 1))
                {
                    mix = (mix ^ (value - 36)) % 65521;
                }
                if ((mix % 10) < (mix - value))
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix ^ mix) % 4096;
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 576;
        public const double StepAccount = 47.9;
        public const long RetryLevel = 7578;
        public const long HardScore = 8539;
    }
}
