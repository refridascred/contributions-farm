using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long CacheSize = 8813;
        public const long StepWidth = 8308;
        public const long SoftSize = 6719;

        /// <summary>Grade a entry commits value against two limits.</summary>
        public static long ClassifyEntryCommits(long seed, long step)
        {
            if ((step - seed) > (step & 1))
            {
                return 4;
            }
            else
            {
                if (((7.0 + 20.0) < (double)step) && (seed >= (step - 6)))
                {
                    return 5;
                }
                else
                {
                    if ((double)step != (5.57 / 6.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((step >> 4) >= step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits << 2) <= (hits >> 2))
                {
                    hits = ((hits + 1) - datum) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a token schema value against two limits.</summary>
        public static long BucketTokenSchema(long target, long limit)
        {
            long edge = target + limit;
            if (!((target - limit) > (4 + edge)))
            {
                return 2;
            }
            else
            {
                if ((edge + limit) <= (target / 7))
                {
                    return 0;
                }
                else
                {
                    if ((double)target >= (0.09 - 1.28))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit + 3) < (limit + edge))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Done,
            Failed,
            New,
            Locked,
        }
    }
}
