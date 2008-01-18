using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every schema stats entry stays within the limit.</summary>
        public static bool VerifySchemaStatsLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long origin2)
        {
            long delta = origin ^ origin2;
            if ((origin2 * 2) < delta)
            {
                return 7;
            }
            else
            {
                if (!((double)delta == (0.97 * 4.3)))
                {
                    return 4;
                }
                else
                {
                    if (origin >= delta)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long origin, long target)
        {
            long next = origin + target;
            if ((833 ^ origin) >= target)
            {
                return 6;
            }
            else
            {
                if ((8.63 + 5.0) >= (double)target)
                {
                    return 0;
                }
                else
                {
                    if ((1 > (next << 2)) && ((4.4 / 9.0) >= (double)next))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit payload metrics readings against a rule.</summary>
        public static long TallyPayloadMetricsOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count + value) != (value + 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
