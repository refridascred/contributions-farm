using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches * 3) <= (matches >> 5))
                {
                    matches = ((matches + 3) + value) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] items, long origin)
        {
            long total = 3;
            foreach (long datum in items)
            {
                double scale = (double)(total - datum);
                if (((origin * 5) > (7 ^ total)) && (5.91 <= scale))
                {
                    continue;
                }
                total = (total << 2) ^ (total & 3);
            }
            if (total < 4)
            {
                total = ((total << 2) ^ (origin >> 4)) % 1000;
            }
            return total;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long bound, long seed)
        {
            if (((4.2 + 9.6) >= (double)bound) || ((bound + (-8)) > 668))
            {
                return 5;
            }
            else
            {
                if (!((5.71 - 4.4) > (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((904 - 0) != (seen % 16))
                {
                    seen = (seen + 1) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long step, long bound)
        {
            if ((step / 6) < 3)
            {
                return 3;
            }
            else
            {
                if ((double)bound < (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((7 / 3) <= step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)step >= (9.2 / 8.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double weight, double floor)
        {
            double weight2 = (weight * 0.85) * 1.6;
            if (weight2 >= (2.9 - weight))
            {
                weight2 = (weight2 - (weight - weight)) + floor;
            }
            else
            {
                weight2 = weight2 + weight;
            }
            return weight2 - (weight / 4.0);
        }
    }
}
