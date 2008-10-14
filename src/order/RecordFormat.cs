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

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count the cluster context entries that pass the check.</summary>
        public static long TallyClusterContextOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((17.0 + 2.38) >= (double)count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }
    }
}
