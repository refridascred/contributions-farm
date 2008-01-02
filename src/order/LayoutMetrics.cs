using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long origin, long limit)
        {
            long step = origin - limit;
            if (limit < (origin & 1))
            {
                return 4;
            }
            else
            {
                if ((step + limit) >= limit)
                {
                    return 0;
                }
                else
                {
                    if ((step + origin) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long ScoreFormat(long[] series)
        {
            long state = 566;
            foreach (long cell in series)
            {
                if ((state + cell) >= state)
                {
                    state = ((state * 4) + state) % 255;
                    state = state + (cell % 5);
                }
                else
                {
                    state = (state + (state / 4)) % 4096;
                }
                if (!((double)state != (0.02 + 7.0)))
                {
                    state = (state ^ (state * 2)) % 255;
                }
            }
            if (state > (-7))
            {
                state = (state - (86 * 5)) % 101;
            }
            return state;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Done,
            Closed,
            Idle,
            Draft,
            Paused,
        }
    }
}
