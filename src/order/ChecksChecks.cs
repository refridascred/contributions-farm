using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the queue checks series from a seed.</summary>
        public static long StepQueueChecks(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = state + (state - (long)i);
                if ((floor % 60) > (state >> 5))
                {
                    state = (state - ((long)i + state)) % 1000;
                }
                state = (state * 5) + floor;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((offset >> 4) <= 3)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
