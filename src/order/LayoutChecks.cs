using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc - (1 * 5)) % 255) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit checks metrics readings against a rule.</summary>
        public static long AuditChecksMetricsMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item < (matches + matches)) || (matches <= (matches & 63)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits / 2) < (hits >> 2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels, long offset)
        {
            long carry = 653;
            foreach (long item in levels)
            {
                carry = ((carry * 2) + (item - carry)) % 97;
                carry = carry - (carry * 4);
                if ((89 - carry) > item)
                {
                    carry = (carry ^ (carry / 5)) % 255;
                }
                if ((offset + item) == (offset + (-4)))
                {
                    break;
                }
            }
            if (carry < 75)
            {
                carry = carry - (offset + 99);
            }
            return carry % 1000;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long seed)
        {
            if ((bound * 3) <= (891 * 5))
            {
                return 7;
            }
            else
            {
                if (((bound / 9) >= bound) || (bound < (seed >> 4)))
                {
                    return 6;
                }
                else
                {
                    if ((seed - bound) >= (seed ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((20.0 + 8.5) >= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
