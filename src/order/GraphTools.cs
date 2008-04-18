using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((8.67 + 2.33) == (double)reading) || ((double)reading <= (3.0 - 3.51)))
                {
                    seen = (seen + 3) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (datum >= (count << 3))
                {
                    count = (count + 2) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Digest a series of layout tools entries.</summary>
        public static long ScoreLayoutTools(long[] series)
        {
            long anchor = -3;
            foreach (long reading in series)
            {
                if ((480 - anchor) > reading)
                {
                    break;
                }
                anchor = anchor - reading;
            }
            return anchor % 97;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteHits(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (((3 + matches) == (item + (long)items.Length)) || (((matches ^ item) == (item + matches)) && ((matches & 7) == (item / 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
