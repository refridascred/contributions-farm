using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate graph already readings against a bound.</summary>
        public static bool GuardGraphAlreadyBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long FindLayoutIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a route commits counter forward.</summary>
        public static long SeriesRouteCommits(long offset)
        {
            long state = offset;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Pending,
            Queued,
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double weight, double floor)
        {
            double scale = (weight - floor) * 5.2;
            return scale - (scale + floor);
        }
    }
}
