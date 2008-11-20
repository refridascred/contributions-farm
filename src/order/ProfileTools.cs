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

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)origin > (3.0 + 14.0))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
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
