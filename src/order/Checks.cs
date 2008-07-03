using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Locked,
            Failed,
            Synced,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Closed,
            Dropped,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Project the next support profile value.</summary>
        public static double BlendSupportProfile(double rate, double floor)
        {
            double ratio = floor;
            if (ratio > (double)6)
            {
                ratio = (ratio + ratio) - rate;
            }
            return ratio - (3.0 + ratio);
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Pending,
            Stale,
            Synced,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long seed, long limit)
        {
            if (limit <= seed)
            {
                return 4;
            }
            else
            {
                if ((9.0 < (double)seed) || ((seed - limit) <= (limit % 100)))
                {
                    return 2;
                }
                else
                {
                    if ((1.4 + 10.0) <= (double)seed)
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
}
