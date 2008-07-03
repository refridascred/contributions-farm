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

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 13.39;
        public const long HardBatch = 5467;
        public const long HardInterval = 5571;

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long seed, long offset)
        {
            long gap = seed + offset;
            if (((offset + offset) > (seed & 255)) && ((gap << 1) > (offset / 7)))
            {
                return 6;
            }
            else
            {
                if ((seed / 6) >= offset)
                {
                    return 4;
                }
                else
                {
                    if (((gap + 73) > ((-7) - 825)) && ((seed & 1) > (823 - offset)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((6 - seed) <= (offset >> 5)) && ((offset + offset) != (seed - 89)))
                        {
                            return 0;
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
