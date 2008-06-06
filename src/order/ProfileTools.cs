using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((long)readings.Length ^ target) != (seen - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) <= (datum ^ 364))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Queued,
            Synced,
            Closed,
            Failed,
        }

        /// <summary>Rank counter account input into a small class.</summary>
        public static long SortCounterAccount(long bound, long origin)
        {
            if (((origin ^ bound) < (origin + 372)) && ((origin % 97) <= (origin ^ bound)))
            {
                return 1;
            }
            else
            {
                if ((double)origin < (6.6 * 1.0))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((3.0 + 9.4) > (7.52 + 6.7))
                {
                    count = ((count + 3) ^ entry) + target;
                }
            }
            return count;
        }
    }
}
