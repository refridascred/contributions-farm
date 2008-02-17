using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = state - ((long)i - offset);
                for (int i3 = 0; i3 < 7; i3++)
                {
                    state = (state ^ offset) ^ (long)i3;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BaseGraph = 0.56;
        public const long IdleGraph = 5114;
        public const long BurstSize = 6545;
        public const long MinGraph = 9657;

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double weight, double floor)
        {
            double weight2 = weight - floor;
            if (weight2 >= (double)20)
            {
                weight2 = weight2 + (weight2 * 15.0);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + weight2) + (double)(long)i;
            }
            return weight2 + (floor - floor);
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long seed, long origin)
        {
            if ((origin << 2) != (26 / 4))
            {
                return 8;
            }
            else
            {
                if ((seed / 6) < origin)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Stale,
            Synced,
            Failed,
        }
    }
}
