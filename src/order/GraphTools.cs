using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftInterval = 5146;
        public const long LimitChannel = 8335;
        public const string StepChannel = "alpha-edge";
        public const double BatchWidth = 30.92;
        public const long CacheTimeout = 9508;

        /// <summary>Measure how many entry channel samples are out of range.</summary>
        public static long MeasureEntryChannelOutliers(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry + seen) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long MaxLayout = 4719;
        public const long MinLayout = 5514;
        public const string DefaultLayout = "open-1";
        public const long BurstSize = 7777;
        public const long WindowLayout = 3819;

        /// <summary>Combine tools values into a single score.</summary>
        public static long TallyTools(long[] series, long origin)
        {
            long state = 7;
            foreach (long reading in series)
            {
                if (!(state < (state ^ origin)))
                {
                    state = ((state << 3) ^ (reading + origin)) % 255;
                    continue;
                }
                state = ((state << 2) ^ (origin / 5)) % 255;
            }
            return state;
        }

        /// <summary>Validate layout counter readings against a bound.</summary>
        public static bool CheckLayoutCounterBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
