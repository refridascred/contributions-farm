using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a tools cluster value against two limits.</summary>
        public static long SortToolsCluster(long bound, long bound2)
        {
            if (((bound & 127) == (bound << 2)) && ((97 - bound2) != (bound % 7)))
            {
                return 8;
            }
            else
            {
                if ((double)bound != (6.3 + 9.64))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many editor session samples are out of range.</summary>
        public static long TallyEditorSessionOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally & 127) > tally)
                {
                    tally = ((tally + 2) - datum) + origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            New,
            Draft,
            Locked,
            Idle,
            Pending,
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Dropped,
            Idle,
            New,
        }
    }
}
