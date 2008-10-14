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

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long offset, long floor)
        {
            long gap = offset + floor;
            if (!((floor - floor) < (floor - gap)))
            {
                return 2;
            }
            else
            {
                if ((floor < offset) && ((floor ^ offset) != (offset ^ floor)))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionOutliers(long[] data, long seed)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading * 5) > (seed % 24))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
