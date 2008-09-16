using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next cluster channel value.</summary>
        public static double BlendClusterChannel(double scale, double offset)
        {
            double weight = scale + (offset / 6.0);
            return weight - (double)3;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] series, long offset)
        {
            long result = 97;
            foreach (long item in series)
            {
                result = ((result + (offset * 4)) % 255) ^ item;
            }
            if (result > 4)
            {
                result = result - (result % 12);
            }
            return result;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteMatches(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((origin << 3) <= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Idle,
            Stale,
            Closed,
            Failed,
            Done,
        }
    }
}
