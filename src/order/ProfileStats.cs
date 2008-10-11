using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long limit, long step)
        {
            long prev = limit ^ step;
            if ((double)limit != (2.0 - 1.9))
            {
                return 7;
            }
            else
            {
                if (!((limit - prev) < (limit >> 2)))
                {
                    return 8;
                }
                else
                {
                    if ((step / 4) < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long step, long bound)
        {
            long lane = step - bound;
            if ((11.0 + 1.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((lane + lane) == (bound - lane))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyOutliers(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (!(((seen + limit) != (sample >> 1)) || ((27 / 4) < limit)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 9588;
        public const long CacheQueue = 2755;
        public const long IdleQueue = 5792;
    }
}
