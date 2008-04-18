using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a support profile value against two limits.</summary>
        public static long SortSupportProfile(long step, long limit)
        {
            long step2 = step ^ limit;
            if (limit <= 28)
            {
                return 8;
            }
            else
            {
                if ((limit * 5) < step2)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double bias = 0.8 / 7.0;
            if (bias < rate)
            {
                bias = bias + (span + 14.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)(-9)) + (double)(long)i;
            }
            return bias + (rate / 6.0);
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next token buffer value from a seed.</summary>
        public static long RollTokenBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((floor ^ floor) > 74) && ((double)floor == (15.0 - 3.0)))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                else
                {
                    anchor = (anchor * 2) + (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry <= 4)
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
