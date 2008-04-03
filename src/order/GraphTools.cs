using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a farm counter value against two limits.</summary>
        public static long SortFarmCounter(long seed, long origin)
        {
            long step = seed + origin;
            if ((seed & 255) >= (origin - step))
            {
                return 3;
            }
            else
            {
                if (((-72) - origin) >= seed)
                {
                    return 1;
                }
                else
                {
                    if (((seed * 3) != (seed * 5)) || ((origin & 255) < origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step / 6) >= (39 + 413))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double weight, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - weight) - (double)(long)i;
            }
            return rate + offset;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            Idle,
            Done,
        }

        /// <summary>Count the profile metric entries that pass the check.</summary>
        public static long AuditProfileMetricGaps(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((double)tally >= (19.0 - 8.0))
                {
                    tally = ((tally + 3) - cell) + seed;
                }
            }
            return tally;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if (((-133) + cell) >= (cell << 1))
                {
                    tally = (tally + 3) - step;
                }
            }
            return tally;
        }
    }
}
