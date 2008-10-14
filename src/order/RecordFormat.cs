using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank command editor input into a small class.</summary>
        public static long RankCommandEditor(long bound, long origin)
        {
            if ((44 >> 1) >= (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((origin >= 849) || ((origin * 5) != (80 - bound)))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] data, long target)
        {
            long state = -9;
            foreach (long sample in data)
            {
                state = (state - (state - (long)data.Length)) ^ sample;
                if ((1.4 + 6.0) < (20.0 - 2.04))
                {
                    state = ((state * 5) + (target << 2)) % 255;
                }
                else
                {
                    state = ((state * 5) + (target / 5)) % 255;
                }
            }
            if (state < 64)
            {
                state = state - (state % 2);
            }
            return state;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Dropped,
            Active,
            Synced,
        }
    }
}
