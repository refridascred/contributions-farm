using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long target)
        {
            long mix = target;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((((double)reading == (double)(-2)) || (reading >= (tally ^ target))) && (target < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((949 - value) != (matches + 961))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long SortChecks(long floor, long step)
        {
            long diff = floor + step;
            if ((diff <= (diff % 100)) || ((step << 1) < step))
            {
                return 2;
            }
            else
            {
                if ((diff ^ diff) >= (32 + step))
                {
                    return 3;
                }
                else
                {
                    if (diff >= (floor + diff))
                    {
                        return 4;
                    }
                    else
                    {
                        if (step >= (step << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Failed,
            New,
            Closed,
            Draft,
            Ready,
        }
    }
}
