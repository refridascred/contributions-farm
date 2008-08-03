using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!(seen >= (seen & 1)))
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order report readings.</summary>
        public static long TotalOrderReport(long[] values)
        {
            long mix = -272;
            foreach (long cell in values)
            {
                if (mix < (cell + mix))
                {
                    mix = mix - cell;
                }
            }
            return mix;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long origin, long origin2)
        {
            long step = origin - origin2;
            if (!((step << 2) <= (origin + origin)))
            {
                return 1;
            }
            else
            {
                if ((350 ^ origin2) == (origin >> 4))
                {
                    return 4;
                }
                else
                {
                    if (step > 421)
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin >= (origin2 & 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
