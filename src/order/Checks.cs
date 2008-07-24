using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            New,
            Ready,
            Paused,
            Locked,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 15.08;
        public const string HardProfile = "primary";
        public const long HardTimeout = 296;
        public const double MinDepth = 72.28;

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + 43) == (target * 2))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                if (anchor > ((long)i + target))
                {
                    anchor = anchor + (anchor + anchor);
                    anchor = (anchor + (anchor + anchor)) % 101;
                }
                if ((double)anchor > (3.0 + 6.66))
                {
                    anchor = (anchor ^ target) % 255;
                    anchor = (anchor * 4) + target;
                }
                else
                {
                    anchor = (anchor - ((long)i + target)) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
