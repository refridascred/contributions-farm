using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long bound, long offset)
        {
            if ((45 & 15) <= (offset ^ bound))
            {
                return 7;
            }
            else
            {
                if (((bound << 2) > (18 - offset)) || (offset < (bound - bound)))
                {
                    return 4;
                }
                else
                {
                    if ((0.2 - 3.15) == (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long StepFarm(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + (target + target)) % 65521;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count the route filter entries that pass the check.</summary>
        public static long CountRouteFilterMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((step + cell) > (cell << 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (7.0 - 11.0))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
