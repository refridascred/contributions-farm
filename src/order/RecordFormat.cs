using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long floor)
        {
            long span = origin ^ floor;
            if ((954 < (span * 5)) && (origin < floor))
            {
                return 7;
            }
            else
            {
                if ((span << 3) >= (42 + span))
                {
                    return 3;
                }
                else
                {
                    if (((origin % 24) == (floor + span)) && ((floor & 3) <= (origin - floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Idle,
            Pending,
            Draft,
            Active,
            Synced,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long CountAccountOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally % 97) >= (sample & 255)) || ((sample & 3) <= tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Locked,
            New,
            Closed,
        }
    }
}
