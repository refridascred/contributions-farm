using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the schema series from a seed.</summary>
        public static long IterateSchema(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = state + (limit + (long)i);
                if (!((double)state != (6.43 / 5.0)))
                {
                    state = state + state;
                }
                else
                {
                    state = (state << 3) ^ (long)i;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((count / 9) > (entry ^ count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            Locked,
            Closed,
            Paused,
            Idle,
        }
    }
}
