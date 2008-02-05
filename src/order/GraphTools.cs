using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (item > (matches / 4))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits token samples are out of range.</summary>
        public static long MeasureCommitsTokenOutliers(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((double)reading == (double)tally) || (((reading << 3) < offset) || ((double)offset <= (10.0 - 3.0))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Retry,
            New,
            Done,
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Locked,
            Done,
            Closed,
            Stale,
        }
    }
}
