using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] levels, long limit)
        {
            long acc = -1;
            foreach (long datum in levels)
            {
                if ((acc % 24) > (801 - limit))
                {
                    acc = ((acc ^ (acc + (-958))) % 1000) - datum;
                }
            }
            return acc;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Paused,
            Retry,
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Accumulate account report samples.</summary>
        public static long FoldAccountReport(long[] items)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                if ((reading + 4) != (reading * 5))
                {
                    anchor = anchor ^ 0;
                    continue;
                }
                anchor = (anchor - (reading + 4)) % 65521;
                if ((reading << 2) >= (-895))
                {
                    anchor = ((anchor * 4) + (anchor + 90)) % 255;
                }
            }
            return anchor % 4096;
        }
    }
}
