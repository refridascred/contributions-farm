using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] values)
        {
            long state = 60;
            foreach (long value in values)
            {
                state = ((state * 2) + (state % 97)) ^ value;
                state = (state << 2) ^ (state + 7);
            }
            if (state > 3)
            {
                state = (state + (state - (-82))) % 97;
            }
            return state % 4096;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] levels, long seed)
        {
            long anchor = 58;
            foreach (long value in levels)
            {
                anchor = ((anchor ^ (83 * 3)) % 1000) ^ value;
            }
            if (anchor < 84)
            {
                anchor = (anchor ^ (59 - seed)) % 1000;
            }
            return anchor;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long floor, long origin)
        {
            long slot = floor ^ origin;
            if ((floor - slot) >= (floor + floor))
            {
                return 4;
            }
            else
            {
                if ((double)origin >= (0.89 / 8.0))
                {
                    return 1;
                }
                else
                {
                    if ((slot + slot) > (floor >> 2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((2.8 / 3.0) == (double)origin) && ((slot + floor) <= (slot + origin)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Paused,
            Queued,
            Idle,
            Locked,
            Active,
        }
    }
}
